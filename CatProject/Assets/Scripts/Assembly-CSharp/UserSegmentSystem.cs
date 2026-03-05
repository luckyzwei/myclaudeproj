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

	public bool IsAdsTestSegment { get { return PrevSegmentType == SegmentType.AdsTest3 || PrevSegmentType == SegmentType.AdsTest4; } }

	public bool IsIAASegment { get { return PrevSegmentType == SegmentType.ADRoasInterOut; } }

	public bool IsInterstitialSegment { get { return false; } }

	public bool IsOfferWallSegment { get { return false; } }

	public void ClearUserDataParam()
	{
		sendData = new UserSegmentSendData();
		dataReady = new Dictionary<string, bool>();
		setParamCount = 0;
	}

	public void SetECPM(double ecpm)
	{
		if (sendData == null) return;
		sendData.first_ecpm = ecpm;
		dataReady[FirstECPM] = true;
		CheckDataCount();
	}

	public void SetCampaign(string campaign)
	{
		if (sendData == null) return;
		sendData.campaign = campaign;
		dataReady[Campaign] = true;
		CheckDataCount();
	}

	public void SetMediaSource(string mediaSource)
	{
		if (sendData == null) return;
		sendData.media_source = mediaSource;
		dataReady[MediaSource] = true;
		CheckDataCount();
	}

	public void SetCountryCode(string countryCode)
	{
		if (sendData == null) return;
		sendData.country_code = countryCode;
		dataReady[CountryCode] = true;
		CheckDataCount();
	}

	public void UserDataLoadDone()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		SetSegment((int)root.UserData.UserSegmentType);
		SetVersion(UnityEngine.Application.version);
		SetPlatform(UnityEngine.Application.platform.ToString());
		SetProject(projectName);
	}

	public void SetUserPurchaseDate(string purDate1, string purDate2, string purDate3)
	{
		SetPurDate1(purDate1);
		SetPurDate2(purDate2);
		SetPurDate3(purDate3);
	}

	public void SetUserAdsDate(string adsDate1, string adsDate2, string adsDate3)
	{
		SetAdsDate1(adsDate1);
		SetAdsDate2(adsDate2);
		SetAdsDate3(adsDate3);
	}

	public void CheatUserDataLoadDone()
	{
		UserDataLoadDone();
	}

	private void SetInstallDate(string installDate)
	{
		if (sendData == null) return;
		sendData.install_date = installDate;
		dataReady[InstallDate] = true;
		CheckDataCount();
	}

	private void SetInappCount(int inappCount)
	{
		if (sendData == null) return;
		sendData.inapp = inappCount;
		dataReady[Inapp] = true;
		CheckDataCount();
	}

	private void SetAdsCount(int adsCount)
	{
		if (sendData == null) return;
		sendData.ads = adsCount;
		dataReady[Ads] = true;
		CheckDataCount();
	}

	private void SetUUID(string uuid)
	{
		if (sendData == null) return;
		sendData.uuid = uuid;
		dataReady[UUID] = true;
		CheckDataCount();
	}

	private void SetSegment(int segment)
	{
		if (sendData == null) return;
		sendData.segment = segment;
		dataReady[Segment] = true;
		CheckDataCount();
	}

	private void SetVersion(string version)
	{
		if (sendData == null) return;
		sendData.version = version;
		dataReady[Version] = true;
		CheckDataCount();
	}

	private void SetPlatform(string platform)
	{
		if (sendData == null) return;
		sendData.platform = platform;
		dataReady[Platform] = true;
		CheckDataCount();
	}

	private void SetProject(string pj)
	{
		if (sendData == null) return;
		sendData.pj = pj;
		dataReady[PJ] = true;
		CheckDataCount();
	}

	private void SetInappIds(List<string> inappIds)
	{
		if (sendData == null) return;
		sendData.inapp_ids = inappIds;
		dataReady[InappIds] = true;
		CheckDataCount();
	}

	private void SetPurDate1(string purDate1)
	{
		if (sendData == null) return;
		sendData.pur_date1 = purDate1;
		dataReady[PurDate1] = true;
	}

	private void SetPurDate2(string purDate2)
	{
		if (sendData == null) return;
		sendData.pur_date2 = purDate2;
		dataReady[PurDate2] = true;
	}

	private void SetPurDate3(string purDate3)
	{
		if (sendData == null) return;
		sendData.pur_date3 = purDate3;
		dataReady[PurDate3] = true;
	}

	private void SetAdsDate1(string adsDate1)
	{
		if (sendData == null) return;
		sendData.ads_date1 = adsDate1;
		dataReady[AdsDate1] = true;
	}

	private void SetAdsDate2(string adsDate2)
	{
		if (sendData == null) return;
		sendData.ads_date2 = adsDate2;
		dataReady[AdsDate2] = true;
	}

	private void SetAdsDate3(string adsDate3)
	{
		if (sendData == null) return;
		sendData.ads_date3 = adsDate3;
		dataReady[AdsDate3] = true;
	}

	private void CheckDataCount()
	{
		setParamCount++;
	}

	private void CheckSegmentResetTime()
	{
		if (DateTime.UtcNow >= nextResetTime)
		{
			isResetSegment = true;
			nextResetTime = DateTime.UtcNow.Date.AddDays(1).AddHours(0);
		}
	}

	private void ShouldSendDataAfter9Am()
	{
		CheckSegmentResetTime();
		if (isResetSegment)
		{
			SendData();
			isResetSegment = false;
		}
	}

	public void SendData()
	{
		if (sendData == null) return;
		PostUserSegment().Forget();
	}

	[AsyncStateMachine(typeof(_003CPostUserSegment_003Ed__67))]
	private UniTaskVoid PostUserSegment()
	{
		return default(UniTaskVoid);
	}

	private void HandleSegmentResponse(UserSegmentResponseData responseData)
	{
		if (responseData == null) return;
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root != null)
			root.SetUserSegmentType((SegmentType)responseData.segment);
	}

	public void SetUserSegmentType(SegmentType type)
	{
		PrevSegmentType = type;
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root != null)
			root.SetUserSegmentType(type);
	}
}
