using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageAcquisitionBattle", false, false)]
public class PageAcquisitionBattle : FullScreenUI
{
	[CompilerGenerated]
	private sealed class _003CStartAnimEndCheck_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageAcquisitionBattle _003C_003E4__this;

		public Action onComplete;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStartAnimEndCheck_003Ed__32(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private GameObject BattleStartAnimObj;

	[SerializeField]
	private Text StageIdxText;

	[SerializeField]
	private ItemAcquisitionBattleTeam PlayerTeam;

	[SerializeField]
	private ItemAcquisitionBattleTeam EnemyTeam;

	[SerializeField]
	private Button GiveUpButton;

	[SerializeField]
	private Button BattleSpeedButton;

	[SerializeField]
	private Text BattleSpeedText;

	private Animator BattleStartAnimator;

	private bool IsAllowHide;

	private ActionQueue ActionQueue;

	private CompositeDisposable Disposables;

	protected override void Awake()
	{
		base.Awake();
		Disposables = new CompositeDisposable();
		ActionQueue = new ActionQueue();
		IsAllowHide = false;

		if (GiveUpButton != null) GiveUpButton.onClick.AddListener(OnGiveUpButtonClick);
		if (BattleSpeedButton != null) BattleSpeedButton.onClick.AddListener(OnBattleSpeedButtonClick);
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public override void OnShowBefore()
	{
		IsAllowHide = false;
		SetBattleInfo();
		SetBattleBgm();
		SetBattleSpeed();
		PlayBattleStartQueue();
	}

	public override void OnHideBefore()
	{
		Reset();
	}

	public override void Hide()
	{
		if (!IsAllowHide) return;
		base.Hide();
	}

	private void SetBattleInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
		var battleSystem = root.BizAcqBattleSystem;

		// Set stage index text
		if (StageIdxText != null)
			StageIdxText.text = battleSystem.GetStageIdx().ToString();

		// Set team data
		var playerData = battleSystem.GetTeam(BizAcqDef.TeamType.Player);
		var enemyData = battleSystem.GetTeam(BizAcqDef.TeamType.Enemy);
		if (PlayerTeam != null && playerData != null)
			PlayerTeam.Set(playerData);
		if (EnemyTeam != null && enemyData != null)
			EnemyTeam.Set(enemyData);
	}

	private void StartBattle()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.BizAcqBattleSystem == null) return;
		root.BizAcqBattleSystem.StartBattle();
	}

	private void SetBattleBgm()
	{
		// Set battle background music
	}

	private void SetBattleSpeed()
	{
		int speed = 1;
		SetBattleSpeedText(speed);
		if (PlayerTeam != null) PlayerTeam.SetPlaySpeed(speed);
		if (EnemyTeam != null) EnemyTeam.SetPlaySpeed(speed);
	}

	private void OnCommandExecuted(BattleCommand command)
	{
		if (command == null) return;
		if (command is AttackCommand || command is AdditionalAttackCommand)
			OnAttacked(command);
		else
			OnSkillExecuted(command);
	}

	private void OnSkillExecuted(BattleCommand command)
	{
		if (command == null || command.Caster == null) return;
		var team = command.Caster.TeamType == BizAcqDef.TeamType.Player ? PlayerTeam : EnemyTeam;
		if (team != null && command.Caster.SkillData != null)
			team.PlaySkillAnimation(command.Caster.SkillData.SkillIdx, command.Caster.SkillData.SkillLevel, null);
	}

	private void OnAttacked(BattleCommand command)
	{
		if (command == null || command.Caster == null) return;
		bool isPlayer = command.Caster.TeamType == BizAcqDef.TeamType.Player;
		var attackerTeam = isPlayer ? PlayerTeam : EnemyTeam;
		var defenderTeam = isPlayer ? EnemyTeam : PlayerTeam;

		if (!command.IsHit)
		{
			if (defenderTeam != null) defenderTeam.PlayEvadeAnimation(null);
			return;
		}

		bool isKill = command.Targets != null && command.Targets.Count > 0 && command.Targets[0].IsDead();
		if (attackerTeam != null) attackerTeam.PlayAttackAnimation(isKill, null);
		if (defenderTeam != null) defenderTeam.PlayDamageAnimation(command.DamageValue, null);
	}

	private void OnDied(List<BizAcqCharacterData> diedCharacters)
	{
		if (diedCharacters == null) return;
		for (int i = 0; i < diedCharacters.Count; i++)
		{
			if (diedCharacters[i] == null) continue;
			var team = diedCharacters[i].TeamType == BizAcqDef.TeamType.Player ? PlayerTeam : EnemyTeam;
			if (team != null) team.PlayDeadAnimation(null);
		}
	}

	private void OnBattleEnd(bool isWin)
	{
		IsAllowHide = true;
		// Show result popup
	}

	private void SetContinueBattle(bool isContinue)
	{
		if (isContinue)
		{
			SetBattleInfo();
			StartBattle();
		}
		else
		{
			IsAllowHide = true;
			Hide();
		}
	}

	private void OnClickedFailurePopupButton(PopupAcquisitionFailure popup, PopupAcquisitionFailure.ButtonType buttonType)
	{
		switch (buttonType)
		{
			case PopupAcquisitionFailure.ButtonType.Confirm:
				IsAllowHide = true;
				Hide();
				break;
			case PopupAcquisitionFailure.ButtonType.Retry:
				SetContinueBattle(true);
				break;
			case PopupAcquisitionFailure.ButtonType.Shortcut_Shop:
			case PopupAcquisitionFailure.ButtonType.Shortcut_Reinforce:
			case PopupAcquisitionFailure.ButtonType.Shortcut_ManagerKey:
				IsAllowHide = true;
				Hide();
				break;
		}
		if (popup != null) popup.Hide();
	}

	private void SetBattleSpeedText(int speed)
	{
		if (BattleSpeedText != null)
			BattleSpeedText.text = "x" + speed;
	}

	private void OnGiveUpButtonClick()
	{
		OnBattleEnd(false);
	}

	private void OnBattleSpeedButtonClick()
	{
		// Cycle battle speed: 1x -> 2x -> 3x -> 1x
		int curSpeed = 1;
		if (BattleSpeedText != null)
		{
			string text = BattleSpeedText.text.Replace("x", "");
			int.TryParse(text, out curSpeed);
		}
		int nextSpeed = curSpeed >= 3 ? 1 : curSpeed + 1;
		SetBattleSpeedText(nextSpeed);
		if (PlayerTeam != null) PlayerTeam.SetPlaySpeed(nextSpeed);
		if (EnemyTeam != null) EnemyTeam.SetPlaySpeed(nextSpeed);
	}

	private void Reset()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	private void PlayBattleStartQueue()
	{
		// Play battle start animation, then start battle
		if (BattleStartAnimObj != null)
		{
			BattleStartAnimObj.SetActive(true);
			BattleStartAnimator = BattleStartAnimObj.GetComponent<Animator>();
		}
		StartCoroutine(StartAnimEndCheck(() =>
		{
			CheckAndPlayBattleSpeedTutorial(() =>
			{
				StartBattle();
			});
		}));
	}

	[IteratorStateMachine(typeof(_003CStartAnimEndCheck_003Ed__32))]
	private IEnumerator StartAnimEndCheck(Action onComplete)
	{
		if (BattleStartAnimator != null)
		{
			yield return null; // Wait one frame for animation to start
			while (BattleStartAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f)
				yield return null;
		}
		else
		{
			yield return new WaitForSeconds(1f);
		}
		if (BattleStartAnimObj != null) BattleStartAnimObj.SetActive(false);
		onComplete?.Invoke();
	}

	private void CheckAndPlayBattleSpeedTutorial(Action onComplete)
	{
		// Check if battle speed tutorial should play
		onComplete?.Invoke();
	}

	private void CheckAndPlaySpeedTrial(Action onComplete)
	{
		// Check if speed trial should play
		onComplete?.Invoke();
	}
}
