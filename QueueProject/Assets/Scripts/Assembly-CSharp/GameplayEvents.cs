using System;
using Balancy.Models.LiveOps.Store;
using UnityEngine;

public class GameplayEvents
{
	public delegate void BasicDelegate();

	public delegate void IntDelegate(int integer);

	public delegate void StringDelegate(string text);

	public delegate void BoolDelegate(bool boolean);

	public delegate void FloatDelegate(float floatValue);

	public delegate void LongDelegate(long longInteger);

	public delegate void QueenFoundDelegate(int queenNumber, bool isLastOne, bool isBoosterUsed);

	public delegate void SpriteDelegate(Sprite sprite);

	public delegate void QueenTreasureMilestoneCompletedDelegate(int currentSlot, bool isLastOne);

	private static BasicDelegate _DummyEvent;
	public static event BasicDelegate DummyEvent
	{
		add { _DummyEvent += value; }
		remove { _DummyEvent -= value; }
	}

	private static QueenFoundDelegate _QueenFoundEvent;
	public static event QueenFoundDelegate QueenFoundEvent
	{
		add { _QueenFoundEvent += value; }
		remove { _QueenFoundEvent -= value; }
	}

	private static BoolDelegate _BoardInteractedEvent;
	public static event BoolDelegate BoardInteractedEvent
	{
		add { _BoardInteractedEvent += value; }
		remove { _BoardInteractedEvent -= value; }
	}

	private static IntDelegate _DailyChallengeMonthChanged;
	public static event IntDelegate DailyChallengeMonthChanged
	{
		add { _DailyChallengeMonthChanged += value; }
		remove { _DailyChallengeMonthChanged -= value; }
	}

	private static BasicDelegate _LevelSolved;
	public static event BasicDelegate LevelSolved
	{
		add { _LevelSolved += value; }
		remove { _LevelSolved -= value; }
	}

	private static BasicDelegate _LevelFailed;
	public static event BasicDelegate LevelFailed
	{
		add { _LevelFailed += value; }
		remove { _LevelFailed -= value; }
	}

	private static BasicDelegate _HoldCancelled;
	public static event BasicDelegate HoldCancelled
	{
		add { _HoldCancelled += value; }
		remove { _HoldCancelled -= value; }
	}

	private static BoolDelegate _PlayerLeaderboardMovementStarted;
	public static event BoolDelegate PlayerLeaderboardMovementStarted
	{
		add { _PlayerLeaderboardMovementStarted += value; }
		remove { _PlayerLeaderboardMovementStarted -= value; }
	}

	private static BasicDelegate _PlayerLeaderboardMovementDone;
	public static event BasicDelegate PlayerLeaderboardMovementDone
	{
		add { _PlayerLeaderboardMovementDone += value; }
		remove { _PlayerLeaderboardMovementDone -= value; }
	}

	private static BasicDelegate _PuzzleFlowFinished;
	public static event BasicDelegate PuzzleFlowFinished
	{
		add { _PuzzleFlowFinished += value; }
		remove { _PuzzleFlowFinished -= value; }
	}

	private static StringDelegate _SkinPurchased;
	public static event StringDelegate SkinPurchased
	{
		add { _SkinPurchased += value; }
		remove { _SkinPurchased -= value; }
	}

	private static StringDelegate _BoardColorPurchased;
	public static event StringDelegate BoardColorPurchased
	{
		add { _BoardColorPurchased += value; }
		remove { _BoardColorPurchased -= value; }
	}

	private static BasicDelegate _HomeScreenLoaded;
	public static event BasicDelegate HomeScreenLoaded
	{
		add { _HomeScreenLoaded += value; }
		remove { _HomeScreenLoaded -= value; }
	}

	private static BasicDelegate _GameScreenLoaded;
	public static event BasicDelegate GameScreenLoaded
	{
		add { _GameScreenLoaded += value; }
		remove { _GameScreenLoaded -= value; }
	}

	private static BasicDelegate _SkinsPopupClosed;
	public static event BasicDelegate SkinsPopupClosed
	{
		add { _SkinsPopupClosed += value; }
		remove { _SkinsPopupClosed -= value; }
	}

	private static BasicDelegate _ClaimedAllQueenEventRewards;
	public static event BasicDelegate ClaimedAllQueenEventRewards
	{
		add { _ClaimedAllQueenEventRewards += value; }
		remove { _ClaimedAllQueenEventRewards -= value; }
	}

	private static BasicDelegate _JigsawPiecesDistributed;
	public static event BasicDelegate JigsawPiecesDistributed
	{
		add { _JigsawPiecesDistributed += value; }
		remove { _JigsawPiecesDistributed -= value; }
	}

	private static BasicDelegate _RanOutOfHearts;
	public static event BasicDelegate RanOutOfHearts
	{
		add { _RanOutOfHearts += value; }
		remove { _RanOutOfHearts -= value; }
	}

	private static IntDelegate _CheckedOutVIP;
	public static event IntDelegate CheckedOutVIP
	{
		add { _CheckedOutVIP += value; }
		remove { _CheckedOutVIP -= value; }
	}

	private static BasicDelegate _SubscriptionDiscountStarted;
	public static event BasicDelegate SubscriptionDiscountStarted
	{
		add { _SubscriptionDiscountStarted += value; }
		remove { _SubscriptionDiscountStarted -= value; }
	}

	private static BasicDelegate _ShowNextSpecialOffer;
	public static event BasicDelegate ShowNextSpecialOffer
	{
		add { _ShowNextSpecialOffer += value; }
		remove { _ShowNextSpecialOffer -= value; }
	}

	private static BasicDelegate _CameraRepositioned;
	public static event BasicDelegate CameraRepositioned
	{
		add { _CameraRepositioned += value; }
		remove { _CameraRepositioned -= value; }
	}

	private static BasicDelegate _GridIntroDone;
	public static event BasicDelegate GridIntroDone
	{
		add { _GridIntroDone += value; }
		remove { _GridIntroDone -= value; }
	}

	private static BasicDelegate _AccesibilityChanged;
	public static event BasicDelegate AccesibilityChanged
	{
		add { _AccesibilityChanged += value; }
		remove { _AccesibilityChanged -= value; }
	}

	private static IntDelegate _WrongCellMarked;
	public static event IntDelegate WrongCellMarked
	{
		add { _WrongCellMarked += value; }
		remove { _WrongCellMarked -= value; }
	}

	private static BasicDelegate _SwipeHappened;
	public static event BasicDelegate SwipeHappened
	{
		add { _SwipeHappened += value; }
		remove { _SwipeHappened -= value; }
	}

	private static BoolDelegate _NoAdsTimeEnabledChanged;
	public static event BoolDelegate NoAdsTimeEnabledChanged
	{
		add { _NoAdsTimeEnabledChanged += value; }
		remove { _NoAdsTimeEnabledChanged -= value; }
	}

	private static BasicDelegate _CalendarPlayButtonUpdated;
	public static event BasicDelegate CalendarPlayButtonUpdated
	{
		add { _CalendarPlayButtonUpdated += value; }
		remove { _CalendarPlayButtonUpdated -= value; }
	}

	private static BasicDelegate _QueenEventTimerFinished;
	public static event BasicDelegate QueenEventTimerFinished
	{
		add { _QueenEventTimerFinished += value; }
		remove { _QueenEventTimerFinished -= value; }
	}

	private static BasicDelegate _WinStreakUpdated;
	public static event BasicDelegate WinStreakUpdated
	{
		add { _WinStreakUpdated += value; }
		remove { _WinStreakUpdated -= value; }
	}

	private static BasicDelegate _JigsawIapPurchased;
	public static event BasicDelegate JigsawIapPurchased
	{
		add { _JigsawIapPurchased += value; }
		remove { _JigsawIapPurchased -= value; }
	}

	private static BasicDelegate _DailyChallengeCompleted;
	public static event BasicDelegate DailyChallengeCompleted
	{
		add { _DailyChallengeCompleted += value; }
		remove { _DailyChallengeCompleted -= value; }
	}

	private static BasicDelegate _DailyChallengeFailed;
	public static event BasicDelegate DailyChallengeFailed
	{
		add { _DailyChallengeFailed += value; }
		remove { _DailyChallengeFailed -= value; }
	}

	private static StringDelegate _LimitedOfferPurchased;
	public static event StringDelegate LimitedOfferPurchased
	{
		add { _LimitedOfferPurchased += value; }
		remove { _LimitedOfferPurchased -= value; }
	}

	private static BasicDelegate _QueenEventStarted;
	public static event BasicDelegate QueenEventStarted
	{
		add { _QueenEventStarted += value; }
		remove { _QueenEventStarted -= value; }
	}

	private static BasicDelegate _JigsawRvFinished;
	public static event BasicDelegate JigsawRvFinished
	{
		add { _JigsawRvFinished += value; }
		remove { _JigsawRvFinished -= value; }
	}

	private static BasicDelegate _Revived;
	public static event BasicDelegate Revived
	{
		add { _Revived += value; }
		remove { _Revived -= value; }
	}

	private static SpriteDelegate _AvatarChanged;
	public static event SpriteDelegate AvatarChanged
	{
		add { _AvatarChanged += value; }
		remove { _AvatarChanged -= value; }
	}

	private static FloatDelegate _CameraResized;
	public static event FloatDelegate CameraResized
	{
		add { _CameraResized += value; }
		remove { _CameraResized -= value; }
	}

	private static Action<Slot> _StoreSlotPurchased;
	public static event Action<Slot> StoreSlotPurchased
	{
		add { _StoreSlotPurchased += value; }
		remove { _StoreSlotPurchased -= value; }
	}

	private static IntDelegate _FreeJigsawPiecesCollected;
	public static event IntDelegate FreeJigsawPiecesCollected
	{
		add { _FreeJigsawPiecesCollected += value; }
		remove { _FreeJigsawPiecesCollected -= value; }
	}

	private static QueenTreasureMilestoneCompletedDelegate _QueenTreasureMilestoneCompleted;
	public static event QueenTreasureMilestoneCompletedDelegate QueenTreasureMilestoneCompleted
	{
		add { _QueenTreasureMilestoneCompleted += value; }
		remove { _QueenTreasureMilestoneCompleted -= value; }
	}

	private static StringDelegate _JigsawPuzzleCompleted;
	public static event StringDelegate JigsawPuzzleCompleted
	{
		add { _JigsawPuzzleCompleted += value; }
		remove { _JigsawPuzzleCompleted -= value; }
	}

	private static BasicDelegate _WeeklyLeaderboardOfferUpdated;
	public static event BasicDelegate WeeklyLeaderboardOfferUpdated
	{
		add { _WeeklyLeaderboardOfferUpdated += value; }
		remove { _WeeklyLeaderboardOfferUpdated -= value; }
	}

	public static void SendDummyEvent()
	{
		_DummyEvent?.Invoke();
	}

	public static void SendQueenFound(int queenCount, bool isLastOne, bool isBoosterUsed)
	{
		_QueenFoundEvent?.Invoke(queenCount, isLastOne, isBoosterUsed);
	}

	public static void SendBoardInteracted(bool firstInteraction)
	{
		_BoardInteractedEvent?.Invoke(firstInteraction);
	}

	public static void SendDailyChallengeMonthChanged(int month)
	{
		_DailyChallengeMonthChanged?.Invoke(month);
	}

	public static void SendLevelSolved()
	{
		_LevelSolved?.Invoke();
	}

	public static void SendLevelFailed()
	{
		_LevelFailed?.Invoke();
	}

	public static void SendHoldCancelled()
	{
		_HoldCancelled?.Invoke();
	}

	public static void SendPlayerLeaderboardMovementStarted(bool isThereAnyMovement)
	{
		_PlayerLeaderboardMovementStarted?.Invoke(isThereAnyMovement);
	}

	public static void SendPlayerLeaderboardMovementDone()
	{
		_PlayerLeaderboardMovementDone?.Invoke();
	}

	public static void SendPuzzleFlowFinished()
	{
		_PuzzleFlowFinished?.Invoke();
	}

	public static void SendSkinPurchased(string clientID)
	{
		_SkinPurchased?.Invoke(clientID);
	}

	public static void SendBoardColorPurchased(string clientID)
	{
		_BoardColorPurchased?.Invoke(clientID);
	}

	public static void SendHomeScreenLoaded()
	{
		_HomeScreenLoaded?.Invoke();
	}

	public static void SendGameScreenLoaded()
	{
		_GameScreenLoaded?.Invoke();
	}

	public static void SendSkinsPopupClosed()
	{
		_SkinsPopupClosed?.Invoke();
	}

	public static void SendCalimedAllQueenEventRewards()
	{
		_ClaimedAllQueenEventRewards?.Invoke();
	}

	public static void SendJigsawPiecesDistributed()
	{
		_JigsawPiecesDistributed?.Invoke();
	}

	public static void SendRanOutOfHearts()
	{
		_RanOutOfHearts?.Invoke();
	}

	public static void SendCheckedOutVIP(int numberOfTimes)
	{
		_CheckedOutVIP?.Invoke(numberOfTimes);
	}

	public static void SendSubscriptionDiscountStarted()
	{
		_SubscriptionDiscountStarted?.Invoke();
	}

	public static void SendNextSpecialOffer()
	{
		_ShowNextSpecialOffer?.Invoke();
	}

	public static void SendCameraRepositionedDone()
	{
		_CameraRepositioned?.Invoke();
	}

	public static void SendGridIntroDone()
	{
		_GridIntroDone?.Invoke();
	}

	public static void SendAccesibilityChanged()
	{
		_AccesibilityChanged?.Invoke();
	}

	public static void SendWrongCellMarked(int cellIndex)
	{
		_WrongCellMarked?.Invoke(cellIndex);
	}

	public static void SendSwipeHappened()
	{
		_SwipeHappened?.Invoke();
	}

	public static void SendNoAdsTimeEnabledChanged(bool enable)
	{
		_NoAdsTimeEnabledChanged?.Invoke(enable);
	}

	public static void SendCalendarPlayButtonUpdated()
	{
		_CalendarPlayButtonUpdated?.Invoke();
	}

	public static void SendQueenEventTimerFinished()
	{
		_QueenEventTimerFinished?.Invoke();
	}

	public static void SendWinStreakUpdated()
	{
		_WinStreakUpdated?.Invoke();
	}

	public static void SendJigsawIapPurchased()
	{
		_JigsawIapPurchased?.Invoke();
	}

	public static void SendDailyChallengeCompleted()
	{
		_DailyChallengeCompleted?.Invoke();
	}

	public static void SendDailyChallengeFailed()
	{
		_DailyChallengeFailed?.Invoke();
	}

	public static void SendLimitedOfferPurchased(string limitedOfferClientId)
	{
		_LimitedOfferPurchased?.Invoke(limitedOfferClientId);
	}

	public static void SendQueenEventStarted()
	{
		_QueenEventStarted?.Invoke();
	}

	public static void SendJigsawRvFinished()
	{
		_JigsawRvFinished?.Invoke();
	}

	public static void SendRevived()
	{
		_Revived?.Invoke();
	}

	public static void SendAvatarChanged(Sprite sprite)
	{
		_AvatarChanged?.Invoke(sprite);
	}

	public static void SendCameraResized(float cameraSize)
	{
		_CameraResized?.Invoke(cameraSize);
	}

	public static void SendStoreSlotPurchased(Slot slot)
	{
		_StoreSlotPurchased?.Invoke(slot);
	}

	public static void SendFreeJigsawPiecesCollected(int tier)
	{
		_FreeJigsawPiecesCollected?.Invoke(tier);
	}

	public static void SendQueenTreasureMilestoneCompleted(int currentSlot, bool isLastOne)
	{
		_QueenTreasureMilestoneCompleted?.Invoke(currentSlot, isLastOne);
	}

	public static void SendPuzzleCompleted(string puzzleClientID)
	{
		_JigsawPuzzleCompleted?.Invoke(puzzleClientID);
	}

	public static void SendWeeklyLeaderboardOfferUpdated()
	{
		_WeeklyLeaderboardOfferUpdated?.Invoke();
	}
}
