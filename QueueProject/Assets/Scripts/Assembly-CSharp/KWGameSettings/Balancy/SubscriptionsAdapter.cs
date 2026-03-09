namespace KWGameSettings.Balancy
{
	public class SubscriptionsAdapter : Subscription
	{
		public const string SUBSCRIPTION_ITEM_ID = "subscription";

		public override string ProductClientIDWeekly
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ProductClientIDMonthly
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string InventoryItemClientID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool EnabledIOS
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool EnabledAndroid
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override int FirstShowAfterXBoots
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int FirstShowAfterXBootsThisVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int FirstShowAfterXGames
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int LoopShowAfterXBoots
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int LoopShowAfterXBootsThisVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int LoopShowAfterXGames
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override string PrivacyAndTermsLink
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int TrialPeriodLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override string SubscriptionLink
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool HasSubscribed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override long GetServerTimeForSubscription
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override void RevokeSubscriptionItems()
		{
		}

		public override void GiveSubscriptionItems()
		{
		}

		public override void GiveDailyRewardAndShowPopup()
		{
		}
	}
}
