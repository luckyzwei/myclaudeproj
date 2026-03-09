using System;
using System.Runtime.CompilerServices;
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

	public static event BasicDelegate DummyEvent
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

	public static event QueenFoundDelegate QueenFoundEvent
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

	public static event BoolDelegate BoardInteractedEvent
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

	public static event IntDelegate DailyChallengeMonthChanged
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

	public static event BasicDelegate LevelSolved
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

	public static event BasicDelegate LevelFailed
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

	public static event BasicDelegate HoldCancelled
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

	public static event BoolDelegate PlayerLeaderboardMovementStarted
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

	public static event BasicDelegate PlayerLeaderboardMovementDone
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

	public static event BasicDelegate PuzzleFlowFinished
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

	public static event StringDelegate SkinPurchased
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

	public static event StringDelegate BoardColorPurchased
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

	public static event BasicDelegate HomeScreenLoaded
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

	public static event BasicDelegate GameScreenLoaded
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

	public static event BasicDelegate SkinsPopupClosed
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

	public static event BasicDelegate ClaimedAllQueenEventRewards
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

	public static event BasicDelegate JigsawPiecesDistributed
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

	public static event BasicDelegate RanOutOfHearts
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

	public static event IntDelegate CheckedOutVIP
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

	public static event BasicDelegate SubscriptionDiscountStarted
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

	public static event BasicDelegate ShowNextSpecialOffer
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

	public static event BasicDelegate CameraRepositioned
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

	public static event BasicDelegate GridIntroDone
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

	public static event BasicDelegate AccesibilityChanged
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

	public static event IntDelegate WrongCellMarked
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

	public static event BasicDelegate SwipeHappened
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

	public static event BoolDelegate NoAdsTimeEnabledChanged
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

	public static event BasicDelegate CalendarPlayButtonUpdated
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

	public static event BasicDelegate QueenEventTimerFinished
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

	public static event BasicDelegate WinStreakUpdated
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

	public static event BasicDelegate JigsawIapPurchased
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

	public static event BasicDelegate DailyChallengeCompleted
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

	public static event BasicDelegate DailyChallengeFailed
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

	public static event StringDelegate LimitedOfferPurchased
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

	public static event BasicDelegate QueenEventStarted
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

	public static event BasicDelegate JigsawRvFinished
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

	public static event BasicDelegate Revived
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

	public static event SpriteDelegate AvatarChanged
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

	public static event FloatDelegate CameraResized
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

	public static event Action<Slot> StoreSlotPurchased
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

	public static event IntDelegate FreeJigsawPiecesCollected
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

	public static event QueenTreasureMilestoneCompletedDelegate QueenTreasureMilestoneCompleted
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

	public static event StringDelegate JigsawPuzzleCompleted
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

	public static event BasicDelegate WeeklyLeaderboardOfferUpdated
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

	public static void SendDummyEvent()
	{
	}

	public static void SendQueenFound(int queenCount, bool isLastOne, bool isBoosterUsed)
	{
	}

	public static void SendBoardInteracted(bool firstInteraction)
	{
	}

	public static void SendDailyChallengeMonthChanged(int month)
	{
	}

	public static void SendLevelSolved()
	{
	}

	public static void SendLevelFailed()
	{
	}

	public static void SendHoldCancelled()
	{
	}

	public static void SendPlayerLeaderboardMovementStarted(bool isThereAnyMovement)
	{
	}

	public static void SendPlayerLeaderboardMovementDone()
	{
	}

	public static void SendPuzzleFlowFinished()
	{
	}

	public static void SendSkinPurchased(string clientID)
	{
	}

	public static void SendBoardColorPurchased(string clientID)
	{
	}

	public static void SendHomeScreenLoaded()
	{
	}

	public static void SendGameScreenLoaded()
	{
	}

	public static void SendSkinsPopupClosed()
	{
	}

	public static void SendCalimedAllQueenEventRewards()
	{
	}

	public static void SendJigsawPiecesDistributed()
	{
	}

	public static void SendRanOutOfHearts()
	{
	}

	public static void SendCheckedOutVIP(int numberOfTimes)
	{
	}

	public static void SendSubscriptionDiscountStarted()
	{
	}

	public static void SendNextSpecialOffer()
	{
	}

	public static void SendCameraRepositionedDone()
	{
	}

	public static void SendGridIntroDone()
	{
	}

	public static void SendAccesibilityChanged()
	{
	}

	public static void SendWrongCellMarked(int cellIndex)
	{
	}

	public static void SendSwipeHappened()
	{
	}

	public static void SendNoAdsTimeEnabledChanged(bool enable)
	{
	}

	public static void SendCalendarPlayButtonUpdated()
	{
	}

	public static void SendQueenEventTimerFinished()
	{
	}

	public static void SendWinStreakUpdated()
	{
	}

	public static void SendJigsawIapPurchased()
	{
	}

	public static void SendDailyChallengeCompleted()
	{
	}

	public static void SendDailyChallengeFailed()
	{
	}

	public static void SendLimitedOfferPurchased(string limitedOfferClientId)
	{
	}

	public static void SendQueenEventStarted()
	{
	}

	public static void SendJigsawRvFinished()
	{
	}

	public static void SendRevived()
	{
	}

	public static void SendAvatarChanged(Sprite sprite)
	{
	}

	public static void SendCameraResized(float cameraSize)
	{
	}

	public static void SendStoreSlotPurchased(Slot slot)
	{
	}

	public static void SendFreeJigsawPiecesCollected(int tier)
	{
	}

	public static void SendQueenTreasureMilestoneCompleted(int currentSlot, bool isLastOne)
	{
	}

	public static void SendPuzzleCompleted(string puzzleClientID)
	{
	}

	public static void SendWeeklyLeaderboardOfferUpdated()
	{
	}
}
