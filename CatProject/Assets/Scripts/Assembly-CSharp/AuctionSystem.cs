using System;
using System.Collections.Generic;
using UniRx;

public class AuctionSystem
{
	public enum E_AuctionResult
	{
		Lose = -1,
		Draw = 0,
		Win = 1
	}

	private bool IsInitDefine;

	public IReactiveProperty<int> AuctionStaminaProperty;

	public IReactiveProperty<int> ChargeStaminaRemainTime;

	public IReactiveProperty<int> FreeStaminaRemainTime;

	public IReactiveProperty<int> AdStaminaRemainTime;

	public int AuctionNpcIdx;

	public int AuctionLevel;

	public int AuctionTier;

	public int auction_house_stamina_max_count { get; private set; }

	public int auction_house_stamina_countup_cooltime { get; private set; }

	public int auction_house_stamina_max_add_count { get; private set; }

	public int auction_house_start_stamina_count { get; private set; }

	public int auction_house_spy_gem_count_1 { get; private set; }

	public int auction_house_random_coin_max_count { get; private set; }

	public int auction_house_random_coin_min_count { get; private set; }

	public int auction_house_random_use_coin { get; private set; }

	public int auction_house_win_point { get; private set; }

	public int auction_house_min_use_coin { get; private set; }

	public int AUCTION_2X_POINT_TRIAL_LIMIT_VALUE { get; private set; }

	public int PREMIUM_PURCHASE_REWARD_POINT { get; private set; }

	public int PREMIUM_BONUS_REWARD_EXCHANGE_RATE { get; private set; }

	public int PREMIUM_BONUS_REWARD_MAX_GEM_VALUE { get; private set; }

	public int PREMIUM_BONUS_REWARD_START_POINT { get; private set; }

	public int PREMIUM_BONUS_REWARD_LIMIT_TIME_SEC { get; private set; }

	public IReactiveProperty<int> PremiumBonusRewardRemainTime { get; private set; }

	public DateTime PremiumBonusRewardEndTime { get; private set; }

	public int MaxStamina { get; private set; }

	public int CurEventIdx { get; private set; }

	public Dictionary<int, int> AuctionOrganizeManager { get; private set; }

	public Dictionary<int, int> AuctionOrganizeCoin { get; private set; }

	public Dictionary<int, int> AuctionOrganizeResult { get; private set; }

	public int EnableUseCoin { get; private set; }

	public bool IsActive2xPointTrial { get; private set; }

	public void Init()
	{
	}

	public void UpdateTime()
	{
	}

	public void SetNewEvent()
	{
	}

	public void EndEvent()
	{
	}

	private void SetEventIdx(int eventIdx)
	{
	}

	private void UpdatePremiumBonusRewardRemainTime()
	{
	}

	private void InitDefine()
	{
	}

	public void GetShopStamina(int reward)
	{
	}

	private int GetUserAuctionTier()
	{
		return 0;
	}

	public void SetAuctionLevel()
	{
	}

	public void AddApplyCoin(int round)
	{
	}

	public void DelApplyCoin(int round)
	{
	}

	public void SetApplyCoin(int round, int setCoin)
	{
	}

	public int GetApplyCoin(int round)
	{
		return 0;
	}

	public void AutoAuction()
	{
	}

	public int GetRemainCoin()
	{
		return 0;
	}

	public void SetOrganizeCoin(int round, int coin)
	{
	}

	public void UseStamina()
	{
	}

	public void StartAuction()
	{
	}

	public void SetAuctionRoundResult(int round, E_AuctionResult result, int usespy)
	{
	}

	public int GetWinCount()
	{
		return 0;
	}

	public int GetLoseCount()
	{
		return 0;
	}

	public bool IsInAuction()
	{
		return false;
	}

	public bool NeedReceivePremiumBonus()
	{
		return false;
	}

	public void ReceivePremiumBonus()
	{
	}

	public void EndAuction()
	{
	}

	public void SetActiveAuctionPass()
	{
	}

	public void OrganizeManager(int round, int manager)
	{
	}

	public bool isOrganizeManager(int round)
	{
		return false;
	}

	public void SetEnemyIdx()
	{
	}

	public void GetPreviewEnemy()
	{
	}

	public void UpdateOneSeconds()
	{
	}

	public int GetPremiumBonusGemValue()
	{
		return 0;
	}

	public bool IsActive2xPoint()
	{
		return false;
	}

	public bool IsNowEnd2xTrial()
	{
		return false;
	}

	private void UpdateIsActive2xPointTrial()
	{
	}
}
