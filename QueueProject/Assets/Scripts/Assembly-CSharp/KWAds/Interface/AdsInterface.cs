using KWAds.Ads;
using UnityEngine;

namespace KWAds.Interface
{
	public class AdsInterface : MonoBehaviour, AdSystemRewardVideos.IDelegate, AdSystemInterstitials.IDelegate, AdSystemBanners.IDelegate, AdSystemNative.IDelegate
	{
		[SerializeField]
		private GameObject m_prefabRewardAdBlocker;

		[SerializeField]
		private GameObject m_prefabClearAds;

		[SerializeField]
		private GameObject m_prefabBannerBackground;

		[SerializeField]
		private GameObject m_nativeViewObject;

		[Header("AdBreakPopup")]
		[SerializeField]
		private GameObject m_fullscreenPrefabAdBreakPopup;

		[SerializeField]
		private GameObject m_bannerPrefabAdBreakPopup;

		public GameObject GetRewardAdBlocker()
		{
			return null;
		}

		public GameObject GetAdClearPrefab()
		{
			return null;
		}

		public GameObject GetBannerBackgroundPrefab()
		{
			return null;
		}

		public GameObject GetFullScreenAdBreakPopup()
		{
			return null;
		}

		public GameObject GetBannerAdBreakPopup()
		{
			return null;
		}

		public GameObject GetNativeView()
		{
			return null;
		}
	}
}
