using Treeplla;
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
		plant_exp_per_s = 1f;
		plant_reward_gem_cooltime = 300;
		CalculateOffline();
	}

	private void CalculateOffline()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (root.UserData.PlantData == null) return;
	}

	public void AddPlant(int idx, int value = 1)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (root.UserData.PlantData == null) return;

		for (int i = 0; i < root.UserData.PlantData.Count; i++)
		{
			if (root.UserData.PlantData[i] != null && root.UserData.PlantData[i].Idx == idx)
			{
				root.UserData.PlantData[i].Count += value;
				return;
			}
		}
		var plantData = new PlantData();
		plantData.Create();
		plantData.Idx = idx;
		plantData.Count = value;
		plantData.IsNew = true;
		root.UserData.PlantData.Add(plantData);
	}

	public void AddFull(int plant, int item_idx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (root.UserData.PlantData == null) return;

		for (int i = 0; i < root.UserData.PlantData.Count; i++)
		{
			if (root.UserData.PlantData[i] != null && root.UserData.PlantData[i].Idx == plant)
			{
				if (root.UserData.PlantData[i].Fulls == null)
					root.UserData.PlantData[i].Fulls = new System.Collections.Generic.Dictionary<int, float>();
				root.UserData.PlantData[i].Fulls[item_idx] = 100f;
				return;
			}
		}
	}

	public void GetGemReward(int plant, Vector3 endPos)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void UpdateOneSeconds()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (root.UserData.PlantData == null) return;

		for (int i = 0; i < root.UserData.PlantData.Count; i++)
		{
			var data = root.UserData.PlantData[i];
			if (data == null) continue;

			// Update exp
			if (data.ExpProperty != null)
				data.ExpProperty.Value += plant_exp_per_s;

			// Update gem reward cooldown
			if (data.RemainNextAbilityUseTime != null && data.RemainNextAbilityUseTime.Value > 0)
				data.RemainNextAbilityUseTime.Value--;
		}
	}

	public bool IsGetablePlant(int idx, int rewardValue)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		if (root.UserData.PlantData == null) return false;

		for (int i = 0; i < root.UserData.PlantData.Count; i++)
		{
			if (root.UserData.PlantData[i] != null && root.UserData.PlantData[i].Idx == idx)
			{
				return root.UserData.PlantData[i].RemainNextAbilityUseTime != null
					&& root.UserData.PlantData[i].RemainNextAbilityUseTime.Value <= 0;
			}
		}
		return false;
	}

	public int GetPlantMaxLevel(int idx)
	{
		return 10;
	}
}
