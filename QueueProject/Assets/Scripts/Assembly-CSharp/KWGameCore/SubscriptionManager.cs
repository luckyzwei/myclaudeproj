using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Balancy.API.Payments;
using KWGameCore.Interface;

namespace KWGameCore
{
	public class SubscriptionManager
	{
		public delegate void BasicDelegate();

		private const long DAY_MS = 86400000L;

		private GameCoreInterface m_delegate;

		private int m_gamesPopupLastShowGamePlayed;

		private List<SubscriptionInfo> m_subscriptionInfos;

		private static bool s_isStillSubbed;

		private bool IsRewardRevoked => false;

		public static event BasicDelegate SubscriptionUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private static void SetRewardRevoked(bool value)
		{
		}

		public static void SendSubscriptionUpdated()
		{
		}

		public SubscriptionManager(GameCoreInterface del)
		{
		}

		private void OnProductsFetched()
		{
		}

		private void OnBalancyPurchasesFetched(PurchasesResponseData obj)
		{
		}

		private void OnSdkLoaded()
		{
		}

		private bool ShowIAPS()
		{
			return false;
		}

		private bool CanShowPopupCommon()
		{
			return false;
		}

		public bool GetSubscriptionsEnabled()
		{
			return false;
		}

		public bool TryShowGamesPlayedPopUp()
		{
			return false;
		}

		private void ShowGamePopUp()
		{
		}

		public bool TryShowBootPopUp()
		{
			return false;
		}

		private void ShowBootPopup()
		{
		}

		public bool ShowUserRequestedSubscriptionFullScreenPopUp()
		{
			return false;
		}

		public string GetSubscriptionInventoryItemClientID()
		{
			return null;
		}

		public void OpenAppSubscription()
		{
		}

		public void GetSubscriptions()
		{
		}

		private void OnSubscriptionsObtained(Dictionary<string, SubscriptionInfo> obj)
		{
		}

		private void ValidateSubscription()
		{
		}

		private static void CheckIfShouldAddVIPItems()
		{
		}

		private void CheckIfShouldRevokeItems()
		{
		}

		public static void GiveSubscriptionItems()
		{
		}

		public static void OnSubscriptionPurchased(bool giveItems = true)
		{
		}

		public static bool CheckForDailyReward()
		{
			return false;
		}

		public static void GiveDailyReward()
		{
		}

		public static bool GetSubscribed()
		{
			return false;
		}
	}
}
