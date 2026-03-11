using System;
using Balancy.Models.JigsawPuzzleEvent;
using UnityEngine;
using UnityEngine.UI;

public class JigsawStrikeOutWidget : MonoBehaviour
{
	private const float PROGRESS_SPEED = 0.2f;

	private const float PROGRESS_DELAY = 0.15f;

	private const float MILESTONE_DELAY = 1f;

	[SerializeField]
	private Image m_fillImage;

	[SerializeField]
	private JigsawIapProgressPip[] m_barPipsAnimator;

	[SerializeField]
	private Text m_piecesLeft;

	[SerializeField]
	private Text m_piecesCollected;

	[SerializeField]
	private Transform m_jigsawCount;

	[SerializeField]
	private StrikeOutPurchaseButton m_strikeOutPurchaseButton;

	[SerializeField]
	private Transform m_priceTransform;

	private bool m_isFillSfxPlaying;

	private string[] m_iapIds;

	private string m_clientId;

	private Action m_progressFinishedCallback;

	private JigsawEvent m_jigsawEvent;

	private int m_totalPieces;

	private int m_currentIAPIndex;

	private void Awake()
	{
	}

	public void Configure(string clientId, Action successCallback, Action progressFinishedCallback)
	{
	}

	public void StartFlow(float percent)
	{
	}

	public string GetCurrentIAPId()
	{
		return null;
	}

	private void FillProgressBarFinished()
	{
	}

	private void FillProgressBar(float fillAmount, Action callback = null)
	{
	}

	private void PlayPipAnim(int index)
	{
	}

	private void PlayFillSfx()
	{
	}

	private void StopFillSfx()
	{
	}
}
