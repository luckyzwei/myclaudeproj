using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ItemAcquisitionStageBox : MonoBehaviour
{
	[SerializeField]
	private List<ItemAcquisitionStageSlot> StageSlots;

	[SerializeField]
	private GameObject AllBusinessRoot;

	[SerializeField]
	private GameObject NextBusinessRoot;

	[SerializeField]
	private GameObject BossStageDecoObj;

	[Header("Business Move Settings")]
	[SerializeField]
	private float moveDuration;

	[SerializeField]
	private float moveDistance;

	private bool bPlayNextStage;

	private Sequence MoveSequence;

	private Vector2 OriginalPosition;

	private const int STAGE_SLOT_COUNT = 4;

	private const int STAGE_SLOT_PREV_IDX = 0;

	private const int STAGE_SLOT_CLEAR_IDX = 1;

	private const int STAGE_SLOT_CUR_IDX = 2;

	private void Awake()
	{
	}

	public void Init(int prevClearStageIdx, int curStageIdx)
	{
	}

	public void OnShowAfter()
	{
	}

	private void PlayNextBusiness()
	{
	}

	private void KillSequence()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
