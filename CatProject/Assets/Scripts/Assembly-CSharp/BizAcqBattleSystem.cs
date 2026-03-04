using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using System.Runtime.CompilerServices;
using BizAcqDef;
using UniRx;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class BizAcqBattleSystem : SystemBase
{
	private int ACQ_REWARD_MAX_TIME_SEC;

	private int ACQ_REWARD_MAX_TIME_ADD_SEC;

	private BizAcqTeamData PlayerTeam;

	private BizAcqTeamData EnemyTeam;

	private TeamType CurTurnTeamType;

	private List<int> BattleSpeedList;

	private int CurBattleSpeedIdx;

	private bool IsBuyBattleSpeedSpecial;

	public bool IsIgnoreMoneyLimit;

	public BigInteger TempJewelryBoxGetValue;

	private AsyncOperationHandle<BizAcqSkillFxBundle> SkillFxBundleHandle;

	private Queue<BattleCommand> CommandQueue;

	public Subject<bool> OnBattleStart;

	public Subject<bool> OnBattleEnd;

	public Subject<bool> OnClaimIdleRewardEvent;

	public bool IsBizAcqMode;

	public int BATTLE_HP_MULTIPLIER { get; private set; }

	public int BATTLE_BOSS_HP_MULTIPLIER { get; private set; }

	public int ACQUISITION_COMPANY_SELL_TIME { get; private set; }

	public int ACQ_REWARD_MIN_TIME_SEC { get; private set; }

	public int AUTO_PLAY_GUIDE_SHOW_TIME_SEC { get; private set; }

	public bool IsAutoPlayBattle { get; private set; }

	public bool IsActiveSpeedTrial { get; private set; }

	public E_BgmType CurBgmType { get; private set; }

	public BizAcqSkillFxBundle SkillFxBundle { get; private set; }

	public BattleCommand LastPlayedCommand { get; private set; }

	public event Action<BattleCommand> OnCommandExecuted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<List<BizAcqCharacterData>> OnDied
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnUpdateRewardEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void GiveUpBattle()
	{
	}

	public void OnEndDirectState(BattleDirectState battleState)
	{
	}

	private void ProcessBattle()
	{
	}

	private bool CheckBattleEnd()
	{
		return false;
	}

	private void ProcessNextCommand()
	{
	}

	private void EndBattle()
	{
	}

	private void OnEndBattle(bool isWin)
	{
	}

	private void ResetBattleInfo()
	{
	}

	private void OnStageClear()
	{
	}

	private void UpdateTurnInfo()
	{
	}

	private bool CheckSkillTrigger(BizAcqCharacterData caster, Config.ManagerSkillActivationType activationType)
	{
		return false;
	}

	private void CheckAndTriggerSkill(BizAcqCharacterData caster, Config.ManagerSkillActivationType activationType)
	{
	}

	public int ApplyDamage(BizAcqCharacterData caster, BizAcqCharacterData target, int damage)
	{
		return 0;
	}

	public bool ExecuteCommand(BattleCommand command)
	{
		return false;
	}

	public override void InitSystem()
	{
		BattleSpeedList = new List<int>();
		OnBattleStart = new Subject<bool>();
		OnBattleEnd = new Subject<bool>();
		OnClaimIdleRewardEvent = new Subject<bool>();
	}

	private void InitUserData()
	{
	}

	public override void OnChangeScene()
	{
	}

	public void UpdateOneSecond()
	{
	}

	public void UpdateBattlePackageBuyOption()
	{
	}

	public void SetActiveSpeedTrial()
	{
	}

	private void CheckBattleSpeedTrialEnd()
	{
	}

	private void UpdateBattleSpeedList()
	{
	}

	public void LoadSkillFxBundle()
	{
	}

	public void UnloadAllSkillFx()
	{
	}

	public void UnloadSkillFxBundle()
	{
	}

	public void LoadSkillFx(SkillEffectType skillEffectType, Action<GameObject> onLoaded)
	{
	}

	public int GetMaxIdleRewardTimeSec()
	{
		return 0;
	}

	public int GetCurIdleRewardTimeSec(DateTime curTime)
	{
		return 0;
	}

	public int GetBattleSpeed()
	{
		return 0;
	}

	public int ChangeBattleSpeed()
	{
		return 0;
	}

	public void SetAutoPlayBattle(bool isAutoContinue)
	{
	}

	public bool IsNeedShowAutoPlayGuide()
	{
		return false;
	}

	public void PlayBgm(E_BgmType bgmType)
	{
	}

	public void StopBgm()
	{
	}

	public BigInteger AddJewelryBoxValue(BigInteger value)
	{
		return default(BigInteger);
	}

	private void UpdateJewelryBoxData()
	{
	}

	public void UpdateAutoPlayGuideShownTime()
	{
	}

	public void UpdateLastClearStageIdx()
	{
	}

	public void UpdateMultipleRewardInfo()
	{
	}

	public void OnClaimIdleReward(bool isReceiveAll)
	{
	}

	public void OnClaimMultipleReward()
	{
	}

	public bool TryAddPlayerTeamCeo(int ceoIdx)
	{
		return false;
	}

	public bool TryRemovePlayerTeamCeo(int ceoIdx)
	{
		return false;
	}

	public bool TryMakeBestPlayerTeam(List<int> originCeoIdList, bool bNeedOpenToast)
	{
		return false;
	}

	public void UpdatePlayerTeamData()
	{
	}

	private BizAcqTeamData MakePlayerTeamData(List<int> ceoIdxList)
	{
		return null;
	}

	private BizAcqTeamData MakeEnemyTeamData(int stageIdx)
	{
		return null;
	}

	private BizAcqCharacterData MakePlayerCharacter(int ceoIdx, int teamIdx)
	{
		return null;
	}

	private BizAcqCharacterData MakeEnemyCharacter(int ceoIdx, int stageIdx, int slotIndex)
	{
		return null;
	}

	public void SavePlayerTeamData()
	{
	}

	public bool InitializeBattleInfo()
	{
		return false;
	}

	public void StartBattle()
	{
	}

	public int GetStageIdx()
	{
		return 0;
	}

	public int GetClearStageIdx()
	{
		return 0;
	}

	public bool IsClearAllStage()
	{
		return false;
	}

	public BizAcqTeamData GetTeam(TeamType teamType)
	{
		return null;
	}

	public int GetManagerDealPower(int ceoIdx)
	{
		return 0;
	}

	private BizAcqTeamData GetCurrentAttackerTeam()
	{
		return null;
	}

	private BizAcqTeamData GetCurrentDefenderTeam()
	{
		return null;
	}

	public BigInteger CalculateReinforceStoneTimeReward(int totalTimeSec)
	{
		return default(BigInteger);
	}

	public BigInteger CalculateReinforceStoneTimeReward_Per(float totalTimeSec)
	{
		return default(BigInteger);
	}

	public BigInteger CalculateMoneyReward_Per(int acqStageIdx, int moneyRegion, float totalTimeSec)
	{
		return default(BigInteger);
	}

	public BigInteger CalculateOnceMoneyReward(int acqStageIdx, int moneyRegion)
	{
		return default(BigInteger);
	}

	public BigInteger CalculateValueOfOneBusiness(int moneyRegion)
	{
		return default(BigInteger);
	}
}
