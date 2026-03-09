using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.SmartObjects;
using KWUserInterface;
using UnityEngine;
using UnityEngine.UI;

public class PVPResultScreen : KWUserInterface.Screen
{
	[CompilerGenerated]
	private sealed class _003CDoubleStarsFlow_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PVPResultScreen _003C_003E4__this;

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
		public _003CDoubleStarsFlow_003Ed__57(int _003C_003E1__state)
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
	private sealed class _003CRecoverAndRematchFlow_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PVPResultScreen _003C_003E4__this;

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
		public _003CRecoverAndRematchFlow_003Ed__59(int _003C_003E1__state)
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

	private const int TAPS_NEEDED_TO_SKIP = 2;

	private const float TAP_ALLOWED_TIME_IN_BETWEEN = 1f;

	private const float PULSE_AMOUNT = 0.3f;

	private const float PULSE_DURATION = 1f;

	private const float GLOW_SCALE_DURATION = 0.5f;

	private const float ALPHA_LERP_DURATION = 1f;

	private const string ANIM_ANIM_INTRO = "Anim-Intro";

	private const string ANIM_ANIM_BUTTONSCOMEIN = "Anim-ButtonsComeIn";

	private const string ANIM_LOSE_BY_HEART = "Lose-By-Heart";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[Space]
	[SerializeField]
	private RecordingPlayback m_playerPlayback;

	[SerializeField]
	private RecordingPlayback m_opponentPlayback;

	[SerializeField]
	private ScaledTimeTimer m_timer;

	[SerializeField]
	private GameObject[] m_winLayout;

	[SerializeField]
	private GameObject[] m_loseLayout;

	[Space]
	[SerializeField]
	private PvpRewardWidget m_winRewards;

	[SerializeField]
	private RewardWidget m_loseRewards;

	[Space]
	[SerializeField]
	private Button m_claimButton;

	[SerializeField]
	private Button m_loseStarsButton;

	[SerializeField]
	private Button m_doubleStarsButton;

	[SerializeField]
	private Button m_rematchButton;

	[Space]
	[SerializeField]
	private CanvasGroup m_canvasGroup;

	[SerializeField]
	private GameObject m_waitForOpponentToFinish;

	[SerializeField]
	private float m_winnerGridScale;

	[SerializeField]
	private float m_winnerGridAngle;

	[SerializeField]
	private float m_maxTimeWaitingForOpponent;

	[SerializeField]
	private GameObject m_playerGlow;

	[SerializeField]
	private GameObject m_opponentGlow;

	[SerializeField]
	private ScaledTimeTimer m_playerTimer;

	[SerializeField]
	private ScaledTimeTimer m_opponentTimer;

	[SerializeField]
	private Color m_winColor;

	[SerializeField]
	private Color m_loseColor;

	[SerializeField]
	private Transform m_playerAvatar;

	[SerializeField]
	private Transform m_opponentAvatar;

	[SerializeField]
	private GameObject m_playerCrown;

	[SerializeField]
	private GameObject m_opponentCrown;

	[SerializeField]
	private CanvasGroup m_opponentCanvasGroup;

	[SerializeField]
	private AnimatorHelper m_playerLoseByHeartsAnimator;

	[SerializeField]
	private AnimatorHelper m_opponentLoseByHeartsAnimator;

	private int m_stars;

	private int m_taps;

	private bool m_isPlaybackFinished;

	private float m_lastTapTime;

	private float m_startDelay;

	private bool m_playerWon;

	private bool m_firstPlaybackFinished;

	private bool m_resultsConfigured;

	private bool m_triedToStartPlayback;

	private void Awake()
	{
	}

	public void Config(LevelPlayRecording playerRecording, LevelPlayRecording opponentRecording)
	{
	}

	private void ConfigureResults(LevelPlayRecording playerRecording, LevelPlayRecording opponentRecording)
	{
	}

	private static int GetStarsAmount(Reward rewards)
	{
		return 0;
	}

	public void AnimEventStartPlayback()
	{
	}

	private void OnPlaybackFinish(bool opponent)
	{
	}

	private void OnClaimClick()
	{
	}

	private void OnLoseStarsClick()
	{
	}

	private void OnDoubleStarsClick()
	{
	}

	[IteratorStateMachine(typeof(_003CDoubleStarsFlow_003Ed__57))]
	private IEnumerator DoubleStarsFlow()
	{
		return null;
	}

	private void OnRecoverAndRematchClick()
	{
	}

	[IteratorStateMachine(typeof(_003CRecoverAndRematchFlow_003Ed__59))]
	private IEnumerator RecoverAndRematchFlow()
	{
		return null;
	}

	private void OnTapped()
	{
	}

	public void SkipRecordings()
	{
	}

	private void Update()
	{
	}

	public void RevealRewards_AnimEvent()
	{
	}

	private void ConfigureRewards(bool winning)
	{
	}
}
