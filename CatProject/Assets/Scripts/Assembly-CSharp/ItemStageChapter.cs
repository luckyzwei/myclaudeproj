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

	public int MoveTransCount => 0;

	private void Awake()
	{
	}

	public void Init(int chapter, Action<int, Transform> OnClick)
	{
	}

	public void SetActiveHideObj(bool value)
	{
	}

	public void SetActiveName(bool value)
	{
	}

	public ItemStageWorldSpot GetSpot(int stage)
	{
		return null;
	}

	public Transform GetMoveTrans(int index)
	{
		return null;
	}

	public void StartCarMoveTween(Action Callback)
	{
	}

	public void SetNextChapterSpots()
	{
	}

	public void SetMoveTrans(int stage)
	{
	}
}
