using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemStageChapter : MonoBehaviour
{
	private struct TweenPoint
	{
		public Transform trans;

		public float number;
	}

	[Header("clear move trans")]
	[SerializeField]
	private RectTransform moveCarRect;

	[SerializeField]
	private List<RectTransform> moveTransList;

	[SerializeField]
	private GameObject clearHideObj;

	[Tooltip("총 구간 이동시간")]
	[SerializeField]
	private float moveDuration;

	private List<TweenPoint> curMoveTrans;

	[SerializeField]
	private List<ItemStageWorldSpot> spotList;

	[SerializeField]
	private GameObject LastChapterObj;

	public int Chapter { get; private set; }

	public int MoveTransCount { get { return moveTransList != null ? moveTransList.Count : 0; } }

	private void Awake()
	{
		curMoveTrans = new List<TweenPoint>();
	}

	public void Init(int chapter, Action<int, Transform> OnClick)
	{
		Chapter = chapter;
		if (spotList == null) return;
		for (int i = 0; i < spotList.Count; i++)
		{
			if (spotList[i] == null) continue;
			int stageIdx = i;
			spotList[i].SetStage(stageIdx);
			spotList[i].OnClick = OnClick;
		}
		if (LastChapterObj != null) LastChapterObj.SetActive(false);
	}

	public void SetActiveHideObj(bool value)
	{
		if (clearHideObj != null) clearHideObj.SetActive(value);
	}

	public void SetActiveName(bool value)
	{
		// Show/hide chapter name display
	}

	public ItemStageWorldSpot GetSpot(int stage)
	{
		if (spotList == null || stage < 0 || stage >= spotList.Count) return null;
		return spotList[stage];
	}

	public Transform GetMoveTrans(int index)
	{
		if (moveTransList == null || index < 0 || index >= moveTransList.Count) return null;
		return moveTransList[index];
	}

	public void StartCarMoveTween(Action Callback)
	{
		if (moveCarRect == null || curMoveTrans == null || curMoveTrans.Count == 0)
		{
			Callback?.Invoke();
			return;
		}
		// Animate car movement along the move trans points
		Callback?.Invoke();
	}

	public void SetNextChapterSpots()
	{
		if (spotList == null) return;
		for (int i = 0; i < spotList.Count; i++)
		{
			if (spotList[i] != null)
				spotList[i].gameObject.SetActive(false);
		}
		if (LastChapterObj != null) LastChapterObj.SetActive(true);
	}

	public void SetMoveTrans(int stage)
	{
		if (curMoveTrans == null) curMoveTrans = new List<TweenPoint>();
		curMoveTrans.Clear();

		if (moveTransList == null) return;
		float totalDist = 0f;
		for (int i = 0; i <= stage && i < moveTransList.Count; i++)
		{
			if (moveTransList[i] == null) continue;
			curMoveTrans.Add(new TweenPoint { trans = moveTransList[i], number = totalDist });
			totalDist += 1f;
		}

		// Position car at the correct stage
		if (moveCarRect != null && curMoveTrans.Count > 0)
		{
			var last = curMoveTrans[curMoveTrans.Count - 1];
			if (last.trans != null)
				moveCarRect.position = last.trans.position;
		}
	}
}
