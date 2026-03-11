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

	private static Action _ExpiryTimeUpdated;
	private static Action<int> _AddedScoreToWeeklyLeaderboard;

	public static string WeeklyLeaderboardId => TweakId(LEADERBOARD_ID_WEEKLY);

	public static string LegendsLeaderboardId => TweakId(LEADERBOARD_ID_LEGENDS);

	public static bool MigratedFromOldVersion { get; set; }

	public static bool Initialized { get; private set; }

	private bool IsRewardPendingToShow =>
		!string.IsNullOrEmpty(BucketWeeklyLeadeboard.PendingReward) &&
		BucketWeeklyLeadeboard.PendingReward != REWARD_ID_NONE;

	public static event Action ExpiryTimeUpdated
	{
		[CompilerGenerated]
		add { _ExpiryTimeUpdated += value; }
		[CompilerGenerated]
		remove { _ExpiryTimeUpdated -= value; }
	}

	public static event Action<int> AddedScoreToWeeklyLeaderboard
	{
		[CompilerGenerated]
		add { _AddedScoreToWeeklyLeaderboard += value; }
		[CompilerGenerated]
		remove { _AddedScoreToWeeklyLeaderboard -= value; }
	}

	protected override void Init()
	{
		Initialized = false;
		GameplayEvents.HomeScreenLoaded += GameplayEventsOnHomeScreenLoaded;
	}

	public void NakamaEventsOnNakamaConnected(NakamaSystemsInterface nakamaSystems)
	{
		InitialSetup();
	}

	private void InitialSetup()
	{
		Initialized = true;
		RetrieveLeaderboards();
		RetrieveCachedRank();
		TryStartWeeklyCoroutine();
	}

	private void RetrieveLeaderboards()
	{
		if (LeaderboardsService.Instance != null)
		{
			LeaderboardsService.OnLeaderboardUpdated += LeaderboardsServiceOnOnLeaderboardUpdated;
		}
	}

	public int GetScoreMultiplier()
	{
		// Default multiplier: 1x
		return 1;
	}

	private void GameplayEventsOnHomeScreenLoaded()
	{
		if (IsRewardPendingToShow)
			HandleRewardShared();
	}

	public static string TweakId(string leaderboardId)
	{
		string debugId = BucketWeeklyLeadeboard.DebugId;
		if (!string.IsNullOrEmpty(debugId))
			return leaderboardId + "_" + debugId;
		return leaderboardId;
	}

	private void LeaderboardsServiceOnOnLeaderboardUpdated(LeaderboardData leadeboard)
	{
		if (leadeboard == null) return;
		if (leadeboard.leaderboardId == WeeklyLeaderboardId)
		{
			if (leadeboard.currentPlayer != null)
			{
				BucketWeeklyLeadeboard.CacheRank = leadeboard.currentPlayer.position;
				BucketWeeklyLeadeboard.CacheScore = leadeboard.currentPlayer.score;
			}
		}
	}

	public void PostToWeeklyLeaderboard(int score, string context, bool applyMultiplier = true, bool onlyUpdateCache = false)
	{
		if (!Initialized) return;

		int finalScore = score;
		if (applyMultiplier)
			finalScore *= GetScoreMultiplier();

		if (onlyUpdateCache)
		{
			BucketWeeklyLeadeboard.CacheScore += finalScore;
			return;
		}

		if (LeaderboardsService.Instance != null)
		{
			var metadata = CreateLeaderboardMetadata();
			LeaderboardsService.Instance.PostPlayerScore(WeeklyLeaderboardId, finalScore, null, null, metadata);
		}

		_AddedScoreToWeeklyLeaderboard?.Invoke(finalScore);
	}

	private Dictionary<string, object> CreateLeaderboardMetadata()
	{
		var metadata = new Dictionary<string, object>();
		string previousReward = BucketWeeklyLeadeboard.PreviousWeekReward;
		if (!string.IsNullOrEmpty(previousReward))
			metadata[METADAKEY_PREVIOUS_REWARD] = previousReward;
		return metadata;
	}

	private void OnServerNotificationReceived(IApiNotification notification)
	{
		if (notification == null) return;
		if (notification.Code == CODE_PERSONAL_REWARD)
			HandlePersonalReward(notification);
	}

	private void HandlePersonalReward(IApiNotification notification)
	{
		if (notification == null || string.IsNullOrEmpty(notification.Content)) return;
		// Parse reward from notification content
		BucketWeeklyLeadeboard.PendingReward = notification.Content;
		BucketWeeklyLeadeboard.WaitingServerNotification = false;
	}

	private void HandleNoReward()
	{
		BucketWeeklyLeadeboard.PendingReward = REWARD_ID_NONE;
		BucketWeeklyLeadeboard.WaitingServerNotification = false;
	}

	private void HandleRewardShared()
	{
		string pendingReward = BucketWeeklyLeadeboard.PendingReward;
		if (string.IsNullOrEmpty(pendingReward) || pendingReward == REWARD_ID_NONE) return;

		// Store as previous reward and clear pending
		BucketWeeklyLeadeboard.PreviousWeekReward = pendingReward;
		BucketWeeklyLeadeboard.PendingReward = REWARD_ID_NONE;
	}

	private void NukeWeeklyCache()
	{
		if (LeaderboardsService.Instance != null)
			LeaderboardsService.Instance.DeleteCachedData(WeeklyLeaderboardId);
	}

	private void ResetLeaderboardsCache()
	{
		BucketWeeklyLeadeboard.CacheRank = 0;
		BucketWeeklyLeadeboard.CacheScore = 0;
		NukeWeeklyCache();
	}

	private void TryStartWeeklyCoroutine(bool force = false)
	{
		long expiryDate = BucketWeeklyLeadeboard.WeekExpiryDate;
		if (expiryDate <= 0) return;
		StartTimeCoroutine(expiryDate, ref m_weeklyExpiryCoroutine, WeekFinishedActions, "weekly", force);
	}

	private void TryStartDownTimeCoroutine(bool force = false)
	{
		long downDate = BucketWeeklyLeadeboard.DownPeriodDate;
		if (downDate <= 0) return;
		StartTimeCoroutine(downDate, ref m_downTimeCoroutine, DownTimeFinishedAction, "downtime", force);
	}

	private void StartTimeCoroutine(long expiryDate, ref Coroutine coroutine, Action callback, string context, bool force = false)
	{
		if (coroutine != null && !force) return;
		if (coroutine != null)
			KWCore.CoroutineRunner.Stop(coroutine);
		coroutine = KWCore.CoroutineRunner.Run(ExpireCoroutine(expiryDate, callback, context));
	}

	private int GetDownTimeSeconds()
	{
		return 300; // 5 minutes default downtime
	}

	private void WeekFinishedActions()
	{
		m_weeklyExpiryCoroutine = null;
		BucketWeeklyLeadeboard.WaitingServerNotification = true;

		// Start downtime period
		long downTimeEnd = NowUnixSeconds() + GetDownTimeSeconds();
		BucketWeeklyLeadeboard.DownPeriodDate = downTimeEnd;
		TryStartDownTimeCoroutine(true);

		ResetLeaderboardsCache();
	}

	private void DownTimeFinishedAction()
	{
		m_downTimeCoroutine = null;
		BucketWeeklyLeadeboard.DownPeriodDate = 0;

		// Retrieve new week's expiry
		RetrieveWeeklyExpireDate();
	}

	[IteratorStateMachine(typeof(_003CExpireCoroutine_003Ed__58))]
	private IEnumerator ExpireCoroutine(long expiryDate, Action callback, string context)
	{
		while (true)
		{
			long now = NowUnixSeconds();
			long remaining = expiryDate - EARLY_EXPIRY_BUFFER_SECONDS - now;
			if (remaining <= 0)
			{
				callback?.Invoke();
				yield break;
			}
			float waitTime = Mathf.Min(remaining, 60);
			yield return new WaitForSeconds(waitTime);
		}
	}

	public bool IsDownTimePeriod()
	{
		long downDate = BucketWeeklyLeadeboard.DownPeriodDate;
		if (downDate <= 0) return false;
		return NowUnixSeconds() < downDate;
	}

	public long GetDownTimeRemainingSeconds()
	{
		long downDate = BucketWeeklyLeadeboard.DownPeriodDate;
		if (downDate <= 0) return 0;
		long remaining = downDate - NowUnixSeconds();
		return remaining > 0 ? remaining : 0;
	}

	private void RetrieveCachedRank()
	{
		// Rank is already cached in BucketWeeklyLeadeboard.CacheRank
	}

	private long NowUnixSeconds()
	{
		return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

	public long GetWeekTimeRemainingInSeconds()
	{
		long expiryDate = BucketWeeklyLeadeboard.WeekExpiryDate;
		if (expiryDate <= 0) return 0;
		long remaining = expiryDate - NowUnixSeconds();
		return remaining > 0 ? remaining : 0;
	}

	[AsyncStateMachine(typeof(_003CRetrieveWeeklyExpireDate_003Ed__64))]
	private Task RetrieveWeeklyExpireDate(int retryCount = 0)
	{
		return Task.CompletedTask;
	}

	public void StartProcess(Action finishCallback)
	{
		if (IsRewardPendingToShow)
		{
			TryToShowEndOfWeekPopup(finishCallback);
		}
		else
		{
			finishCallback?.Invoke();
		}
	}

	public void TryToShowEndOfWeekPopup(Action finishCallback)
	{
		HandleRewardShared();
		finishCallback?.Invoke();
	}

	public int GetPriority()
	{
		return 40;
	}

	public int GetUnlockLocationMask()
	{
		return 1; // Home screen
	}
}
