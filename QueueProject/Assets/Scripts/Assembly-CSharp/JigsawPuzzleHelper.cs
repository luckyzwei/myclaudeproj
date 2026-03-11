using System;
using System.Collections.Generic;
using Balancy.Models;
using Balancy.Models.JigsawPuzzleEvent;
using KWCore.SaveData;
using KWCore.Utils;
using UnityEngine;

public class JigsawPuzzleHelper : MonoBehaviour
{
	private const int BITS_IN_INT = 30;

	private const long TWENTY_FOR_HOUR_TO_SECS = 86400L;

	public static void CollectedPiece(string clientID, int pieceIndex)
	{
		SetBit(clientID, pieceIndex, true, BucketJigsaw.GetCollectedPiecesBits, BucketJigsaw.SetCollectedPiecesBits);
	}

	public static void VisitedPiece(string clientID, int pieceIndex)
	{
		SetBit(clientID, pieceIndex, true, BucketJigsaw.GetVisitedPiecesBits, BucketJigsaw.SetVisitedPiecesBits);
	}

	public static void VisitedAllCollectedPieces(string clientID)
	{
		List<int> collected = BucketJigsaw.GetCollectedPiecesBits(clientID);
		if (collected == null)
			return;
		BucketJigsaw.SetVisitedPiecesBits(clientID, new List<int>(collected));
	}

	public static List<int> GetAllCollectedPiece(string clientID)
	{
		List<int> bits = BucketJigsaw.GetCollectedPiecesBits(clientID);
		if (bits == null)
			return new List<int>();

		List<int> result = new List<int>();
		for (int i = 0; i < bits.Count * BITS_IN_INT; i++)
		{
			if (GetBit(bits, i))
				result.Add(i);
		}
		return result;
	}

	public static int GetAllCollectedPiecesCount(string clientID)
	{
		return GetAllCollectedPiece(clientID).Count;
	}

	public static List<int> GetAllVisitedPiece(string clientID)
	{
		List<int> bits = BucketJigsaw.GetVisitedPiecesBits(clientID);
		if (bits == null)
			return new List<int>();

		List<int> result = new List<int>();
		for (int i = 0; i < bits.Count * BITS_IN_INT; i++)
		{
			if (GetBit(bits, i))
				result.Add(i);
		}
		return result;
	}

	public static bool HasUnseenPieces(string clientId)
	{
		int collected = GetAllCollectedPiecesCount(clientId);
		int visited = GetAllVisitedCount(clientId);
		return collected > visited;
	}

	public static int GetAllVisitedCount(string clientID)
	{
		return GetAllVisitedPiece(clientID).Count;
	}

	public static bool IsPieceCollected(string clientID, int index)
	{
		List<int> bits = BucketJigsaw.GetCollectedPiecesBits(clientID);
		if (bits == null)
			return false;
		return GetBit(bits, index);
	}

	public static bool IsPieceVisited(string clientID, int index)
	{
		List<int> bits = BucketJigsaw.GetVisitedPiecesBits(clientID);
		if (bits == null)
			return false;
		return GetBit(bits, index);
	}

	private static void SetBit(string clientID, int index, bool value, Func<string, List<int>> getBits, Action<string, List<int>> setBits)
	{
		List<int> bits = getBits(clientID);
		if (bits == null)
			bits = new List<int>();

		int intIndex = index / BITS_IN_INT;
		int bitIndex = index % BITS_IN_INT;

		while (bits.Count <= intIndex)
			bits.Add(0);

		if (value)
			bits[intIndex] |= (1 << bitIndex);
		else
			bits[intIndex] &= ~(1 << bitIndex);

		setBits(clientID, bits);
	}

	private static bool GetBit(List<int> list, int index)
	{
		if (list == null)
			return false;

		int intIndex = index / BITS_IN_INT;
		int bitIndex = index % BITS_IN_INT;

		if (intIndex >= list.Count)
			return false;

		return (list[intIndex] & (1 << bitIndex)) != 0;
	}

	public static bool GetIsPuzzleRewardClaimed(string clientId)
	{
		return BucketJigsaw.GetClaimed(clientId);
	}

	public static void SetPuzzleRewardClaimed(string clientId)
	{
		BucketJigsaw.SetClaimed(clientId, true);
	}

	public static void AddJigsawPuzzleEventData(JigsawEvent jigsawEvent)
	{
		if (jigsawEvent == null)
			return;

		string clientId = jigsawEvent.ClientId;
		List<string> eventIds = BucketJigsaw.GetEventIds();
		if (eventIds == null)
			eventIds = new List<string>();

		if (!eventIds.Contains(clientId))
		{
			eventIds.Add(clientId);
			BucketJigsaw.SetEventIds(eventIds);
		}

		BucketJigsaw.SetIsEventActive(clientId, true);
		BucketJigsaw.SetEventName(clientId, jigsawEvent.Name?.ToString() ?? clientId);
	}

	public static List<string> GetActiveJigsawEventIds()
	{
		// Active events come from Balancy LiveOps (DLL types).
		// Return event IDs tracked in BucketJigsaw instead.
		List<string> eventIds = BucketJigsaw.GetEventIds();
		if (eventIds == null) return new List<string>();
		var result = new List<string>();
		foreach (var id in eventIds)
		{
			if (BucketJigsaw.GetIsEventActive(id))
				result.Add(id);
		}
		return result;
	}

	public static JigsawEvent GetJigsawEvent(string clientId)
	{
		// JigsawEvent details come from Balancy DLL; return null as fallback
		return null;
	}

	public static bool IsLiveAndUnlocked()
	{
		if (!IsUnlockLevelReached())
			return false;

		var activeIds = GetActiveJigsawEventIds();
		return activeIds != null && activeIds.Count > 0;
	}

	public static bool IsUnlockLevelReached()
	{
		return BucketJigsaw.GetJigsawPuzzleUnlocked();
	}

	public static bool AreAllEventsCompleted()
	{
		var activeIds = GetActiveJigsawEventIds();
		if (activeIds == null || activeIds.Count == 0)
			return true;

		foreach (var id in activeIds)
		{
			if (!JigsawPuzzlesManager.Instance.AreAllPuzzlesCompleted(id))
				return false;
		}
		return true;
	}

	public static string FindNextExpiringEventId()
	{
		var activeIds = GetActiveJigsawEventIds();
		if (activeIds == null || activeIds.Count == 0)
			return null;

		string nextExpiring = null;
		int minTime = int.MaxValue;

		foreach (var id in activeIds)
		{
			int timeLeft = QueensGameEventsHelper.GetTimeLeftUntilEventFinish(id);
			if (timeLeft > 0 && timeLeft < minTime)
			{
				minTime = timeLeft;
				nextExpiring = id;
			}
		}
		return nextExpiring;
	}

	public static int FindTimeUntilNextEvent()
	{
		var activeEvents = GetActiveJigsawEventIds();
		if (activeEvents != null && activeEvents.Count > 0)
			return 0;

		List<string> eventIds = BucketJigsaw.GetEventIds();
		if (eventIds == null || eventIds.Count == 0)
			return 0;

		int minTime = int.MaxValue;
		foreach (var eventId in eventIds)
		{
			int timeLeft = QueensGameEventsHelper.GetTimeLeftUntilEventStart(eventId);
			if (timeLeft > 0 && timeLeft < minTime)
			{
				minTime = timeLeft;
			}
		}
		return minTime == int.MaxValue ? 0 : minTime;
	}

	public static int GetTotalPiecesForEvent(JigsawEvent jigsawEvent)
	{
		if (jigsawEvent == null)
			return 0;

		List<string> puzzleIds = BucketJigsaw.GetPuzzleIds(jigsawEvent.ClientId);
		if (puzzleIds == null || puzzleIds.Count == 0)
			return 0;

		int total = 0;
		for (int i = 0; i < puzzleIds.Count; i++)
		{
			total += JigsawPuzzlesManager.Instance.GetPuzzlePiecesCount(puzzleIds[i]);
		}
		return total;
	}

	public static int GetCollectedPiecesForEvent(JigsawEvent jigsawEvent)
	{
		if (jigsawEvent == null)
			return 0;

		List<string> puzzleIds = BucketJigsaw.GetPuzzleIds(jigsawEvent.ClientId);
		if (puzzleIds == null || puzzleIds.Count == 0)
			return 0;

		int collected = 0;
		for (int i = 0; i < puzzleIds.Count; i++)
		{
			collected += GetAllCollectedPiecesCount(puzzleIds[i]);
		}
		return collected;
	}

	public static float GetEventPercentComplete(string clientId)
	{
		JigsawEvent jigsawEvent = GetJigsawEvent(clientId);
		if (jigsawEvent == null)
			return 0f;

		int total = GetTotalPiecesForEvent(jigsawEvent);
		if (total <= 0)
			return 0f;

		int collected = GetCollectedPiecesForEvent(jigsawEvent);
		return (float)collected / total;
	}

	public static float GetPuzzlePercentComplete(string puzzleId)
	{
		int total = JigsawPuzzlesManager.Instance.GetPuzzlePiecesCount(puzzleId);
		if (total <= 0)
			return 0f;

		int collected = GetAllCollectedPiecesCount(puzzleId);
		return (float)collected / total;
	}

	public static string GetEventName(string clientId)
	{
		return BucketJigsaw.GetEventName(clientId);
	}

	public static bool CheckFreeJigsawPiecesReset()
	{
		long lastClaimedTime = BucketJigsaw.GetFirstRvPurchaseTime();
		if (lastClaimedTime <= 0)
			return true;

		long currentTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		return (currentTime - lastClaimedTime) >= TWENTY_FOR_HOUR_TO_SECS;
	}

	public static void SetTimeForFreePiecesClaimed()
	{
		long currentTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		BucketJigsaw.SetFirstRvPurchaseTime(currentTime);
	}

	public static void CheckNotificationFreeJigsawPieces()
	{
		if (!IsLiveAndUnlocked())
			return;

		if (CheckFreeJigsawPiecesReset())
		{
			NotificationWidgetManager.Instance.AddNotification(JigsawPuzzlesManager.JIGSAW_NOTIFICATION);
		}
	}
}
