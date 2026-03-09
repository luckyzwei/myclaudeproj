using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWUserInterface;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RoyalTournamentResultScreen : KWUserInterface.Screen
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public bool isInteristialRunning;

		internal void _003CWaitForPlayers_003Eb__0()
		{
		}

		internal bool _003CWaitForPlayers_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCheckForFakeOffline_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CCheckForFakeOffline_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CWaitForPlayers_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoyalTournamentResultScreen _003C_003E4__this;

		private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

		private int _003Cround_003E5__2;

		private int _003CcutpointTime_003E5__3;

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
		public _003CWaitForPlayers_003Ed__34(int _003C_003E1__state)
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

	private const float WAIT_TIME_INITIAL = 2f;

	private const float WAIT_TIME_BEFORE_NOTIFICATION = 0.5f;

	private const float WAIT_TIME_BEFORE_NEXT_ROUND = 5f;

	private const string ANIM_INTRO = "Intro";

	private const string ANIM_GRANDPRIZE_TRANSITION = "GrandPrize-Transition";

	private const string ANIM_ROYALTOURNAMENTRESULT_FINALROUND_WINNER = "RoyalTournamentResult-FinalRound-Winner";

	private const string ANIM_ROYALTOURNAMENTRESULT_FINALROUND_NOTWINNER = "RoyalTournamentResult-FinalRound-NotWinner";

	[Header("UI")]
	[SerializeField]
	private LeaderboardWidget m_leaderboardWidget;

	[SerializeField]
	private GameObject[] m_eliminatedObjects;

	[SerializeField]
	private GameObject[] m_qualifiedObjects;

	[SerializeField]
	private TextMeshProUGUI m_status;

	[SerializeField]
	private TextMeshProUGUI m_roundText;

	[SerializeField]
	private TextMeshProUGUI m_timeText;

	[SerializeField]
	private TextMeshProUGUI m_topText;

	[SerializeField]
	private TextMeshProUGUI m_winText;

	[SerializeField]
	private TextMeshProUGUI m_loseText;

	[SerializeField]
	private TextMeshProUGUI m_lastRoundloseText;

	[SerializeField]
	private Button m_continueButton;

	[SerializeField]
	private Button m_claimPrizeButton;

	[SerializeField]
	private GameObject m_winnerPanel;

	[SerializeField]
	private GameObject m_clasificationPanel;

	[SerializeField]
	private RewardWidget m_rewardWidget;

	[SerializeField]
	private ItemWithAmountCell m_starDisplayCell;

	[SerializeField]
	private ItemWithAmountCell m_eliminatedStarDisplayCell;

	private Coroutine m_populationRoutine;

	private AnimatorHelper m_animatorHelper;

	private static bool s_isFakeOffline;

	public static bool IsFakeOffline => false;

	public static void Show()
	{
	}

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckForFakeOffline_003Ed__31))]
	private IEnumerator CheckForFakeOffline()
	{
		return null;
	}

	private void Start()
	{
	}

	private void Configure()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForPlayers_003Ed__34))]
	private IEnumerator WaitForPlayers()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public void OnContinuePressed()
	{
	}

	public void OnClaimPrizePressed()
	{
	}

	public void Continue()
	{
	}

	public void ShowInterstitial(Action onFinished, bool onButtonPressed)
	{
	}

	public void AnimEventAnimatePlayerCell()
	{
	}
}
