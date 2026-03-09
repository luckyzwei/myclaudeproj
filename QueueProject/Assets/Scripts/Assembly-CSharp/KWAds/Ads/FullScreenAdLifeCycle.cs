namespace KWAds.Ads
{
	public class FullScreenAdLifeCycle
	{
		protected enum AdState
		{
			NONE = 0,
			LOADING = 1,
			LOADED = 2,
			FAILED_TO_LOAD = 3,
			SHOWN = 4,
			FAILED_TO_SHOW = 5,
			CLOSED = 6
		}

		private AdState m_adState;

		protected void SetAdState(AdState state)
		{
		}

		protected bool CanClearAd()
		{
			return false;
		}
	}
}
