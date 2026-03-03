using UnityEngine;

public class PlantSystem
{
	public enum GrowType
	{
		TonicUse = 1,
		SelfUse = 2
	}

	public enum E_PlantGetType
	{
		None = 0,
		Roulette = 1,
		WeeklyReward = 2,
		PiggyBank = 3,
		Starter = 4,
		Anniversary = 5,
		OneTime = 6,
		Tarot = 7
	}

	public float plant_exp_per_s { get; private set; }

	public int plant_reward_gem_cooltime { get; private set; }

	public void Init()
	{
	}

	private void CalculateOffline()
	{
	}

	public void AddPlant(int idx, int value = 1)
	{
	}

	public void AddFull(int plant, int item_idx)
	{
	}

	public void GetGemReward(int plant, Vector3 endPos)
	{
	}

	public void UpdateOneSeconds()
	{
	}

	public bool IsGetablePlant(int idx, int rewardValue)
	{
		return false;
	}

	public int GetPlantMaxLevel(int idx)
	{
		return 0;
	}
}
