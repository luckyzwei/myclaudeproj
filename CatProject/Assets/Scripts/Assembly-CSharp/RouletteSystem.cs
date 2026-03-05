using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;

public class RouletteSystem
{
	private int roulette_ad_cooltime;

	private Dictionary<int, int> RandRatios;

	private Dictionary<int, int> LuckyDrawRatios;

	public IReactiveProperty<int> RemainNextSpin;

	private int specialday_roulette_ad_cooltime;

	private List<int> specialday_roulette_need_gem;

	public int specialday_roulette_reward_plant;

	public int specialday_roulette_reward_count;

	private Dictionary<int, int> SpecialDayRandRatios;

	public IReactiveProperty<int> SpecialDayRemainNextSpin;

	public Subject<int> OnSpinRoulette;

	public int roulette_need_gem { get; private set; }

	public int roulette_lucky_draw_count { get; private set; }

	public int roulette_confirmed_reward_1 { get; private set; }

	public int roulette_confirmed_reward_2 { get; private set; }

	public int roulette_confirmed_reward { get; private set; }

	public int FinalRouletteNeedGem
	{
		get
		{
			var gameRoot = Singleton<GameRoot>.Instance;
			if (gameRoot == null || gameRoot.AbilitySystem == null) return roulette_need_gem;

			int discount = gameRoot.AbilitySystem.GetActiveBoosterAbilityValue(
				AbilitySystem.AbilityType.RouletteExpenseDec,
				gameRoot.UserData != null && gameRoot.UserData.CurMode != null ? gameRoot.UserData.CurMode.ActiveRegion : 0);

			int finalGem = roulette_need_gem - discount;
			return finalGem > 0 ? finalGem : 0;
		}
	}

	public int FinalLuckyDrawCnt
	{
		get
		{
			var gameRoot = Singleton<GameRoot>.Instance;
			if (gameRoot == null || gameRoot.AbilitySystem == null) return roulette_lucky_draw_count;

			int reduction = gameRoot.AbilitySystem.GetActiveBoosterAbilityValue(
				AbilitySystem.AbilityType.RouletteLuckyDrawDec,
				gameRoot.UserData != null && gameRoot.UserData.CurMode != null ? gameRoot.UserData.CurMode.ActiveRegion : 0);

			int finalCnt = roulette_lucky_draw_count - reduction;
			return finalCnt > 1 ? finalCnt : 1;
		}
	}

	public void Init()
	{
		RemainNextSpin = new ReactiveProperty<int>(0);
		SpecialDayRemainNextSpin = new ReactiveProperty<int>(0);
		OnSpinRoulette = new Subject<int>();

		RandRatios = new Dictionary<int, int>();
		LuckyDrawRatios = new Dictionary<int, int>();
		SpecialDayRandRatios = new Dictionary<int, int>();
		specialday_roulette_need_gem = new List<int>();

		// Default values from table data
		roulette_ad_cooltime = 30;
		roulette_need_gem = 10;
		roulette_lucky_draw_count = 10;
		roulette_confirmed_reward_1 = 1;
		roulette_confirmed_reward_2 = 2;
		roulette_confirmed_reward = 1;

		specialday_roulette_ad_cooltime = 30;
		specialday_roulette_reward_plant = 0;
		specialday_roulette_reward_count = 0;

		// Load existing spin time from user data
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot != null && gameRoot.UserData != null)
		{
			var rouletteData = gameRoot.UserData.RouletteData;
			if (rouletteData != null)
			{
				DateTime now = TimeSystem.GetCurTime();
				if (rouletteData.NextSpinTime > now)
				{
					int remain = (int)(rouletteData.NextSpinTime - now).TotalSeconds;
					RemainNextSpin.Value = remain > 0 ? remain : 0;
				}
			}

			var specialRouletteData = gameRoot.UserData.SpecialDayRouletteData;
			if (specialRouletteData != null)
			{
				DateTime now = TimeSystem.GetCurTime();
				if (specialRouletteData.NextSpinTime > now)
				{
					int remain = (int)(specialRouletteData.NextSpinTime - now).TotalSeconds;
					SpecialDayRemainNextSpin.Value = remain > 0 ? remain : 0;
				}
			}
		}
	}

	public int SelectRandomReward()
	{
		if (RandRatios == null || RandRatios.Count == 0) return 0;

		int totalWeight = 0;
		foreach (var kvp in RandRatios)
		{
			totalWeight += kvp.Value;
		}

		if (totalWeight <= 0) return 0;

		int roll = UnityEngine.Random.Range(0, totalWeight);
		int cumulative = 0;
		foreach (var kvp in RandRatios)
		{
			cumulative += kvp.Value;
			if (roll < cumulative)
			{
				return kvp.Key;
			}
		}

		return 0;
	}

	public int SelectRandomLuckyDrawReward()
	{
		if (LuckyDrawRatios == null || LuckyDrawRatios.Count == 0) return 0;

		int totalWeight = 0;
		foreach (var kvp in LuckyDrawRatios)
		{
			totalWeight += kvp.Value;
		}

		if (totalWeight <= 0) return 0;

		int roll = UnityEngine.Random.Range(0, totalWeight);
		int cumulative = 0;
		foreach (var kvp in LuckyDrawRatios)
		{
			cumulative += kvp.Value;
			if (roll < cumulative)
			{
				return kvp.Key;
			}
		}

		return 0;
	}

	public void SetNextSpinTime()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var rouletteData = gameRoot.UserData.RouletteData;
		if (rouletteData == null)
		{
			rouletteData = new RouletteData();
			gameRoot.UserData.RouletteData = rouletteData;
		}

		DateTime now = TimeSystem.GetCurTime();
		rouletteData.NextSpinTime = now.AddSeconds(roulette_ad_cooltime);
		RemainNextSpin.Value = roulette_ad_cooltime;
	}

	public void InitSpecialDayRoulette()
	{
		SpecialDayRandRatios = new Dictionary<int, int>();
		specialday_roulette_need_gem = new List<int>();

		// Would load special day roulette config from table data
		specialday_roulette_ad_cooltime = 30;
		specialday_roulette_reward_plant = 0;
		specialday_roulette_reward_count = 0;

		SpecialDayRemainNextSpin.Value = 0;
	}

	public int SelectSpecialDayRandomReward()
	{
		if (SpecialDayRandRatios == null || SpecialDayRandRatios.Count == 0) return 0;

		int totalWeight = 0;
		foreach (var kvp in SpecialDayRandRatios)
		{
			totalWeight += kvp.Value;
		}

		if (totalWeight <= 0) return 0;

		int roll = UnityEngine.Random.Range(0, totalWeight);
		int cumulative = 0;
		foreach (var kvp in SpecialDayRandRatios)
		{
			cumulative += kvp.Value;
			if (roll < cumulative)
			{
				return kvp.Key;
			}
		}

		return 0;
	}

	public void SetSpecialDayNextSpinTime()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var rouletteData = gameRoot.UserData.SpecialDayRouletteData;
		if (rouletteData == null)
		{
			rouletteData = new RouletteData();
			gameRoot.UserData.SpecialDayRouletteData = rouletteData;
		}

		DateTime now = TimeSystem.GetCurTime();
		rouletteData.NextSpinTime = now.AddSeconds(specialday_roulette_ad_cooltime);
		SpecialDayRemainNextSpin.Value = specialday_roulette_ad_cooltime;
	}

	public int GetSpecialDayNeedGem()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return 0;

		var rouletteData = gameRoot.UserData.SpecialDayRouletteData;
		if (rouletteData == null) return 0;

		// Gem cost increases with each use based on specialday_roulette_need_gem tiers
		int useCount = rouletteData.LuckydrawCount;
		if (specialday_roulette_need_gem == null || specialday_roulette_need_gem.Count == 0) return 0;

		int tierIdx = useCount;
		if (tierIdx >= specialday_roulette_need_gem.Count)
			tierIdx = specialday_roulette_need_gem.Count - 1;

		return specialday_roulette_need_gem[tierIdx];
	}

	public void AddSpecialDayUseGem()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var rouletteData = gameRoot.UserData.SpecialDayRouletteData;
		if (rouletteData == null) return;

		rouletteData.LuckydrawCount++;
	}

	public void ResetSpecialDayUseGem()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		var rouletteData = gameRoot.UserData.SpecialDayRouletteData;
		if (rouletteData == null) return;

		rouletteData.LuckydrawCount = 0;
	}

	public int GetSpecialDayLuckyDrawReward()
	{
		// Return special day roulette confirmed/lucky draw reward plant idx
		return specialday_roulette_reward_plant;
	}

	public void AddSpecialDayLuckyDrawReward()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.UserData == null) return;

		// Grant the special day lucky draw reward (plant item)
		if (specialday_roulette_reward_plant > 0 && specialday_roulette_reward_count > 0)
		{
			gameRoot.UserData.SetReward(0, specialday_roulette_reward_plant, 0,
				(System.Numerics.BigInteger)specialday_roulette_reward_count);
		}
	}

	public void ResetSpecialDayRoulette()
	{
		SpecialDayRandRatios?.Clear();
		specialday_roulette_need_gem?.Clear();
		SpecialDayRemainNextSpin.Value = 0;
		specialday_roulette_reward_plant = 0;
		specialday_roulette_reward_count = 0;
	}

	public void UpdateOneSeconds()
	{
		if (RemainNextSpin != null && RemainNextSpin.Value > 0)
		{
			RemainNextSpin.Value--;
		}

		if (SpecialDayRemainNextSpin != null && SpecialDayRemainNextSpin.Value > 0)
		{
			SpecialDayRemainNextSpin.Value--;
		}
	}
}
