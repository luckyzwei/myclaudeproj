using System.Collections.Generic;
using SeasonalDef;

public class SeasonalInfoData
{
	public int SeasonInfoIdx;
	public int SeasonThemeIdx;
	public string SeasonName;
	public string SeasonIcon;
	public int OfflineRewardMinTimeSec;
	public int OfflineRewardMaxTimeSec;
	public int OfflineRewardCorrectionValue;
	public int BonusMoneyCorrectionValue;
	public int BonusManagerExpCorrectionValue;
	public int PrevSeasonRewardsGetLimitTimeSec;
	public int OfflineRewardAdMultiple;
	public int OvertimeGemCost;
	public int NightSkipEndHour;
	public int BadMoodDebuffValue;
	public int MaxBuildingProgressCnt;
	public int AdditionalBuildingProgressCnt;
	public int DistributorCarryingCapacityInventoryDifference;
	public int RemainRewardsGetTimeLimit;
	public int ArcadeRouletteNeedCoin;
	public int FinalArcadeRouletteNeedCoin;
	public bool CoinRankCustomSeason;
	public int CoinRankCoolTime;
	public int CoinRankAccumulateCnt;
	public int CoinRankRetryRankLimit;
	public int RankTypeStartValue;
	public List<int> MineRankPointMagnificationList;
	public List<int> DefaultCurrencyIdxList;
}
