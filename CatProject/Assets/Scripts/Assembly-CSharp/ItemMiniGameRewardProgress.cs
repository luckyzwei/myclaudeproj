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
		SlotList = new List<ItemMiniGameRewardProgressSlot>();
	}

	public void Init(int scheduleIdx, int eventIdx)
	{
		ScheduleIdx = scheduleIdx;
		EventIdx = eventIdx;
		Refresh(false);
	}

	public void Refresh(bool playAnim)
	{
		// Update display
	}

	private void OnClaimReward(int order)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
