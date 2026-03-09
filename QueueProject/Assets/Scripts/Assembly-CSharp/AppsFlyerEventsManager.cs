using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AppsFlyerSDK;
using KWAds.Ads;
using KWGameSettings;

public class AppsFlyerEventsManager
{
	[CompilerGenerated]
	private sealed class _003CRecordNonIdleGamePlay_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AppsFlyerEventsManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRecordNonIdleGamePlay_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CResetGameplayTimeOnIdle_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AppsFlyerEventsManager _003C_003E4__this;

		private float _003CidleCounter_003E5__2;

		private int _003Cthreshold_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CResetGameplayTimeOnIdle_003Ed__42(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSendMinGamePlayEvent_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AppsFlyerEventsManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSendMinGamePlayEvent_003Ed__44(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const string INTERSTITIAL_TYPE_NAME = "interstitial";

	private const string REWARD_TYPE_NAME = "reward";

	private const string APPSFLYER_AD_TYPE_PARAM = "af_adrev_ad_type";

	private const string APPSFLYER_AD_CLICK_EVENT = "af_ad_click";

	private const string APPSFLYER_AD_VIEW_EVENT = "af_ad_view";

	private const string PLACEHOLDER = "{0}";

	private const int MINUTE_LENGTH_SECONDS = 60;

	private const int DEFAULT_IDLE_THRESHOLD = 20;

	private const float MIN_GAMEPLAY_EVENT_WAIT_TIME = 1f;

	private bool m_shouldLogAdRevenue;

	private int m_gameplayTime;

	private double m_totalRevenue;

	private int m_lastFiredThreshold;

	private List<string> m_completedEvents;

	private Dictionary<int, int> m_monetaryEventsFired;

	private Hashtable m_deviceCategory;

	private void VerifyAndSendCombinedRevenueEvent(float revenue)
	{
	}

	private void ProcessRevenueEvent(int[] eventValues, int revenueInCents, int lastRevenueThreshold, string thresholdKey, string eventName)
	{
	}

	public void SendLevelAchievedEvent(int level, float? score = null)
	{
	}

	public void SendAppsFlyerEvent(string eventName, Dictionary<string, string> parameters = null, int value = 0)
	{
	}

	private void CheckShouldLogAdRevenue()
	{
	}

	private void HandleLevelAchievedEvent()
	{
	}

	private void HandleOnAdRevenuePaid(CoreMediatorImpressionData impressionData)
	{
	}

	private void HandleOnAdRevenueOverCentsPaid()
	{
	}

	private void SendAdClickedEvent(string adType)
	{
	}

	private void SendAdViewedEvent(string adType)
	{
	}

	private AppsFlyerCustomEvents[] GetCustomEventSettings()
	{
		return null;
	}

	private bool ShouldSendEvent(string eventName)
	{
		return false;
	}

	private int[] GetEventValuesByEventName(string eventName)
	{
		return null;
	}

	private void SendInterstitialClickedEvent(string location)
	{
	}

	private void SendRewardedAdClickedEvent(string adLocation)
	{
	}

	private void SendInterstitialViewedEvent()
	{
	}

	private void SendInterstitialWatchedEvent(string location)
	{
	}

	private void SendRewardWatchedEvent(string location)
	{
	}

	private void SendInterstitialAdWatchedCountEvent()
	{
	}

	private void SendRewardAdWatchedCountEvent()
	{
	}

	private void SendRewardedAdViewedEvent(CoreAdImpressionData placement)
	{
	}

	private void OnMediatorRevenuePaidEvent(CoreMediatorImpressionData impression)
	{
	}

	private void LogAppsFlyerAdRevenue(CoreMediatorImpressionData impression)
	{
	}

	private MediationNetwork GetMediationNetwork(string impressionMediatorName)
	{
		return default(MediationNetwork);
	}

	[IteratorStateMachine(typeof(_003CRecordNonIdleGamePlay_003Ed__41))]
	private IEnumerator RecordNonIdleGamePlay()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResetGameplayTimeOnIdle_003Ed__42))]
	private IEnumerator ResetGameplayTimeOnIdle()
	{
		return null;
	}

	private void HandleMinGamePlayEvent()
	{
	}

	[IteratorStateMachine(typeof(_003CSendMinGamePlayEvent_003Ed__44))]
	private IEnumerator SendMinGamePlayEvent()
	{
		return null;
	}

	public void DoOnApplicationPause(bool pause)
	{
	}
}
