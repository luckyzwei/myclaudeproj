using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class SubscriptionAdapter : Subscription
	{
		[SerializeField]
		private string productClientIDWeekly;

		[SerializeField]
		private string productClientIDMonthly;

		[SerializeField]
		private string inventoryItemClientID;

		[SerializeField]
		private bool enabledIOS;

		[SerializeField]
		private bool enabledAndroid;

		[SerializeField]
		private int firstShowAfterXBoots;

		[SerializeField]
		private int firstShowAfterXBootsThisVersion;

		[SerializeField]
		private int firstShowAfterXGames;

		[SerializeField]
		private int loopShowAfterXBoots;

		[SerializeField]
		private int loopShowAfterXBootsThisVersion;

		[SerializeField]
		private int loopShowAfterXGames;

		[SerializeField]
		private string privacyAndTermsLink;

		[SerializeField]
		private int trialPeriodLength;

		[SerializeField]
		private string subscriptionLink;

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

		public override bool HasSubscribed { get; set; }

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
