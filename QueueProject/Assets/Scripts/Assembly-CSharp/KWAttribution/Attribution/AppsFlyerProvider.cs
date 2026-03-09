using System;
using System.Collections.Generic;
using KWCore;

namespace KWAttribution.Attribution
{
	public class AppsFlyerProvider : ProviderBase
	{
		public static bool s_liveBuildSandboxEnabled;

		private const int WAIT_ATT_AUTHORIZATION_TIME_IN_SECONDS = 75;

		private const string EVENTS_QUEUE_ID = "AppsFlyerProvider.StartAppsFlyer";

		private AppsFlyerEventsManager m_appsFlyerEventsManager;

		private AppsFlyerCrossPromoManager m_appsFlyerCrossPromoManager;

		private bool m_userDeclined;

		private bool m_appsFlyerStarted;

		private bool m_appsFlyerStartCallbackCalled;

		private string m_appID;

		private string m_devKey;

		private void SetAppID()
		{
		}

		private void SetDevKey()
		{
		}

		[EventsQueuePriority(QueueId = "AppsFlyerProvider.StartAppsFlyer", Priority = 300)]
		public override void Initialise()
		{
		}

		public override void DoOnApplicationPause(bool pause)
		{
		}

		public override void SendLevelAchievedEvent(int level, float? score)
		{
		}

		public override void SendEvent(string eventName, Dictionary<string, string> parameters = null, int value = 0)
		{
		}

		public override void AttributeCrossPromoClick(CrossPromoAttributionInfoBase crossPromoInfo, Action<bool, string> clickAttributionCallback)
		{
		}

		public override void AttributeCrossPromoImpression(CrossPromoAttributionInfoBase crossPromoInfo)
		{
		}

		private void InitialisePurchaseConnector()
		{
		}

		private void StartAppsFlyer()
		{
		}

		private void SetCustomerUserID()
		{
		}

		private void SendStartCalledAnalytic()
		{
		}

		private void SendAppsFlyerIdEvent()
		{
		}

		private void OnAppsFlyerStarted(object sender, EventArgs e)
		{
		}

		private void OnDeepLinkReceived(object sender, EventArgs e)
		{
		}

		private void OnConversionDataSuccess(string conversionData)
		{
		}

		private void OnConversionDataFail(string error)
		{
		}

		private void OnAppOpenAttributionSuccess(string attributionData)
		{
		}

		private void OnAppOpenAttributionFail(string error)
		{
		}
	}
}
