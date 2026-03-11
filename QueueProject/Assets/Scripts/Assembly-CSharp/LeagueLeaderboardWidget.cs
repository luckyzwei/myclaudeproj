using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using KWGameCore;
using KWHaptics.Haptics;
using UnityEngine;
using UnityEngine.UI;

public class LeagueLeaderboardWidget : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public bool explosionFinished;

		internal void _003CPlayerCellSearchingItsPLaceInTheWorld_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCreateCells_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LeagueLeaderboardWidget _003C_003E4__this;

		public int newPlayerRank;

		public int playerRank;

		public int playerScore;

		public int newPlayerScore;

		private bool _003CrankChanged_003E5__2;

		private int _003CnumberOfCells_003E5__3;

		private int _003CfirstRank_003E5__4;

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
		public _003CCreateCells_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CPlayerCellSearchingItsPLaceInTheWorld_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LeagueLeaderboardWidget _003C_003E4__this;

		public int newPlayerRank;

		public int playerRank;

		public int playerScore;

		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		public int newPlayerScore;

		private int _003CtotalPlayers_003E5__2;

		private Vector3 _003Cdirection_003E5__3;

		private Rect _003CcontainerRect_003E5__4;

		private float _003CtotalDistanceToMove_003E5__5;

		private float _003CtotalTime_003E5__6;

		private float _003Ctimer_003E5__7;

		private float _003CmicroOffsetEnd_003E5__8;

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
		public _003CPlayerCellSearchingItsPLaceInTheWorld_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CUpdateLeagueTimer_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LeagueLeaderboardWidget _003C_003E4__this;

		private long _003CtimeRemaining_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CUpdateLeagueTimer_003Ed__43(int _003C_003E1__state)
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

	private const int TOP_3 = 3;

	[Header("HEADER")]
	[SerializeField]
	private LeagueHeaderWidget m_header;

	[SerializeField]
	private Text m_timerText;

	[Header("TROPHYS")]
	[SerializeField]
	private LeagueTrophy m_trophyPrefab;

	[SerializeField]
	private Transform m_trophyLayout;

	[Header("LEADERBOARD PODIUM")]
	[SerializeField]
	private LeaguePodiumWidget m_podium;

	[Header("LEADERBOARD GENERAL")]
	[SerializeField]
	private LeaderboardCell m_cellPrefab;

	[SerializeField]
	private RectTransform m_cellsContainer;

	[SerializeField]
	private ScrollRect m_scroll;

	[SerializeField]
	private Transform m_floatingPlayerCellParent;

	[SerializeField]
	private KWEase.Type m_easeType;

	[SerializeField]
	private float m_cellTransitionDelay;

	[SerializeField]
	private float m_bubbleDelaySeconds;

	[Header("Analytics")]
	[SerializeField]
	private string m_leaderboardLocation;

	[Header("Time Formats")]
	[SerializeField]
	private string m_standardTimeFormat;

	[SerializeField]
	private string m_24hTimeFormat;

	[SerializeField]
	private string m_1hTimeFormat;

	private LeaderboardCell m_floatingPlayerCell;

	private LeaderboardCell m_playerCell;

	private List<LeaderboardCell> m_cells;

	private bool m_firstConfig;

	private VerticalLayoutGroup m_layoutGroup;

	private ContentSizeFitter m_contentSizeFitter;

	private bool m_forceConfiguration;

	private StringBuilder m_timeStringBuilder;

	private HapticsTickerComponent m_hapticsTickerComponent;

	private bool m_excludeTop3;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LeagueEndedActions()
	{
	}

	private void OnEnable()
	{
	}

	private void Configure()
	{
	}

	private void ReCenterOnPlayer()
	{
	}

	private void ConfigureScroll(int playerRank, int newPlayerRank, int playerScore, int newPlayerScore)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateCells_003Ed__34))]
	private IEnumerator CreateCells(int playerRank, int newPlayerRank, int playerScore, int newPlayerScore)
	{
		return null;
	}

	private float CalculateScrollPosition(int rank, int firstRank, int cellCount)
	{
		return 0f;
	}

	private float CellSpaceSize()
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CPlayerCellSearchingItsPLaceInTheWorld_003Ed__37))]
	private IEnumerator PlayerCellSearchingItsPLaceInTheWorld(int playerRank, int newPlayerRank, int playerScore, int newPlayerScore)
	{
		return null;
	}

	private void PlayBubble(int playerRank)
	{
	}

	private float GetNormalisedPosition(int rank, int numCells, int totalPlayers)
	{
		return 0f;
	}

	private LeaderboardCell FindCellOfRank(int rank)
	{
		return null;
	}

	private void SetupTrophyLayout()
	{
	}

	private void SetupCountdownTimer()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateLeagueTimer_003Ed__43))]
	private IEnumerator UpdateLeagueTimer()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
