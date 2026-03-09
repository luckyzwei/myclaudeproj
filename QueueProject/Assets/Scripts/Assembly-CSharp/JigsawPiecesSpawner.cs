using System;
using KWCore.UI;
using UnityEngine;

public class JigsawPiecesSpawner : MonoBehaviour, IQueueableEntity
{
	[SerializeField]
	private JigsawFtueHand m_jigsawFtueHand;

	[SerializeField]
	private TabToolbar m_tabToolbar;

	private Action m_callback;

	private void Awake()
	{
	}

	private void OnTabChange(int tabindex, bool immediately)
	{
	}

	private void OnDestroy()
	{
	}

	private void GivePieces()
	{
	}

	private void PuzzleFlowFinished()
	{
	}

	public void StartProcess(Action finishCallback)
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

	private void GameplayEvents_JigsawIapPurchased()
	{
	}

	private void CoreEvents_PopupClosed(PopUpBase popUpBase)
	{
	}
}
