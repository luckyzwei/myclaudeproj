using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardCellQueen : LeaderboardCell
{
	[Serializable]
	public class LegendsReward
	{
		public int gold;

		public int silver;

		public int bronze;
	}

	[CompilerGenerated]
	private sealed class _003CRevertAfterDelay_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LeaderboardCellQueen _003C_003E4__this;

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
		public _003CRevertAfterDelay_003Ed__19(int _003C_003E1__state)
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

	private const string ANIM_ANIM_LEADERBOARDCELL_INTRONEGATIVE = "Anim-LeaderboardCell-IntroNegative";

	private const string ANIM_ANIM_LEADERBOARDCELL_OUTRONEGATIVE = "Anim-LeaderboardCell-OutroNegative";

	[Header("Queens specific")]
	[SerializeField]
	private Image m_backgroundImage;

	[SerializeField]
	private Image m_badgeImage;

	[Header("Legens specific")]
	[SerializeField]
	private bool m_showOnlyLastBadge;

	[SerializeField]
	private LegendsBadge[] m_legendsBadges;

	[SerializeField]
	private float m_lostStarsRevertDelay;

	private LeaderboardData.User m_user;

	private Coroutine m_revertCoroutine;

	public override void Configure(BotScore botScore, int rank, bool leagueConfig = true)
	{
	}

	public override void Configure(int score, int rank, string username = null, string id = null, bool isPlayer = false, bool leagueConfig = true, int avatarIndex = -1, string avatarUrl = null)
	{
	}

	public override void Configure(LeaderboardData.User user, bool isPlayer, bool leagueConfig)
	{
	}

	private void OnProfileBgUpdated()
	{
	}

	private void OnEnable()
	{
	}

	private void SetProfileBackground(int index)
	{
	}

	private void SetBadge(DailyWinStreakMilestone milestone)
	{
	}

	private void SetProfileBackground(string clientId)
	{
	}

	private void OnDisable()
	{
	}

	private void CoreEvents_PopupClosed(PopUpBase popUpBase)
	{
	}

	[IteratorStateMachine(typeof(_003CRevertAfterDelay_003Ed__19))]
	private IEnumerator RevertAfterDelay()
	{
		return null;
	}

	private void SetupBadges(LeaderboardData.User user)
	{
	}

	public override void PlayIntro(Action onComplete = null)
	{
	}

	public override void PlayBlendAnimation(int rank, Action onComplete = null)
	{
	}
}
