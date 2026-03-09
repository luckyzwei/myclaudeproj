using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardAutoScroll : MonoBehaviour
{
	[SerializeField]
	private LeaderboardWidget m_leaderboardWidget;

	[SerializeField]
	private Button m_topButton;

	[SerializeField]
	private Button m_bottomButton;

	[Header("Optioanal")]
	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private float m_buttonsFadeDuration;

	private Tween m_fadeTween;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnScrollItemRecycled(int recycledDataIndex, int updatedDataIndex, LeaderboardCell _)
	{
	}

	private void ShowCanvasGroup()
	{
	}

	private void HideCanvasGroup()
	{
	}

	private void OnTopButtonClicked()
	{
	}

	private void OnBottomButtonClicked()
	{
	}
}
