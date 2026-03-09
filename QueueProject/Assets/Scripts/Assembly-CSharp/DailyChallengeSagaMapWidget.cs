using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DailyChallengeSagaMapWidget : MonoBehaviour
{
	[SerializeField]
	private RectTransform m_nodeParent;

	[SerializeField]
	private int m_maxNumNodesToSpawn;

	[Header("Scrolling")]
	[SerializeField]
	private ScrollRect m_scrollRect;

	[SerializeField]
	private float m_scrollFlowDelay;

	[SerializeField]
	private RectTransform m_activeLevelScrollTarget;

	[Header("PressedEvent")]
	[SerializeField]
	private UnityEvent<int> m_sagaMapLevelPressedEvent;

	[SerializeField]
	private int m_scrollIndex;

	private List<LadderCell> m_spawnedCells;

	[ContextMenu("Scroll")]
	private void DoScroll()
	{
	}

	public void SetNodesList(List<LadderCell> ladderCells)
	{
	}

	public void ScrollToNode(int index, float time, Action callback)
	{
	}

	private LadderCell GetNodeForLevel(int level)
	{
		return null;
	}

	private Vector2 GetAnchoredPosForLevel(int level)
	{
		return default(Vector2);
	}

	private void TryCleanUpScroll()
	{
	}

	public Transform GetNodesParent()
	{
		return null;
	}

	public void SetProgress(int currentCell, float progress)
	{
	}
}
