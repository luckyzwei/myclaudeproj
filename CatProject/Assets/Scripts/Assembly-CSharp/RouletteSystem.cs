using System.Collections.Generic;
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

	public int FinalRouletteNeedGem => 0;

	public int FinalLuckyDrawCnt => 0;

	public void Init()
	{
	}

	public int SelectRandomReward()
	{
		return 0;
	}

	public int SelectRandomLuckyDrawReward()
	{
		return 0;
	}

	public void SetNextSpinTime()
	{
	}

	public void InitSpecialDayRoulette()
	{
	}

	public int SelectSpecialDayRandomReward()
	{
		return 0;
	}

	public void SetSpecialDayNextSpinTime()
	{
	}

	public int GetSpecialDayNeedGem()
	{
		return 0;
	}

	public void AddSpecialDayUseGem()
	{
	}

	public void ResetSpecialDayUseGem()
	{
	}

	public int GetSpecialDayLuckyDrawReward()
	{
		return 0;
	}

	public void AddSpecialDayLuckyDrawReward()
	{
	}

	public void ResetSpecialDayRoulette()
	{
	}

	public void UpdateOneSeconds()
	{
	}
}
