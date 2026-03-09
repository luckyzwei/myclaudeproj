using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace KWCore.UI
{
	public class KwaleeCanvas : MonoBehaviour
	{
		[SerializeField]
		private Canvas m_canvas;

		[SerializeField]
		private Image m_backgroundImage;

		[SerializeField]
		private Sprite m_bgSprite;

		[SerializeField]
		private bool m_useTopSafeArea;

		[SerializeField]
		private bool m_useBottomSafeArea;

		[SerializeField]
		private bool m_useLeftSafeArea;

		[SerializeField]
		private bool m_useRightSafeArea;

		[Tooltip("Adjusts the bottom area above the banners. Use Bottom Safe Area must be enabled.")]
		[SerializeField]
		private bool m_adjustBottomToBanners;

		[Tooltip("Adjusts to banners only when the banners are enabled. The size might change during the session. Adjust Bottom To Banners must be enabled.")]
		[SerializeField]
		private bool m_adjustToBannersDynamically;

		[Tooltip("Set this to true if this is the gameplay canvas in the main scene.")]
		[FormerlySerializedAs("m_overrideCanvas")]
		[SerializeField]
		private bool m_isGameplayCanvas;

		private RectTransform m_rect;

		private void Awake()
		{
		}

		private void SetGameplayCanvas()
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
