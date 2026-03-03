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
	}

	public void Refresh()
	{
	}

	public void SetGuideList(int rewardType, int rewardIdx, int regionType)
	{
	}

	public void SetGuideList(List<int> guideList)
	{
	}

	private void SetEmpty()
	{
	}

	private List<int> PickHighPriorityGuideList(List<int> guideList, int showCount)
	{
		return null;
	}
}
