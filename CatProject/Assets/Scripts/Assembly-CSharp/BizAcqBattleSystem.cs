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

	private Action<BattleCommand> _onCommandExecuted;

	private Action<List<BizAcqCharacterData>> _onDied;

	private Action _onUpdateRewardEvent;

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
		add { _onCommandExecuted += value; }
		[CompilerGenerated]
		remove { _onCommandExecuted -= value; }
	}

	public event Action<List<BizAcqCharacterData>> OnDied
	{
		[CompilerGenerated]
		add { _onDied += value; }
		[CompilerGenerated]
		remove { _onDied -= value; }
	}

	public event Action OnUpdateRewardEvent
	{
		[CompilerGenerated]
		add { _onUpdateRewardEvent += value; }
		[CompilerGenerated]
		remove { _onUpdateRewardEvent -= value; }
	}

	public void GiveUpBattle()
	{
		OnEndBattle(false);
	}

	public void OnEndDirectState(BattleDirectState battleState)
	{
		ProcessNextCommand();
	}

	private void ProcessBattle()
	{
		if (CommandQueue == null || CommandQueue.Count == 0) return;

		if (CheckBattleEnd()) return;

		UpdateTurnInfo();
		ProcessNextCommand();
	}

	private bool CheckBattleEnd()
	{
		if (PlayerTeam == null || EnemyTeam == null) return true;

		bool playerAllDead = PlayerTeam.IsAllDead();
		bool enemyAllDead = EnemyTeam.IsAllDead();

		if (playerAllDead)
		{
			EndBattle();
			return true;
		}
		if (enemyAllDead)
		{
			OnStageClear();
			return true;
		}
		return false;
	}

	private void ProcessNextCommand()
	{
		if (CommandQueue == null || CommandQueue.Count == 0)
		{
			ProcessBattle();
			return;
		}

		var command = CommandQueue.Dequeue();
		if (command != null)
		{
			ExecuteCommand(command);
		}
	}

	private void EndBattle()
	{
		bool isWin = EnemyTeam != null && EnemyTeam.IsAllDead();
		OnEndBattle(isWin);
	}

	private void OnEndBattle(bool isWin)
	{
		IsBizAcqMode = false;
		OnBattleEnd?.OnNext(isWin);
		ResetBattleInfo();
	}

	private void ResetBattleInfo()
	{
		PlayerTeam = null;
		EnemyTeam = null;
		if (CommandQueue != null) CommandQueue.Clear();
		LastPlayedCommand = null;
	}

	private void OnStageClear()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return;

		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData != null)
		{
			bizAcqData.LastClearStageIdx = GetStageIdx();
		}

		OnEndBattle(true);
	}

	private void UpdateTurnInfo()
	{
		CurTurnTeamType = (CurTurnTeamType == TeamType.Player) ? TeamType.Enemy : TeamType.Player;
	}

	private bool CheckSkillTrigger(BizAcqCharacterData caster, Config.ManagerSkillActivationType activationType)
	{
		if (caster == null) return false;
		if (caster.SkillData == null) return false;
		return false;
	}

	private void CheckAndTriggerSkill(BizAcqCharacterData caster, Config.ManagerSkillActivationType activationType)
	{
		if (!CheckSkillTrigger(caster, activationType)) return;
	}

	public int ApplyDamage(BizAcqCharacterData caster, BizAcqCharacterData target, int damage)
	{
		if (caster == null || target == null) return 0;
		if (damage <= 0) return 0;

		int actualDamage = Math.Max(1, damage);
		target.TakeDamage(actualDamage);

		return actualDamage;
	}

	public bool ExecuteCommand(BattleCommand command)
	{
		if (command == null) return false;

		LastPlayedCommand = command;
		_onCommandExecuted?.Invoke(command);

		return true;
	}

	public override void InitSystem()
	{
		BattleSpeedList = new List<int> { 1, 2, 3 };
		CurBattleSpeedIdx = 0;
		OnBattleStart = new Subject<bool>();
		OnBattleEnd = new Subject<bool>();
		OnClaimIdleRewardEvent = new Subject<bool>();
		CommandQueue = new Queue<BattleCommand>();

		BATTLE_HP_MULTIPLIER = 100;
		BATTLE_BOSS_HP_MULTIPLIER = 200;
		ACQUISITION_COMPANY_SELL_TIME = 30;
		ACQ_REWARD_MIN_TIME_SEC = 60;
		ACQ_REWARD_MAX_TIME_SEC = 28800;
		ACQ_REWARD_MAX_TIME_ADD_SEC = 3600;
		AUTO_PLAY_GUIDE_SHOW_TIME_SEC = 10;

		InitUserData();
	}

	private void InitUserData()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return;

		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData != null && bizAcqData.TeamData != null && bizAcqData.TeamData.TeamCeoIdxList != null)
		{
			PlayerTeam = MakePlayerTeamData(bizAcqData.TeamData.TeamCeoIdxList);
		}
	}

	public override void OnChangeScene()
	{
		ResetBattleInfo();
		IsBizAcqMode = false;
	}

	public void UpdateOneSecond()
	{
		if (!IsBizAcqMode) return;
		CheckBattleSpeedTrialEnd();
	}

	public void UpdateBattlePackageBuyOption()
	{
		UpdateBattleSpeedList();
	}

	public void SetActiveSpeedTrial()
	{
		IsActiveSpeedTrial = true;
	}

	private void CheckBattleSpeedTrialEnd()
	{
	}

	private void UpdateBattleSpeedList()
	{
		if (BattleSpeedList == null)
			BattleSpeedList = new List<int>();
		BattleSpeedList.Clear();
		BattleSpeedList.Add(1);
		BattleSpeedList.Add(2);
		if (IsBuyBattleSpeedSpecial || IsActiveSpeedTrial)
			BattleSpeedList.Add(3);
	}

	public void LoadSkillFxBundle()
	{
	}

	public void UnloadAllSkillFx()
	{
		SkillFxBundle = null;
	}

	public void UnloadSkillFxBundle()
	{
		SkillFxBundle = null;
	}

	public void LoadSkillFx(SkillEffectType skillEffectType, Action<GameObject> onLoaded)
	{
		if (SkillFxBundle != null)
		{
			// Would load specific skill fx from bundle
		}
		onLoaded?.Invoke(null);
	}

	public int GetMaxIdleRewardTimeSec()
	{
		return ACQ_REWARD_MAX_TIME_SEC + ACQ_REWARD_MAX_TIME_ADD_SEC;
	}

	public int GetCurIdleRewardTimeSec(DateTime curTime)
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return 0;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null) return 0;

		int elapsed = (int)(curTime - bizAcqData.LastRewardGetTime).TotalSeconds;
		int maxTime = GetMaxIdleRewardTimeSec();
		return Math.Min(Math.Max(0, elapsed), maxTime);
	}

	public int GetBattleSpeed()
	{
		if (BattleSpeedList == null || BattleSpeedList.Count == 0) return 1;
		if (CurBattleSpeedIdx < 0 || CurBattleSpeedIdx >= BattleSpeedList.Count) return 1;
		return BattleSpeedList[CurBattleSpeedIdx];
	}

	public int ChangeBattleSpeed()
	{
		if (BattleSpeedList == null || BattleSpeedList.Count == 0) return 1;
		CurBattleSpeedIdx = (CurBattleSpeedIdx + 1) % BattleSpeedList.Count;
		return BattleSpeedList[CurBattleSpeedIdx];
	}

	public void SetAutoPlayBattle(bool isAutoContinue)
	{
		IsAutoPlayBattle = isAutoContinue;
	}

	public bool IsNeedShowAutoPlayGuide()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return false;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null) return false;
		return bizAcqData.AutoPlayGuideShownTime <= DateTime.MinValue;
	}

	public void PlayBgm(E_BgmType bgmType)
	{
		CurBgmType = bgmType;
	}

	public void StopBgm()
	{
		CurBgmType = E_BgmType.None;
	}

	public BigInteger AddJewelryBoxValue(BigInteger value)
	{
		TempJewelryBoxGetValue += value;
		UpdateJewelryBoxData();
		return TempJewelryBoxGetValue;
	}

	private void UpdateJewelryBoxData()
	{
		_onUpdateRewardEvent?.Invoke();
	}

	public void UpdateAutoPlayGuideShownTime()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData != null)
			bizAcqData.AutoPlayGuideShownTime = DateTime.UtcNow;
	}

	public void UpdateLastClearStageIdx()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData != null)
		{
			// Would update to latest clear stage
		}
	}

	public void UpdateMultipleRewardInfo()
	{
	}

	public void OnClaimIdleReward(bool isReceiveAll)
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData != null)
		{
			bizAcqData.LastRewardGetTime = DateTime.UtcNow;
		}
		OnClaimIdleRewardEvent?.OnNext(isReceiveAll);
	}

	public void OnClaimMultipleReward()
	{
		OnClaimIdleReward(true);
	}

	public bool TryAddPlayerTeamCeo(int ceoIdx)
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return false;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null || bizAcqData.TeamData == null) return false;
		if (bizAcqData.TeamData.TeamCeoIdxList == null)
			bizAcqData.TeamData.TeamCeoIdxList = new List<int>();

		if (bizAcqData.TeamData.TeamCeoIdxList.Contains(ceoIdx)) return false;
		bizAcqData.TeamData.TeamCeoIdxList.Add(ceoIdx);
		UpdatePlayerTeamData();
		return true;
	}

	public bool TryRemovePlayerTeamCeo(int ceoIdx)
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return false;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null || bizAcqData.TeamData == null || bizAcqData.TeamData.TeamCeoIdxList == null) return false;

		bool removed = bizAcqData.TeamData.TeamCeoIdxList.Remove(ceoIdx);
		if (removed) UpdatePlayerTeamData();
		return removed;
	}

	public bool TryMakeBestPlayerTeam(List<int> originCeoIdList, bool bNeedOpenToast)
	{
		if (originCeoIdList == null || originCeoIdList.Count == 0) return false;
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return false;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null || bizAcqData.TeamData == null) return false;

		bizAcqData.TeamData.TeamCeoIdxList = new List<int>(originCeoIdList);
		UpdatePlayerTeamData();
		return true;
	}

	public void UpdatePlayerTeamData()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null || bizAcqData.TeamData == null || bizAcqData.TeamData.TeamCeoIdxList == null) return;

		PlayerTeam = MakePlayerTeamData(bizAcqData.TeamData.TeamCeoIdxList);
		SavePlayerTeamData();
	}

	private BizAcqTeamData MakePlayerTeamData(List<int> ceoIdxList)
	{
		if (ceoIdxList == null) return null;
		var characters = new List<BizAcqCharacterData>();

		for (int i = 0; i < ceoIdxList.Count; i++)
		{
			var character = MakePlayerCharacter(ceoIdxList[i], i);
			if (character != null)
				characters.Add(character);
		}
		return new BizAcqTeamData(TeamType.Player, characters);
	}

	private BizAcqTeamData MakeEnemyTeamData(int stageIdx)
	{
		var characters = new List<BizAcqCharacterData>();
		return new BizAcqTeamData(TeamType.Enemy, characters);
	}

	private BizAcqCharacterData MakePlayerCharacter(int ceoIdx, int teamIdx)
	{
		int power = 10;
		int maxHp = 100;
		int skillIdx = 0;
		int skillLevel = 1;
		return new BizAcqCharacterData(TeamType.Player, ceoIdx, teamIdx, power, maxHp, skillIdx, skillLevel);
	}

	private BizAcqCharacterData MakeEnemyCharacter(int ceoIdx, int stageIdx, int slotIndex)
	{
		int power = 10;
		int maxHp = 100;
		int skillIdx = 0;
		int skillLevel = 1;
		return new BizAcqCharacterData(TeamType.Enemy, ceoIdx, slotIndex, power, maxHp, skillIdx, skillLevel);
	}

	public void SavePlayerTeamData()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData != null)
			userData.Save();
	}

	public bool InitializeBattleInfo()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return false;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null) return false;

		int stageIdx = GetStageIdx();
		if (stageIdx <= 0) return false;

		if (PlayerTeam == null || PlayerTeam.Characters == null || PlayerTeam.Characters.Count == 0)
			return false;

		EnemyTeam = MakeEnemyTeamData(stageIdx);
		if (EnemyTeam == null) return false;

		if (CommandQueue == null)
			CommandQueue = new Queue<BattleCommand>();
		CommandQueue.Clear();

		CurTurnTeamType = TeamType.Player;
		TempJewelryBoxGetValue = BigInteger.Zero;

		return true;
	}

	public void StartBattle()
	{
		if (!InitializeBattleInfo()) return;

		IsBizAcqMode = true;
		OnBattleStart?.OnNext(true);
		ProcessBattle();
	}

	public int GetStageIdx()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return 0;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null) return 0;
		return bizAcqData.LastClearStageIdx + 1;
	}

	public int GetClearStageIdx()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return 0;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null) return 0;
		return bizAcqData.LastClearStageIdx;
	}

	public bool IsClearAllStage()
	{
		var userData = GameRoot.Instance?.UserData;
		if (userData == null) return false;
		var bizAcqData = userData.BizAcqUserData;
		if (bizAcqData == null) return false;
		return false;
	}

	public BizAcqTeamData GetTeam(TeamType teamType)
	{
		if (teamType == TeamType.Player) return PlayerTeam;
		if (teamType == TeamType.Enemy) return EnemyTeam;
		return null;
	}

	public int GetManagerDealPower(int ceoIdx)
	{
		var root = GameRoot.Instance;
		if (root == null || root.ManagerCardSystem == null) return 0;
		var managerData = root.ManagerCardSystem.GetManagerData(ceoIdx);
		if (managerData == null) return 0;
		return managerData.ManagerLevel != null ? managerData.ManagerLevel.Value : 0;
	}

	private BizAcqTeamData GetCurrentAttackerTeam()
	{
		return CurTurnTeamType == TeamType.Player ? PlayerTeam : EnemyTeam;
	}

	private BizAcqTeamData GetCurrentDefenderTeam()
	{
		return CurTurnTeamType == TeamType.Player ? EnemyTeam : PlayerTeam;
	}

	public BigInteger CalculateReinforceStoneTimeReward(int totalTimeSec)
	{
		if (totalTimeSec <= 0) return BigInteger.Zero;
		int clampedTime = Math.Min(totalTimeSec, GetMaxIdleRewardTimeSec());
		BigInteger reward = new BigInteger(clampedTime / 60);
		return reward;
	}

	public BigInteger CalculateReinforceStoneTimeReward_Per(float totalTimeSec)
	{
		return CalculateReinforceStoneTimeReward((int)totalTimeSec);
	}

	public BigInteger CalculateMoneyReward_Per(int acqStageIdx, int moneyRegion, float totalTimeSec)
	{
		if (totalTimeSec <= 0) return BigInteger.Zero;
		BigInteger onceReward = CalculateOnceMoneyReward(acqStageIdx, moneyRegion);
		int ticks = (int)(totalTimeSec / 60f);
		return onceReward * Math.Max(1, ticks);
	}

	public BigInteger CalculateOnceMoneyReward(int acqStageIdx, int moneyRegion)
	{
		BigInteger baseValue = CalculateValueOfOneBusiness(moneyRegion);
		BigInteger stageMultiplier = new BigInteger(1 + acqStageIdx);
		return baseValue * stageMultiplier;
	}

	public BigInteger CalculateValueOfOneBusiness(int moneyRegion)
	{
		BigInteger baseValue = new BigInteger(100);
		BigInteger regionMultiplier = new BigInteger(1 + moneyRegion);
		return baseValue * regionMultiplier;
	}
}
