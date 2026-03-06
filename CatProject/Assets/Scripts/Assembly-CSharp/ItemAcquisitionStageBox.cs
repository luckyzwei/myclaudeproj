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
		OriginalPosition = Vector2.zero;
		var rt = GetComponent<RectTransform>();
		if (rt != null) OriginalPosition = rt.anchoredPosition;
	}

	public void Init(int prevClearStageIdx, int curStageIdx)
	{
		bPlayNextStage = false;
		if (AllBusinessRoot != null) AllBusinessRoot.SetActive(true);
		if (NextBusinessRoot != null) NextBusinessRoot.SetActive(false);
		if (BossStageDecoObj != null) BossStageDecoObj.SetActive(false);

		if (StageSlots != null)
		{
			for (int i = 0; i < StageSlots.Count; i++)
			{
				if (StageSlots[i] != null)
					StageSlots[i].gameObject.SetActive(i < STAGE_SLOT_COUNT);
			}
		}
	}

	public void OnShowAfter()
	{
		if (bPlayNextStage)
			PlayNextBusiness();
	}

	private void PlayNextBusiness()
	{
		KillSequence();
		if (NextBusinessRoot != null) NextBusinessRoot.SetActive(true);
		MoveSequence = DOTween.Sequence();
		var rt = GetComponent<RectTransform>();
		if (rt != null)
			MoveSequence.Append(rt.DOAnchorPosX(rt.anchoredPosition.x - moveDistance, moveDuration));
	}

	private void KillSequence()
	{
		if (MoveSequence != null)
		{
			MoveSequence.Kill();
			MoveSequence = null;
		}
	}

	private void OnDestroy()
	{
		KillSequence();
	}

	private void OnDisable()
	{
		KillSequence();
	}
}
