using System.Collections.Generic;
using UnityEngine;

public class ItemRewardGetGuideList : MonoBehaviour
{
	[SerializeField]
	private GameObject GuideListRoot;

	[SerializeField]
	private GameObject RewardGetGuidePrefab;

	[SerializeField]
	private int GuideShowCount;

	[SerializeField]
	private TopInfoData GuideRewardItem;

	private List<ItemRewardGetGuide> RewardGetGuideList;

	private List<int> GuideList;

	private void OnEnable()
	{
		if (RewardGetGuideList == null) RewardGetGuideList = new List<ItemRewardGetGuide>();
		if (GuideList == null) GuideList = new List<int>();
	}

	public void Refresh()
	{
		// Update display
	}

	public void SetGuideList(int rewardType, int rewardIdx, int regionType)
	{
		if (GuideList == null) GuideList = new List<int>();
		GuideList.Clear();
	}

	public void SetGuideList(List<int> guideList)
	{
		GuideList = guideList;
		if (GuideList == null || GuideList.Count == 0) { SetEmpty(); return; }
		var picked = PickHighPriorityGuideList(GuideList, GuideShowCount);
	}

	private void SetEmpty()
	{
		if (GuideListRoot != null) GuideListRoot.SetActive(false);
	}

	private List<int> PickHighPriorityGuideList(List<int> guideList, int showCount)
	{
		if (guideList == null) return new List<int>();
		if (guideList.Count <= showCount) return new List<int>(guideList);
		return guideList.GetRange(0, showCount);
	}
}
