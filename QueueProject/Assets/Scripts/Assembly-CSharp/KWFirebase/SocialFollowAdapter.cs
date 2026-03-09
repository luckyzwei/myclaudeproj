using System;
using KWGameSettings;
using UnityEngine;

namespace KWFirebase
{
	[Serializable]
	public class SocialFollowAdapter : SocialFollow
	{
		[SerializeField]
		private bool enabled;

		[SerializeField]
		private int showOnBoot;

		[SerializeField]
		private int showAfterXGames;

		[SerializeField]
		private string socialPlatform;

		[SerializeField]
		private string socialUrl;

		[SerializeField]
		private string rewardType;

		[SerializeField]
		private int rewardAmount;

		[SerializeField]
		private long outOfAppMinTime;

		[SerializeField]
		private bool tiktokBanEnabled;

		[SerializeField]
		private string[] tiktokBanCountries;

		[SerializeField]
		private string tiktokBanFallbackPlatform;

		[SerializeField]
		private string tiktokBanFallbackUrl;

		public override bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override int ShowOnBoot
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int ShowAfterXGames
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override string SocialPlatform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string SocialUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string RewardType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int RewardAmount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override long OutOfAppMinTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override bool TiktokBanEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string[] TiktokBanCountries
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string TiktokBanFallbackPlatform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string TiktokBanFallbackUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
