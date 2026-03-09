using System;
using UnityEngine;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AdsBreakPopupAdapter : AdsBreakPopup
	{
		public override int MinRewardAmountInt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int MinRewardAmountRV
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int BackgroundTransparency
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override float RewardPercentageInt
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override float RewardPercentageRV
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override bool EnableRVOption
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool NoRewardOffered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override long AutoplayIntAfterMs
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override long DelayUntilNoThanksMs
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override bool EnableCollectButton
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string BackgroundColorHexCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string PopupType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static string ToHtml(Color c)
		{
			return null;
		}
	}
}
