using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardCell : MonoBehaviour, IScrollItemRecyclable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CHandleBotProfile_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int avatarIndex;

		public LeaderboardCell _003C_003E4__this;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CLerpRankCoroutine_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public float lerpDuration;

		public int oldRank;

		public int newRank;

		public LeaderboardCell _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		private float _003CendTime_003E5__3;

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
		public _003CLerpRankCoroutine_003Ed__65(int _003C_003E1__state)
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
	private sealed class _003CLerpScoreCoroutine_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public float lerpDuration;

		public int oldScore;

		public int newScore;

		public LeaderboardCell _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		private float _003CendTime_003E5__3;

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
		public _003CLerpScoreCoroutine_003Ed__64(int _003C_003E1__state)
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

	private const string PLAYER_NAME_DEFAULT_LOC = "Leaderboard.DefaultPlayerName";

	protected const string ANIM_LEADERBOARDCELL_DEFAULT = "LeaderboardCell-Default";

	protected const string ANIM_LEADERBOARDCELL_3RD = "LeaderboardCell-3rd";

	protected const string ANIM_LEADERBOARDCELL_2ND = "LeaderboardCell-2nd";

	protected const string ANIM_LEADERBOARDCELL_1ST = "LeaderboardCell-1st";

	protected const string ANIM_LEADERBOARDCELL_INTRO = "LeaderboardCell-Intro";

	protected const string ANIM_LEADERBOARDCELL_OUTRO = "LeaderboardCell-Outro";

	protected const string ANIM_EMPTY = "Empty";

	protected const string ANIM_LEADERBOARD_BLEND1ST = "Leaderboard-Blend1st";

	protected const string ANIM_LEADERBOARD_BLEND2ND = "Leaderboard-Blend2nd";

	protected const string ANIM_LEADERBOARD_BLEND3RD = "Leaderboard-Blend3rd";

	[SerializeField]
	private RectTransform m_rectTransform;

	[SerializeField]
	protected AnimatorHelper m_animator;

	[SerializeField]
	protected TMP_Text m_nameTMP;

	[SerializeField]
	protected TMP_Text m_cellScoreTMP;

	[SerializeField]
	protected NumberFormatter m_rank;

	[SerializeField]
	protected Image m_profileImage;

	[SerializeField]
	protected GameObject m_profileContainer;

	[SerializeField]
	protected GameObject[] m_playerCell;

	[SerializeField]
	protected GameObject[] m_goldGs;

	[SerializeField]
	protected GameObject[] m_silverGs;

	[SerializeField]
	protected GameObject[] m_bronzeGs;

	[SerializeField]
	protected GameObject m_coinContainer;

	[SerializeField]
	protected Sprite m_explosionSprite;

	[SerializeField]
	protected Transform m_explosionTarget;

	[Header("Only ofr leagues")]
	[SerializeField]
	private LeagueRewardWidget m_leagueReward;

	[Header("BUBBLE")]
	[SerializeField]
	private LeaguePromotionBubbleWidget m_bubblePrefab;

	[SerializeField]
	private Transform m_bubbleContainer;

	[Header("Recycler needs")]
	[SerializeField]
	private CanvasGroup m_canvasGroup;

	private LeaguePromotionBubbleWidget m_playerBubble;

	protected bool m_isPlayer;

	protected bool m_isBot;

	protected bool m_profileChangeRegistered;

	public int Rank => 0;

	public Vector3 StartLocalPos { get; set; }

	public int DataIndex { get; set; }

	public RectTransform GetRectTransform()
	{
		return null;
	}

	protected virtual void OnDestroy()
	{
	}

	public void UpdateProfilePicture(string avatarUrl)
	{
	}

	public virtual void PlayRankAnimations(int rank, Action onComplete = null)
	{
	}

	public virtual void PlayIntro(Action onComplete = null)
	{
	}

	public virtual void PlayBlendAnimation(int rank, Action onComplete = null)
	{
	}

	public virtual void Configure(BotScore botScore, int rank, bool leagueConfig = true)
	{
	}

	public virtual void Configure(LeaderboardData.User user, bool isPlayer, bool leagueConfig)
	{
	}

	public virtual void Configure(int score, int rank, string username = null, string id = null, bool isPlayer = false, bool leagueConfig = true, int avatarIndex = -1, string avatarUrl = null)
	{
	}

	private void PlayerProfileServiceOnOnProfileUpdated(PublicProfile obj)
	{
	}

	private void InitializeUIElements(int score, string username, string avatarUrl)
	{
	}

	private void DisableLeagueReward()
	{
	}

	[AsyncStateMachine(typeof(_003CHandleBotProfile_003Ed__55))]
	private void HandleBotProfile(int avatarIndex)
	{
	}

	private void HandlePlayerProfile()
	{
	}

	private void SetAvatarUrl(string avatarUrl)
	{
	}

	private void SetProfilePicture(Sprite sprite)
	{
	}

	private void InstantiatePlayerBubble()
	{
	}

	public void DoCurrencyExplosion(int number, Action callback = null)
	{
	}

	private void ConfigureLeagueReward()
	{
	}

	public void LerpScore(int oldScore, int newScore, float lerpDuration = 0.5f, float delay = 0f)
	{
	}

	public void LerpRank(int oldRank, int newRank, float lerpDuration = 0.5f, float delay = 0f)
	{
	}

	[IteratorStateMachine(typeof(_003CLerpScoreCoroutine_003Ed__64))]
	private IEnumerator LerpScoreCoroutine(int oldScore, int newScore, float lerpDuration, float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLerpRankCoroutine_003Ed__65))]
	private IEnumerator LerpRankCoroutine(int oldRank, int newRank, float lerpDuration, float delay)
	{
		return null;
	}

	public void UpdateScoreText(int score)
	{
	}

	public void PlayPromotionBubble(LeagueManager.LeagueResult result)
	{
	}

	public void SetCanvasGroupAlpha(float alpha)
	{
	}

	public void PrepareForRankChange()
	{
	}

	public void CleanupAfterRankChange()
	{
	}

	private void OnValidate()
	{
	}

	public void UpdateRank(long displayRank)
	{
	}
}
