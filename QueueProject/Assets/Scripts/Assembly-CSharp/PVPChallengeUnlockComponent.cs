using System;
using UnityEngine;
using UnityEngine.UI;

public class PVPChallengeUnlockComponent : MonoBehaviour, IQueueableEntity
{
	[SerializeField]
	private Button m_leaderboardButton;

	[SerializeField]
	private Button m_challengeButton;

	[Space]
	[SerializeField]
	private float m_handAngle;

	[SerializeField]
	private Vector3 m_handOffset;

	[SerializeField]
	private float m_handScale;

	[SerializeField]
	private float m_delayBeforeStep2;

	private PopUpHighlighter m_popUpHighlighter;

	private PopupInputBlocker m_popupInputBlocker;

	private Action m_callback;

	private bool m_alreadyClosed;

	private void Awake()
	{
	}

	private void TryToRegister()
	{
	}

	public int GetPriority()
	{
		return 0;
	}

	public int GetUnlockLocationMask()
	{
		return 0;
	}

	public void StartProcess(Action finishCallback)
	{
	}

	private void OnTabChange(int tabIndex, bool immediately)
	{
	}

	private void PopupClosed()
	{
	}

	private void OnChallengeButtonClick()
	{
	}

	private void CloseAndFinish()
	{
	}

	private void OnDestroy()
	{
	}
}
