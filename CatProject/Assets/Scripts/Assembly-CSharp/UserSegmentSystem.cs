using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine.Networking;

public class UserSegmentSystem
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CPostUserSegment_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public UserSegmentSystem _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

		private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const float TIME_OUT_SEC = 30f;

	private string projectName;

	private string url;

	private UserSegmentSendData sendData;

	private int setParamCount;

	private IDisposable timeoutDisposable;

	private DateTime nextResetTime;

	private bool isResetSegment;

	public Config.RecordCountKeys InappCountKey;

	public Config.RecordCountKeys AdsCountKey;

	public SegmentType PrevSegmentType;

	private const string FirstECPM = "first_ecpm";

	private const string Campaign = "campaign";

	private const string MediaSource = "media_source";

	private const string InstallDate = "install_date";

	private const string UUID = "uuid";

	private const string Segment = "segment";

	private const string Version = "version";

	private const string Platform = "platform";

	private const string CountryCode = "country_code";

	private const string PJ = "pj";

	private const string Inapp = "inapp";

	private const string Ads = "ads";

	private const string InappIds = "inapp_ids";

	private const string PurDate1 = "pur_date1";

	private const string PurDate2 = "pur_date2";

	private const string PurDate3 = "pur_date3";

	private const string AdsDate1 = "ads_date1";

	private const string AdsDate2 = "ads_date2";

	private const string AdsDate3 = "ads_date3";

	private Dictionary<string, bool> dataReady;

	public bool IsAdsTestSegment { get { return false; } }

	public bool IsIAASegment { get { return false; } }

	public bool IsInterstitialSegment { get { return false; } }

	public bool IsOfferWallSegment { get { return false; } }

	public void ClearUserDataParam()
	{
	}

	public void SetECPM(double ecpm)
	{
	}

	public void SetCampaign(string campaign)
	{
	}

	public void SetMediaSource(string mediaSource)
	{
	}

	public void SetCountryCode(string countryCode)
	{
	}

	public void UserDataLoadDone()
	{
	}

	public void SetUserPurchaseDate(string purDate1, string purDate2, string purDate3)
	{
	}

	public void SetUserAdsDate(string adsDate1, string adsDate2, string adsDate3)
	{
	}

	public void CheatUserDataLoadDone()
	{
	}

	private void SetInstallDate(string installDate)
	{
	}

	private void SetInappCount(int inappCount)
	{
	}

	private void SetAdsCount(int adsCount)
	{
	}

	private void SetUUID(string uuid)
	{
	}

	private void SetSegment(int segment)
	{
	}

	private void SetVersion(string version)
	{
	}

	private void SetPlatform(string platform)
	{
	}

	private void SetProject(string pj)
	{
	}

	private void SetInappIds(List<string> inappIds)
	{
	}

	private void SetPurDate1(string purDate1)
	{
	}

	private void SetPurDate2(string purDate2)
	{
	}

	private void SetPurDate3(string purDate3)
	{
	}

	private void SetAdsDate1(string adsDate1)
	{
	}

	private void SetAdsDate2(string adsDate2)
	{
	}

	private void SetAdsDate3(string adsDate3)
	{
	}

	private void CheckDataCount()
	{
	}

	private void CheckSegmentResetTime()
	{
	}

	private void ShouldSendDataAfter9Am()
	{
	}

	public void SendData()
	{
	}

	[AsyncStateMachine(typeof(_003CPostUserSegment_003Ed__67))]
	private UniTaskVoid PostUserSegment()
	{
		return default(UniTaskVoid);
	}

	private void HandleSegmentResponse(UserSegmentResponseData responseData)
	{
	}

	public void SetUserSegmentType(SegmentType type)
	{
	}
}
