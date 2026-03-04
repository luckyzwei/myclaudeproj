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
	}

	private void OnDestroy()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	public override void Hide()
	{
	}

	private void SetBattleInfo()
	{
	}

	private void StartBattle()
	{
	}

	private void SetBattleBgm()
	{
	}

	private void SetBattleSpeed()
	{
	}

	private void OnCommandExecuted(BattleCommand command)
	{
	}

	private void OnSkillExecuted(BattleCommand command)
	{
	}

	private void OnAttacked(BattleCommand command)
	{
	}

	private void OnDied(List<BizAcqCharacterData> diedCharacters)
	{
	}

	private void OnBattleEnd(bool isWin)
	{
	}

	private void SetContinueBattle(bool isContinue)
	{
	}

	private void OnClickedFailurePopupButton(PopupAcquisitionFailure popup, PopupAcquisitionFailure.ButtonType buttonType)
	{
	}

	private void SetBattleSpeedText(int speed)
	{
	}

	private void OnGiveUpButtonClick()
	{
	}

	private void OnBattleSpeedButtonClick()
	{
	}

	private void Reset()
	{
	}

	private void PlayBattleStartQueue()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAnimEndCheck_003Ed__32))]
	private IEnumerator StartAnimEndCheck(Action onComplete)
	{
		yield break;
	}

	private void CheckAndPlayBattleSpeedTutorial(Action onComplete)
	{
	}

	private void CheckAndPlaySpeedTrial(Action onComplete)
	{
	}
}
