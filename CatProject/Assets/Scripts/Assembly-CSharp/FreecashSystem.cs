using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class FreecashSystem
{
	private Subject<Unit> OnInit;

	private Subject<bool> OnRecvIsLinkedRes;

	private string account;

	private string mediaSource;

	public IObservable<Unit> OnInitObservable { get { return OnInit; } }

	public IObservable<bool> OnRecvIsLinkedResObservable { get { return OnRecvIsLinkedRes; } }

	public void Init(string _account)
	{
		account = _account;
		OnInit = new Subject<Unit>();
		OnRecvIsLinkedRes = new Subject<bool>();
		OnInit.OnNext(Unit.Default);
	}

	private static readonly HashSet<string> AllowCountryCodes = new HashSet<string>
	{
		"US", "GB", "CA", "AU", "DE", "FR", "NL", "SE", "NO", "DK", "FI",
		"AT", "CH", "BE", "IE", "NZ", "SG", "IT", "ES", "PT", "PL"
	};

	private static readonly HashSet<string> BoostTargetCountryCodes = new HashSet<string>
	{
		"US", "GB", "CA", "AU", "DE"
	};

	private static readonly HashSet<string> BlockedCountryCodes = new HashSet<string>
	{
		"CN", "KP", "IR", "CU", "SY"
	};

	public static bool IsAllowCountryCode(string countryCode)
	{
		if (string.IsNullOrEmpty(countryCode)) return false;
		return AllowCountryCodes.Contains(countryCode.ToUpperInvariant());
	}

	public static bool IsBoostTargetCountry(string countryCode)
	{
		if (string.IsNullOrEmpty(countryCode)) return false;
		return BoostTargetCountryCodes.Contains(countryCode.ToUpperInvariant());
	}

	public static bool IsBlockedCountry(string countryCode)
	{
		if (string.IsNullOrEmpty(countryCode)) return false;
		return BlockedCountryCodes.Contains(countryCode.ToUpperInvariant());
	}

	public bool IsFromFreecashInternal()
	{
		return !string.IsNullOrEmpty(mediaSource) && mediaSource.Contains("freecash");
	}

	public void SetMediaSource(string _mediaSource)
	{
		mediaSource = _mediaSource;
	}

	public async UniTask<(FreecashIsLinkedResArg, UnityWebRequest.Result)> SendIsLinkedReq()
	{
		return await SendIsLinkedReq(account);
	}

	public async UniTask<(FreecashIsLinkedResArg, UnityWebRequest.Result)> SendIsLinkedReq(string _account)
	{
		string url = FreecashConfig.GetUrlIsLinked();
		var arg = new FreecashIsLinkedReqArg
		{
			account_id = _account,
			utm_campaign = FreecashConfig.GetCampaign()
		};
		var result = await IsLinkedReq(url, arg);
		OnRecvIsLinkedRes?.OnNext(result.Item1 != null && result.Item1.is_linked);
		return result;
	}

	public static async UniTask<(FreecashIsLinkedResArg, UnityWebRequest.Result)> IsLinkedReq(string url, FreecashIsLinkedReqArg arg)
	{
		var resp = new FreecashIsLinkedResArg();
		string jsonBody = JsonUtility.ToJson(arg);
		var request = new UnityWebRequest(url, UnityWebRequest.kHttpVerbPOST);
		byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonBody);
		request.uploadHandler = new UploadHandlerRaw(bodyRaw);
		request.downloadHandler = new DownloadHandlerBuffer();
		request.SetRequestHeader("Content-Type", "application/json");

		await request.SendWebRequest();

		if (request.result == UnityWebRequest.Result.Success)
		{
			resp = JsonUtility.FromJson<FreecashIsLinkedResArg>(request.downloadHandler.text);
		}
		var ret = request.result;
		request.Dispose();
		return (resp, ret);
	}

	public async UniTask<string> OpenUrl()
	{
		return await OpenUrl(account);
	}

	public static async UniTask<string> OpenUrl(string account)
	{
		var totalStartTime = DateTime.UtcNow;
		string campaign = FreecashConfig.GetCampaign();
		string sub = FreecashConfig.GetSub();
		string click_id = account;
		string gaid = "";

#if UNITY_ANDROID
		gaid = GetAndroidGaid();
		if (string.IsNullOrEmpty(gaid))
		{
			gaid = await GetAndroidAsidAsync(5f);
		}
#elif UNITY_IOS
		gaid = await GetIdfaAsync(5f);
#endif

		string baseUrl = $"https://freecash.com/offer?campaign={campaign}&sub={sub}&click_id={click_id}&gaid={gaid}";
		Application.OpenURL(baseUrl);
		return baseUrl;
	}

	private static string GetAndroidGaid()
	{
#if UNITY_ANDROID && !UNITY_EDITOR
		try
		{
			var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			var currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
			var adIdClient = new AndroidJavaClass("com.google.android.gms.ads.identifier.AdvertisingIdClient");
			var adInfo = adIdClient.CallStatic<AndroidJavaObject>("getAdvertisingIdInfo", currentActivity);
			return adInfo.Call<string>("getId");
		}
		catch (Exception)
		{
			return null;
		}
#else
		return null;
#endif
	}

	private static async UniTask<string> GetAndroidAsidAsync(float timeoutSec)
	{
#if UNITY_ANDROID && !UNITY_EDITOR
		try
		{
			var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			var currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
			var appSet = new AndroidJavaClass("com.google.android.gms.appset.AppSet");
			var client = appSet.CallStatic<AndroidJavaObject>("getClient", currentActivity);
			var task = client.Call<AndroidJavaObject>("getAppSetIdInfo");

			float elapsed = 0f;
			while (!task.Call<bool>("isComplete") && elapsed < timeoutSec)
			{
				await UniTask.Yield();
				elapsed += Time.deltaTime;
			}

			if (task.Call<bool>("isSuccessful"))
			{
				var info = task.Call<AndroidJavaObject>("getResult");
				return info.Call<string>("getId");
			}
		}
		catch (Exception) { }
#endif
		return "";
	}

	private static async UniTask<string> GetIdfaAsync(float timeoutSec)
	{
#if UNITY_IOS && !UNITY_EDITOR
		try
		{
			var result = await Unity.Advertisement.IosSupport.ATTrackingStatusBinding.RequestAuthorizationTrackingAsync();
			return UnityEngine.iOS.Device.advertisingIdentifier;
		}
		catch (Exception) { }
#endif
		await UniTask.Yield();
		return "";
	}
}
