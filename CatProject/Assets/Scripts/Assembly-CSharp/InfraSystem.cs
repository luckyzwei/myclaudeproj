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

	public int infra_reward_time { get; private set; }

	public int first_infra_building { get; private set; }

	public int InfraRewardTime { get { return 0; } }

	public void Init()
	{
	}

	public void RefreshCollectBtn()
	{
	}

	public void UpdateOneSeconds()
	{
	}

	public void BuildingLevelUp(int BuildingIdx)
	{
	}

	public void GetBuildingRevenue(int idx, Transform Trans)
	{
	}

	public bool GetBuildingRevenueAll()
	{
		return false;
	}
}
