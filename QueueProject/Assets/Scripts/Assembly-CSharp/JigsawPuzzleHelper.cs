using System;
using System.Collections.Generic;
using Balancy.Models;
using Balancy.Models.JigsawPuzzleEvent;
using UnityEngine;

public class JigsawPuzzleHelper : MonoBehaviour
{
	private const int BITS_IN_INT = 30;

	private const long TWENTY_FOR_HOUR_TO_SECS = 86400L;

	public static void CollectedPiece(string clientID, int pieceIndex)
	{
	}

	public static void VisitedPiece(string clientID, int pieceIndex)
	{
	}

	public static void VisitedAllCollectedPieces(string clientID)
	{
	}

	public static List<int> GetAllCollectedPiece(string clientID)
	{
		return null;
	}

	public static int GetAllCollectedPiecesCount(string clientID)
	{
		return 0;
	}

	public static List<int> GetAllVisitedPiece(string clientID)
	{
		return null;
	}

	public static bool HasUnseenPieces(string clientId)
	{
		return false;
	}

	public static int GetAllVisitedCount(string clientID)
	{
		return 0;
	}

	public static bool IsPieceCollected(string clientID, int index)
	{
		return false;
	}

	public static bool IsPieceVisited(string clientID, int index)
	{
		return false;
	}

	private static void SetBit(string clientID, int index, bool value, Func<string, List<int>> getBits, Action<string, List<int>> setBits)
	{
	}

	private static bool GetBit(List<int> list, int index)
	{
		return false;
	}

	public static bool GetIsPuzzleRewardClaimed(string clientId)
	{
		return false;
	}

	public static void SetPuzzleRewardClaimed(string clientId)
	{
	}

	public static void AddJigsawPuzzleEventData(JigsawEvent jigsawEvent)
	{
	}

	public static List<JigsawPuzzleGameEvent> GetActiveJigsawEvents()
	{
		return null;
	}

	public static JigsawEvent GetJigsawEvent(string clientId)
	{
		return null;
	}

	public static bool IsLiveAndUnlocked()
	{
		return false;
	}

	public static bool IsUnlockLevelReached()
	{
		return false;
	}

	public static bool AreAllEventsCompleted()
	{
		return false;
	}

	public static JigsawPuzzleGameEvent FindNextExpiringEvent()
	{
		return null;
	}

	public static int FindTimeUntilNextEvent()
	{
		return 0;
	}

	public static int GetTotalPiecesForEvent(JigsawEvent jigsawEvent)
	{
		return 0;
	}

	public static int GetCollectedPiecesForEvent(JigsawEvent jigsawEvent)
	{
		return 0;
	}

	public static float GetEventPercentComplete(string clientId)
	{
		return 0f;
	}

	public static float GetPuzzlePercentComplete(string puzzleId)
	{
		return 0f;
	}

	public static string GetEventName(string clientId)
	{
		return null;
	}

	public static bool CheckFreeJigsawPiecesReset()
	{
		return false;
	}

	public static void SetTimeForFreePiecesClaimed()
	{
	}

	public static void CheckNotificationFreeJigsawPieces()
	{
	}
}
