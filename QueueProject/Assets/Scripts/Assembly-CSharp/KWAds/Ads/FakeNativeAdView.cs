using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KWAds.Ads
{
	[RequireComponent(typeof(EventTrigger))]
	public class FakeNativeAdView : MonoBehaviour
	{
		public RawImage nativeAd;

		private void Start()
		{
		}

		public void UpdateNative(Texture ad)
		{
		}
	}
}
