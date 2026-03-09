using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using KWCore.Utils;
using Nakama;
using UnityEngine;

public class QueensLeaderboardManager : Singleton<QueensLeaderboardManager>, IQueueableEntity
{
	[Serializable]
	public class WeeklyRewardData
	{
		public int rank;

		public int lp;

		public int score;

		public string reward;
	}

	[CompilerGenerated]
	private sealed class _003CExpireCoroutine_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string context;

		public long expiryDate;

		public QueensLeaderboardManager _003C_003E4__this;

		public Action callback;

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
		public _003CExpireCoroutine_003Ed__58(int _003C_003E1__state)
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRetrieveWeeklyExpireDate_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public QueensLeaderboardManager _003C_003E4__this;

		public int retryCount;

		private string[] _003CweeklyLeaderboardIds_003E5__2;

		private long _003CstartRequestTime_003E5__3;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private TaskAwaiter<NakamaSystemsInterface.ExpiryResponse> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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

	public const string LEADERBOARD_ID_WEEKLY = "weekly";

	public const string LEADERBOARD_ID_LEGENDS = "legends";

	public const string LEADERBOARD_ID_STARS = "stars";

	public const string REWARD_ID_NONE = "none";

	public const string REWARD_ID_GOLDEN_TROPHY = "golden_trophy";

	public const string REWARD_ID_SILVER_TROPHY = "silver_trophy";

	public const string REWARD_ID_BRONZE_TROPHY = "bronze_trophy";

	public const string REWARD_ID_GOLDEN_RIBBON = "golden_ribbon";

	public const string REWARD_ID_SILVER_RIBBON = "silver_ribbon";

	public const string REWARD_ID_BRONZE_RIBBON = "bronze_ribbon";

	public const string METADAKEY_PREVIOUS_REWARD = "previous_reward";

	private const int CODE_PERSONAL_REWARD = 201;

	private const int EARLY_EXPIRY_BUFFER_SECONDS = 60;

	private const int EXPIRY_REQUEST_MAX_RETRIES = 3;

	public const string SCORE_TIMED_CURRENCY_ID = "score_multiplier_timer";

	private Coroutine m_weeklyExpiryCoroutine;

	private Coroutine m_downTimeCoroutine;

	public static string WeeklyLeaderboardId => null;

	public static string LegendsLeaderboardId => null;

	public static bool MigratedFromOldVersion { get; set; }

	public static bool Initialized { get; private set; }

	private bool IsRewardPendingToShow => false;

	public static event Action ExpiryTimeUpdated
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

	public static event Action<int> AddedScoreToWeeklyLeaderboard
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

	protected override void Init()
	{
	}

	public void NakamaEventsOnNakamaConnected(NakamaSystemsInterface nakamaSystems)
	{
	}

	private void InitialSetup()
	{
	}

	private void RetrieveLeaderboards()
	{
	}

	public int GetScoreMultiplier()
	{
		return 0;
	}

	private void GameplayEventsOnHomeScreenLoaded()
	{
	}

	public static string TweakId(string leaderboardId)
	{
		return null;
	}

	private void LeaderboardsServiceOnOnLeaderboardUpdated(LeaderboardData leadeboard)
	{
	}

	public void PostToWeeklyLeaderboard(int score, string context, bool applyMultiplier = true, bool onlyUpdateCache = false)
	{
	}

	private Dictionary<string, object> CreateLeaderboardMetadata()
	{
		return null;
	}

	private void OnServerNotificationReceived(IApiNotification notification)
	{
	}

	private void HandlePersonalReward(IApiNotification notification)
	{
	}

	private void HandleNoReward()
	{
	}

	private void HandleRewardShared()
	{
	}

	private void NukeWeeklyCache()
	{
	}

	private void ResetLeaderboardsCache()
	{
	}

	private void TryStartWeeklyCoroutine(bool force = false)
	{
	}

	private void TryStartDownTimeCoroutine(bool force = false)
	{
	}

	private void StartTimeCoroutine(long expiryDate, ref Coroutine coroutine, Action callback, string context, bool force = false)
	{
	}

	private int GetDownTimeSeconds()
	{
		return 0;
	}

	private void WeekFinishedActions()
	{
	}

	private void DownTimeFinishedAction()
	{
	}

	[IteratorStateMachine(typeof(_003CExpireCoroutine_003Ed__58))]
	private IEnumerator ExpireCoroutine(long expiryDate, Action callback, string context)
	{
		return null;
	}

	public bool IsDownTimePeriod()
	{
		return false;
	}

	public long GetDownTimeRemainingSeconds()
	{
		return 0L;
	}

	private void RetrieveCachedRank()
	{
	}

	private long NowUnixSeconds()
	{
		return 0L;
	}

	public long GetWeekTimeRemainingInSeconds()
	{
		return 0L;
	}

	[AsyncStateMachine(typeof(_003CRetrieveWeeklyExpireDate_003Ed__64))]
	private Task RetrieveWeeklyExpireDate(int retryCount = 0)
	{
		return null;
	}

	public void StartProcess(Action finishCallback)
	{
	}

	public void TryToShowEndOfWeekPopup(Action finishCallback)
	{
	}

	public int GetPriority()
	{
		return 0;
	}

	public int GetUnlockLocationMask()
	{
		return 0;
	}
}
