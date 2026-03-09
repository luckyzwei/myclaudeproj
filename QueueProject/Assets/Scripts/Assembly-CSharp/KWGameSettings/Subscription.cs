using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class Subscription
	{
		public abstract string ProductClientIDWeekly { get; set; }

		public abstract string ProductClientIDMonthly { get; set; }

		public abstract string InventoryItemClientID { get; set; }

		public abstract bool EnabledIOS { get; set; }

		public abstract bool EnabledAndroid { get; set; }

		public abstract int FirstShowAfterXBoots { get; set; }

		public abstract int FirstShowAfterXBootsThisVersion { get; set; }

		public abstract int FirstShowAfterXGames { get; set; }

		public abstract int LoopShowAfterXBoots { get; set; }

		public abstract int LoopShowAfterXBootsThisVersion { get; set; }

		public abstract int LoopShowAfterXGames { get; set; }

		public abstract string PrivacyAndTermsLink { get; set; }

		public abstract int TrialPeriodLength { get; set; }

		public abstract string SubscriptionLink { get; set; }

		public abstract bool HasSubscribed { get; set; }

		public abstract long GetServerTimeForSubscription { get; set; }

		public abstract void RevokeSubscriptionItems();

		public abstract void GiveSubscriptionItems();

		public abstract void GiveDailyRewardAndShowPopup();
	}
}
