namespace KWAds.Ads
{
	public abstract class FakeAdsGUI
	{
		protected bool m_isFakeAdReady;

		protected bool m_isShowingAd;

		protected FakeAdsMediationSettings m_mediatorSettings;

		public abstract void LoadAd();

		public abstract void ShowAd(string placement);

		public abstract void DestroyAd();
	}
}
