using DG.Tweening;
using UnityEngine;

public class LockedPopUp : MonoBehaviour
{
	[SerializeField]
	private Vector2 m_startPos;

	[SerializeField]
	private Vector2 m_finalPos;

	[SerializeField]
	private float m_animationTime;

	[SerializeField]
	private Ease m_ease;

	[SerializeField]
	private float m_delayAfterAnimation;

	[Header("Fade Animation")]
	[SerializeField]
	private bool m_doFade;

	[SerializeField]
	private float m_fadeInTime;

	[SerializeField]
	private float m_fadeOutTime;

	[Header("References")]
	[SerializeField]
	private TabToolbarButton m_tab;

	[SerializeField]
	private RectTransform m_transform;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LockedTabClicked(int tabIndex)
	{
	}

	private void Activate()
	{
	}

	private void FadeAway()
	{
	}
}
