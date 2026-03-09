using UnityEngine;

namespace KWCore.UI
{
	[RequireComponent(typeof(RectTransform))]
	public class ScreenSafeAreaScaler : MonoBehaviour
	{
		[SerializeField]
		private bool m_useTopSafeArea;

		[SerializeField]
		private bool m_useBottomSafeArea;

		[SerializeField]
		private bool m_useLeftSafeArea;

		[SerializeField]
		private bool m_useRightSafeArea;

		[Tooltip("Adjusts the bottom area above the banners.")]
		[SerializeField]
		private bool m_adjustBottomToBanners;

		[Tooltip("Adjusts to banners only when the banners are enabled. The size might change during the session.")]
		[SerializeField]
		private bool m_adjustToBannersDynamically;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void UpdateSafeArea()
		{
		}

		private bool ShouldAdjustToBanners()
		{
			return false;
		}
	}
}
