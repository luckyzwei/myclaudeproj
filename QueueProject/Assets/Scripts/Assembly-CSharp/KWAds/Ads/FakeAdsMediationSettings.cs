using UnityEngine;

namespace KWAds.Ads
{
	public class FakeAdsMediationSettings : ScriptableObject
	{
		public const string SCRIPTABLE_PATH = "Assets/Kwalee/Resources/FakeAds";

		public const string SCRIPTABLE_FULL_PATH = "Assets/Kwalee/Resources/FakeAds/FakeAdsMediationSettings.asset";

		private const string SCRIPTABLE_FILENAME = "FakeAdsMediationSettings.asset";

		public FakeAdSettingsInfo interstitialAdImpressionInfo;

		public FakeAdSettingsInfo rewardVideoAdImpressionInfo;

		public FakeAdSettingsInfo bannerAdImpressionInfo;

		public FakeAdSettingsInfo nativeAdImpressionInfo;

		[Space(10f)]
		[Header("Mediator Settings")]
		public bool fakeInterstitialActive;

		public float interstitialAdLoadDelay;

		public int interstitialAdCloseDelay;

		[Range(0f, 1f)]
		public float interstitialAdNoFillRate;

		[Space(5f)]
		public bool fakeRewardVideoActive;

		public float rewardVideoAdLoadDelay;

		public int rewardVideoAdCloseDelay;

		public int rewardVideoAdSkipDelay;

		[Range(0f, 1f)]
		public float rewardVideoAdNoFillRate;

		[Space(5f)]
		public bool fakeNativeActive;

		public float nativeAdLoadDelay;

		[Range(0f, 1f)]
		public float nativeAdNoFillRate;

		[Space(5f)]
		public bool fakeBannerActive;

		public float bannerAdLoadDelay;

		[Range(0f, 1f)]
		public float bannerAdNoFillRate;
	}
}
