using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RoyalTournamentLeaderboardCell : LeaderboardCell
{
	[CompilerGenerated]
	private sealed class _003CPlayPlayerCellIntro_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoyalTournamentLeaderboardCell _003C_003E4__this;

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
		public _003CPlayPlayerCellIntro_003Ed__14(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CTryToShow_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float completeTime;

		public RoyalTournamentLeaderboardCell _003C_003E4__this;

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
		public _003CTryToShow_003Ed__18(int _003C_003E1__state)
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

	private const string ANIM_ANIM_LEADERBOARDCELL_ELIMINATED = "Anim-LeaderboardCell-Eliminated";

	private const string ANIM_ANIM_LEADERBOARDCELL_PLAYERCELL_INTRO = "Anim-LeaderboardCell-PlayerCell-Intro";

	[Header("Royal Tournament")]
	[SerializeField]
	private GameObject[] m_hiddenStateObjects;

	[SerializeField]
	private GameObject[] m_showStateObjects;

	[SerializeField]
	private GameObject m_brokenHeart;

	[SerializeField]
	private GameObject m_editButton;

	private new bool m_isPlayer;

	public static Action AnimPlayerCell;

	private static float s_cellDelay;

	private void Awake()
	{
	}

	private new void OnDestroy()
	{
	}

	private void OnAnimPlayerCell()
	{
	}

	public override void Configure(int score, int rank, string username = null, string id = null, bool isPlayer = false, bool leagueConfig = true, int avatarIndex = -1, string avatarUrl = null)
	{
	}

	private void PlayPlayerIntro()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayPlayerCellIntro_003Ed__14))]
	private IEnumerator PlayPlayerCellIntro()
	{
		return null;
	}

	public override void PlayRankAnimations(int rank, Action onComplete = null)
	{
	}

	private void OnDisable()
	{
	}

	private void SetShowState(bool show)
	{
	}

	[IteratorStateMachine(typeof(_003CTryToShow_003Ed__18))]
	private IEnumerator TryToShow(float completeTime)
	{
		return null;
	}
}
