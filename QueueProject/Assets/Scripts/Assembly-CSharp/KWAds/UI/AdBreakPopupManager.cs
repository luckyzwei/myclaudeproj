using System;
using KWAds.Ads;

namespace KWAds.UI
{
	public class AdBreakPopupManager
	{
		private AdBreakPopupBase m_adBreakPopup;

		private readonly AdSystemInterstitials.IDelegate m_delegate;

		public AdBreakPopupManager(AdSystemInterstitials.IDelegate del)
		{
		}

		public void ShowAdBreakPopup(Action interstitialAdShowHandler, Action rewardAdCallback)
		{
		}

		private AdBreakPopupType GetPopupTypeFromSettings()
		{
			return default(AdBreakPopupType);
		}

		private AdBreakPopupBase CreateAdBreakPopup(AdBreakPopupType popupType)
		{
			return null;
		}

		public void CloseCurrentPopup()
		{
		}

		private void ClearAdBreakPopup()
		{
		}
	}
}
