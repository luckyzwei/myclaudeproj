using System.Collections.Generic;
using Treeplla;
using UnityEngine;

public class ItemMiniGameRewardProgress : MonoBehaviour
{
	[SerializeField]
	private SliderTextComponent ProgressSlider;

	[SerializeField]
	private Transform SlotRootTr;

	[SerializeField]
	private ItemMiniGameRewardProgressSlot SlotPrefab;

	private List<ItemMiniGameRewardProgressSlot> SlotList;

	private List<MiniGameDiggingInfoData> RewardStepTables;

	private int ScheduleIdx;

	private int EventIdx;

	private void Awake()
	{
	}

	public void Init(int scheduleIdx, int eventIdx)
	{
	}

	public void Refresh(bool playAnim)
	{
	}

	private void OnClaimReward(int order)
	{
	}
}
