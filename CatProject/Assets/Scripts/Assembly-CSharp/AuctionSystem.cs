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
		InitDefine();
		AuctionStaminaProperty = new ReactiveProperty<int>(0);
		ChargeStaminaRemainTime = new ReactiveProperty<int>(0);
		FreeStaminaRemainTime = new ReactiveProperty<int>(0);
		AdStaminaRemainTime = new ReactiveProperty<int>(0);
		PremiumBonusRewardRemainTime = new ReactiveProperty<int>(0);
		AuctionOrganizeManager = new Dictionary<int, int>();
		AuctionOrganizeCoin = new Dictionary<int, int>();
		AuctionOrganizeResult = new Dictionary<int, int>();

		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData != null)
		{
			AuctionStaminaProperty.Value = auctionData.Stamina;
			AuctionNpcIdx = auctionData.EnemyIdx;
			SetAuctionLevel();
		}

		MaxStamina = auction_house_stamina_max_count + auction_house_stamina_max_add_count;
		UpdateIsActive2xPointTrial();
	}

	public void UpdateTime()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}
		DateTime now = DateTime.UtcNow;

		if (AuctionStaminaProperty.Value < MaxStamina && auctionData.StaminaChargingTime > DateTime.MinValue)
		{
			int chargeRemain = (int)(auctionData.StaminaChargingTime - now).TotalSeconds;
			if (chargeRemain <= 0)
			{
				AuctionStaminaProperty.Value = Math.Min(AuctionStaminaProperty.Value + 1, MaxStamina);
				auctionData.StaminaChargingTime = now.AddSeconds(auction_house_stamina_countup_cooltime);
				chargeRemain = auction_house_stamina_countup_cooltime;
			}
			ChargeStaminaRemainTime.Value = Math.Max(0, chargeRemain);
		}
		else
		{
			ChargeStaminaRemainTime.Value = 0;
		}

		if (auctionData.FreeStaminaTime > DateTime.MinValue)
		{
			int freeRemain = (int)(auctionData.FreeStaminaTime - now).TotalSeconds;
			FreeStaminaRemainTime.Value = Math.Max(0, freeRemain);
		}

		if (auctionData.AdStaminaTime > DateTime.MinValue)
		{
			int adRemain = (int)(auctionData.AdStaminaTime - now).TotalSeconds;
			AdStaminaRemainTime.Value = Math.Max(0, adRemain);
		}

		UpdatePremiumBonusRewardRemainTime();
	}

	public void SetNewEvent()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}
		auctionData.AuctionScore = 0;
		auctionData.AuctionPassActive = false;
		auctionData.PassPremiumBonusReceived = false;
		if (auctionData.ReceivePassReward != null)
		{
			auctionData.ReceivePassReward.Clear();
		}
		if (auctionData.ReceivePremiumPassReward != null)
		{
			auctionData.ReceivePremiumPassReward.Clear();
		}
		if (auctionData.Enemys != null)
		{
			auctionData.Enemys.Clear();
		}
		AuctionStaminaProperty.Value = auction_house_start_stamina_count;
		auctionData.Stamina = auction_house_start_stamina_count;
		SetAuctionLevel();
	}

	public void EndEvent()
	{
		CurEventIdx = 0;
	}

	private void SetEventIdx(int eventIdx)
	{
		CurEventIdx = eventIdx;
	}

	private void UpdatePremiumBonusRewardRemainTime()
	{
		if (PremiumBonusRewardEndTime <= DateTime.MinValue)
		{
			PremiumBonusRewardRemainTime.Value = 0;
			return;
		}
		DateTime now = DateTime.UtcNow;
		int remain = (int)(PremiumBonusRewardEndTime - now).TotalSeconds;
		PremiumBonusRewardRemainTime.Value = Math.Max(0, remain);
	}

	private void InitDefine()
	{
		if (IsInitDefine)
		{
			return;
		}
		IsInitDefine = true;

		auction_house_stamina_max_count = 5;
		auction_house_stamina_countup_cooltime = 600;
		auction_house_stamina_max_add_count = 5;
		auction_house_start_stamina_count = 3;
		auction_house_spy_gem_count_1 = 50;
		auction_house_random_coin_max_count = 100;
		auction_house_random_coin_min_count = 10;
		auction_house_random_use_coin = 10;
		auction_house_win_point = 100;
		auction_house_min_use_coin = 1;
		AUCTION_2X_POINT_TRIAL_LIMIT_VALUE = 3;
		PREMIUM_PURCHASE_REWARD_POINT = 500;
		PREMIUM_BONUS_REWARD_EXCHANGE_RATE = 10;
		PREMIUM_BONUS_REWARD_MAX_GEM_VALUE = 1000;
		PREMIUM_BONUS_REWARD_START_POINT = 100;
		PREMIUM_BONUS_REWARD_LIMIT_TIME_SEC = 86400;
	}

	public void GetShopStamina(int reward)
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}
		int newStamina = Math.Min(AuctionStaminaProperty.Value + reward, MaxStamina);
		AuctionStaminaProperty.Value = newStamina;
		auctionData.Stamina = newStamina;
	}

	private int GetUserAuctionTier()
	{
		return AuctionTier;
	}

	public void SetAuctionLevel()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}
		AuctionLevel = auctionData.Level;
		AuctionTier = auctionData.Tier;
	}

	public void AddApplyCoin(int round)
	{
		if (AuctionOrganizeCoin == null)
		{
			return;
		}
		if (AuctionOrganizeCoin.ContainsKey(round))
		{
			AuctionOrganizeCoin[round] = AuctionOrganizeCoin[round] + 1;
		}
		else
		{
			AuctionOrganizeCoin[round] = 1;
		}
	}

	public void DelApplyCoin(int round)
	{
		if (AuctionOrganizeCoin == null)
		{
			return;
		}
		if (AuctionOrganizeCoin.ContainsKey(round))
		{
			int val = AuctionOrganizeCoin[round] - 1;
			if (val <= 0)
			{
				AuctionOrganizeCoin[round] = 0;
			}
			else
			{
				AuctionOrganizeCoin[round] = val;
			}
		}
	}

	public void SetApplyCoin(int round, int setCoin)
	{
		if (AuctionOrganizeCoin == null)
		{
			return;
		}
		AuctionOrganizeCoin[round] = setCoin;
	}

	public int GetApplyCoin(int round)
	{
		if (AuctionOrganizeCoin == null)
		{
			return 0;
		}
		int coin;
		if (AuctionOrganizeCoin.TryGetValue(round, out coin))
		{
			return coin;
		}
		return 0;
	}

	public void AutoAuction()
	{
		if (AuctionOrganizeCoin == null)
		{
			return;
		}
		int remainCoin = GetRemainCoin();
		if (remainCoin <= 0)
		{
			return;
		}
		int roundCount = AuctionOrganizeCoin.Count;
		if (roundCount <= 0)
		{
			return;
		}
		int coinPerRound = remainCoin / roundCount;
		int extraCoin = remainCoin % roundCount;
		int idx = 0;
		foreach (var round in new List<int>(AuctionOrganizeCoin.Keys))
		{
			int addCoin = coinPerRound + (idx < extraCoin ? 1 : 0);
			AuctionOrganizeCoin[round] = AuctionOrganizeCoin[round] + addCoin;
			idx++;
		}
	}

	public int GetRemainCoin()
	{
		int totalUsed = 0;
		if (AuctionOrganizeCoin != null)
		{
			foreach (var kvp in AuctionOrganizeCoin)
			{
				totalUsed += kvp.Value;
			}
		}
		return EnableUseCoin - totalUsed;
	}

	public void SetOrganizeCoin(int round, int coin)
	{
		if (AuctionOrganizeCoin == null)
		{
			return;
		}
		AuctionOrganizeCoin[round] = coin;
	}

	public void UseStamina()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}
		int newStamina = Math.Max(0, AuctionStaminaProperty.Value - 1);
		AuctionStaminaProperty.Value = newStamina;
		auctionData.Stamina = newStamina;

		if (newStamina < MaxStamina && auctionData.StaminaChargingTime <= DateTime.MinValue)
		{
			auctionData.StaminaChargingTime = DateTime.UtcNow.AddSeconds(auction_house_stamina_countup_cooltime);
		}
	}

	public void StartAuction()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}

		AuctionOrganizeCoin.Clear();
		AuctionOrganizeManager.Clear();
		AuctionOrganizeResult.Clear();

		EnableUseCoin = auctionData.UseCoin;
		if (EnableUseCoin <= 0)
		{
			EnableUseCoin = UnityEngine.Random.Range(auction_house_random_coin_min_count, auction_house_random_coin_max_count + 1);
		}
	}

	public void SetAuctionRoundResult(int round, E_AuctionResult result, int usespy)
	{
		if (AuctionOrganizeResult == null)
		{
			AuctionOrganizeResult = new Dictionary<int, int>();
		}
		AuctionOrganizeResult[round] = (int)result;
	}

	public int GetWinCount()
	{
		int count = 0;
		if (AuctionOrganizeResult != null)
		{
			foreach (var kvp in AuctionOrganizeResult)
			{
				if (kvp.Value == (int)E_AuctionResult.Win)
				{
					count++;
				}
			}
		}
		return count;
	}

	public int GetLoseCount()
	{
		int count = 0;
		if (AuctionOrganizeResult != null)
		{
			foreach (var kvp in AuctionOrganizeResult)
			{
				if (kvp.Value == (int)E_AuctionResult.Lose)
				{
					count++;
				}
			}
		}
		return count;
	}

	public bool IsInAuction()
	{
		return AuctionOrganizeResult != null && AuctionOrganizeResult.Count > 0;
	}

	public bool NeedReceivePremiumBonus()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return false;
		}
		if (!auctionData.AuctionPassActive)
		{
			return false;
		}
		if (auctionData.PassPremiumBonusReceived)
		{
			return false;
		}
		if (auctionData.AuctionScore < PREMIUM_BONUS_REWARD_START_POINT)
		{
			return false;
		}
		if (PremiumBonusRewardRemainTime != null && PremiumBonusRewardRemainTime.Value > 0)
		{
			return true;
		}
		return true;
	}

	public void ReceivePremiumBonus()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}
		auctionData.PassPremiumBonusReceived = true;
		PremiumBonusRewardEndTime = DateTime.MinValue;
		PremiumBonusRewardRemainTime.Value = 0;
	}

	public void EndAuction()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}

		int winCount = GetWinCount();
		int score = winCount * auction_house_win_point;
		auctionData.AuctionScore += score;

		AuctionOrganizeCoin.Clear();
		AuctionOrganizeManager.Clear();
		AuctionOrganizeResult.Clear();
	}

	public void SetActiveAuctionPass()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}
		auctionData.AuctionPassActive = true;
		PremiumBonusRewardEndTime = DateTime.UtcNow.AddSeconds(PREMIUM_BONUS_REWARD_LIMIT_TIME_SEC);
	}

	public void OrganizeManager(int round, int manager)
	{
		if (AuctionOrganizeManager == null)
		{
			return;
		}
		AuctionOrganizeManager[round] = manager;
	}

	public bool isOrganizeManager(int round)
	{
		if (AuctionOrganizeManager == null)
		{
			return false;
		}
		return AuctionOrganizeManager.ContainsKey(round) && AuctionOrganizeManager[round] > 0;
	}

	public void SetEnemyIdx()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}
		AuctionNpcIdx = auctionData.EnemyIdx;
	}

	public void GetPreviewEnemy()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return;
		}
		if (auctionData.Enemys != null && auctionData.Enemys.Count > 0)
		{
			int randomIdx = UnityEngine.Random.Range(0, auctionData.Enemys.Count);
			AuctionNpcIdx = auctionData.Enemys[randomIdx];
			auctionData.EnemyIdx = AuctionNpcIdx;
		}
	}

	public void UpdateOneSeconds()
	{
		UpdateTime();
	}

	public int GetPremiumBonusGemValue()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return 0;
		}
		int score = auctionData.AuctionScore;
		if (score < PREMIUM_BONUS_REWARD_START_POINT)
		{
			return 0;
		}
		int gemValue = score / PREMIUM_BONUS_REWARD_EXCHANGE_RATE;
		return Math.Min(gemValue, PREMIUM_BONUS_REWARD_MAX_GEM_VALUE);
	}

	public bool IsActive2xPoint()
	{
		return IsActive2xPointTrial;
	}

	public bool IsNowEnd2xTrial()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			return false;
		}
		return IsActive2xPointTrial && auctionData.AuctionScore >= AUCTION_2X_POINT_TRIAL_LIMIT_VALUE;
	}

	private void UpdateIsActive2xPointTrial()
	{
		AuctionData auctionData = GameRoot.Instance.UserData.AuctionData;
		if (auctionData == null)
		{
			IsActive2xPointTrial = false;
			return;
		}
		IsActive2xPointTrial = auctionData.AuctionPassActive && auctionData.AuctionScore < AUCTION_2X_POINT_TRIAL_LIMIT_VALUE;
	}
}
