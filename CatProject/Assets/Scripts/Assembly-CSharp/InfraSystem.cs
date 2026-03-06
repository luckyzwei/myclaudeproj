using UniRx;
using UnityEngine;

public class InfraSystem
{
	public enum BuildingInfraType
	{
		Money = 1,
		Mood = 2,
		Power = 3
	}

	public IReactiveProperty<bool> IsCollectPossible;

	private int remainRewardTime;

	public int infra_reward_time { get; private set; }

	public int first_infra_building { get; private set; }

	public int InfraRewardTime { get { return remainRewardTime; } }

	public void Init()
	{
		IsCollectPossible = new ReactiveProperty<bool>(false);
		infra_reward_time = 600; // 10 minutes
		first_infra_building = 1;
		remainRewardTime = infra_reward_time;
	}

	public void RefreshCollectBtn()
	{
		if (IsCollectPossible != null)
		{
			IsCollectPossible.Value = remainRewardTime <= 0;
		}
	}

	public void UpdateOneSeconds()
	{
		if (remainRewardTime > 0)
		{
			remainRewardTime--;
			if (remainRewardTime <= 0)
			{
				RefreshCollectBtn();
			}
		}
	}

	public void BuildingLevelUp(int BuildingIdx)
	{
	}

	public void GetBuildingRevenue(int idx, Transform Trans)
	{
		// Would collect revenue from a specific building with effect at Transform position
		remainRewardTime = infra_reward_time;
		RefreshCollectBtn();
	}

	public bool GetBuildingRevenueAll()
	{
		if (remainRewardTime > 0)
			return false;

		// Would collect revenue from all buildings
		remainRewardTime = infra_reward_time;
		RefreshCollectBtn();
		return true;
	}
}
