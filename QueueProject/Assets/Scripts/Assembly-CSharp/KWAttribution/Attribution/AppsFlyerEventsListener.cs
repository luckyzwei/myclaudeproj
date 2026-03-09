using System;
using AppsFlyerSDK;
using UnityEngine;

namespace KWAttribution.Attribution
{
	public class AppsFlyerEventsListener : MonoBehaviour, IAppsFlyerConversionData, IAppsFlyerUserInvite
	{
		public static Action<object, EventArgs> OnAppsFlyerStartedEvent;

		public static Action<object, EventArgs> OnDeepLinkReceivedEvent;

		public static Action<string> OnConversionDataSuccessEvent;

		public static Action<string> OnConversionDataFailEvent;

		public static Action<string> OnAppOpenAttributionSuccessEvent;

		public static Action<string> OnAppOpenAttributionFailEvent;

		public static Action<string> OnOpenStoreLinkGenerated;

		private static AppsFlyerEventsListener s_instance;

		public static AppsFlyerEventsListener Instance => null;

		public static void Initialise()
		{
		}

		public void StartListening()
		{
		}

		private void OnDestroy()
		{
		}

		private void AppsFlyerStarted(object sender, EventArgs e)
		{
		}

		private void OnDeepLinkReceived(object sender, EventArgs e)
		{
		}

		public void onConversionDataSuccess(string conversionData)
		{
		}

		public void onConversionDataFail(string error)
		{
		}

		public void onAppOpenAttribution(string attributionData)
		{
		}

		public void onAppOpenAttributionFailure(string error)
		{
		}

		public void onOpenStoreLinkGenerated(string link)
		{
		}

		public void onInviteLinkGenerated(string link)
		{
		}

		public void onInviteLinkGeneratedFailure(string error)
		{
		}

		public void didReceivePurchaseRevenueValidationInfo(string validationInfo)
		{
		}

		public void didReceivePurchaseRevenueError(string error)
		{
		}
	}
}
