using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class AdsBreakPopup
	{
		public abstract int MinRewardAmountInt { get; set; }

		public abstract int MinRewardAmountRV { get; set; }

		public abstract int BackgroundTransparency { get; set; }

		public abstract float RewardPercentageInt { get; set; }

		public abstract float RewardPercentageRV { get; set; }

		public abstract bool EnableRVOption { get; set; }

		public abstract bool NoRewardOffered { get; set; }

		public abstract long AutoplayIntAfterMs { get; set; }

		public abstract long DelayUntilNoThanksMs { get; set; }

		public abstract bool EnableCollectButton { get; set; }

		public abstract string BackgroundColorHexCode { get; set; }

		public abstract string PopupType { get; set; }
	}
}
