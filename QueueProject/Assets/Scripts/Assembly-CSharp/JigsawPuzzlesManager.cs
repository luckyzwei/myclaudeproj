using System;
using System.Collections.Generic;
using Balancy.Models.JigsawPuzzleEvent;
using KWCore.SaveData;
using KWCore.Utils;
using Spine.Unity;
using UnityEngine;

public class JigsawPuzzlesManager : MonoSingleton<JigsawPuzzlesManager>, IQueueableEntity
{
	public static string JIGSAW_NOTIFICATION;

	public static string JIGSAW_NEW_SEASON;

	public static string JIGSAW_RV;

	public static string JIGSAW_RV_FINISH;

	private const int COMPLETION_PERCENT = 0;

	[SerializeField]
	private JigsawPuzzlesDb m_db;

	private Dictionary<string, JigsawGenerator> m_generators;

	private JigsawEvent m_newJigsawEvent;

	private string m_pastJigsawEventId;

	private string m_overrideEventId;

	private bool m_needsRefreshing;

	private bool m_checkForNewEventWhenBack;

	public JigsawEvent CurrentActiveEvent => m_newJigsawEvent;

	public JigsawPuzzlesDb JigsawPuzzlesDb => m_db;

	public string OverrideEventId => m_overrideEventId;

	public bool NeedsRefreshing => m_needsRefreshing;

	public bool CheckForNewEventWhenBack => m_checkForNewEventWhenBack;

	public JigsawGenerator GetJigsawGenerator(string clientID)
	{
		if (m_generators != null && m_generators.TryGetValue(clientID, out var generator))
		{
			return generator;
		}
		return null;
	}

	protected override void Init()
	{
		m_generators = new Dictionary<string, JigsawGenerator>();
		JIGSAW_NOTIFICATION = "jigsaw_notification";
		JIGSAW_NEW_SEASON = "jigsaw_new_season";
		JIGSAW_RV = "jigsaw_rv";
		JIGSAW_RV_FINISH = "jigsaw_rv_finish";
	}

	public JigsawPuzzlesDb.EventPosterData GetEventPosterData(string clientId)
	{
		if (m_db != null)
		{
			return m_db.GetEventPoster(clientId);
		}
		return default(JigsawPuzzlesDb.EventPosterData);
	}

	public Texture2D GetPuzzleImage(string clientID)
	{
		if (m_db != null)
		{
			return m_db.GetPuzzleImage(clientID);
		}
		return null;
	}

	public SkeletonDataAsset GetSpineSkeleton(string clientID)
	{
		if (m_db != null)
		{
			return m_db.GetSpineSkeleton(clientID);
		}
		return null;
	}

	public JigsawPuzzles GetPuzzleData(string clientID)
	{
		// JigsawPuzzles is a Balancy DLL model type; cannot resolve without DLL internals
		return null;
	}

	public Vector2Int GetPuzzleSize(string clientID)
	{
		// Puzzle size comes from Balancy JigsawPuzzles model data
		return default(Vector2Int);
	}

	public int GetPuzzlePiecesCount(string clientID)
	{
		Vector2Int size = GetPuzzleSize(clientID);
		return size.x * size.y;
	}

	public bool IsCompleted(string clientID, bool countOnlyVisited = false)
	{
		int totalPieces = GetPuzzlePiecesCount(clientID);
		if (totalPieces <= 0)
		{
			return false;
		}
		int count = countOnlyVisited
			? JigsawPuzzleHelper.GetAllVisitedCount(clientID)
			: JigsawPuzzleHelper.GetAllCollectedPiecesCount(clientID);
		return count >= totalPieces;
	}

	public void AddRandomPiece(string clientID)
	{
		int totalPieces = GetPuzzlePiecesCount(clientID);
		if (totalPieces <= 0)
		{
			return;
		}
		List<int> uncollected = new List<int>();
		for (int i = 0; i < totalPieces; i++)
		{
			if (!JigsawPuzzleHelper.IsPieceCollected(clientID, i))
			{
				uncollected.Add(i);
			}
		}
		if (uncollected.Count > 0)
		{
			int randomIndex = UnityEngine.Random.Range(0, uncollected.Count);
			JigsawPuzzleHelper.CollectedPiece(clientID, uncollected[randomIndex]);
		}
	}

	public int AddRemainingPieces(string clientID)
	{
		int totalPieces = GetPuzzlePiecesCount(clientID);
		int added = 0;
		for (int i = 0; i < totalPieces; i++)
		{
			if (!JigsawPuzzleHelper.IsPieceCollected(clientID, i))
			{
				JigsawPuzzleHelper.CollectedPiece(clientID, i);
				added++;
			}
		}
		return added;
	}

	public JigsawEvent GetEvent(string eventId)
	{
		return JigsawPuzzleHelper.GetJigsawEvent(eventId);
	}

	private Dictionary<string, int> DistributePiecesToPuzzles(JigsawEvent jigsawEvent, int amountOfPieces)
	{
		Dictionary<string, int> distribution = new Dictionary<string, int>();
		if (jigsawEvent == null || amountOfPieces <= 0)
		{
			return distribution;
		}
		// Get puzzle IDs from the event via save data
		string eventId = m_overrideEventId ?? m_pastJigsawEventId;
		if (string.IsNullOrEmpty(eventId))
		{
			return distribution;
		}
		List<string> puzzleIds = BucketJigsaw.GetPuzzleIds(eventId);
		if (puzzleIds == null || puzzleIds.Count == 0)
		{
			return distribution;
		}
		// Find incomplete puzzles and distribute pieces evenly
		List<string> incompletePuzzles = new List<string>();
		foreach (string puzzleId in puzzleIds)
		{
			if (!IsCompleted(puzzleId))
			{
				incompletePuzzles.Add(puzzleId);
			}
		}
		if (incompletePuzzles.Count == 0)
		{
			return distribution;
		}
		int piecesPerPuzzle = amountOfPieces / incompletePuzzles.Count;
		int remainder = amountOfPieces % incompletePuzzles.Count;
		for (int i = 0; i < incompletePuzzles.Count; i++)
		{
			int pieces = piecesPerPuzzle + (i < remainder ? 1 : 0);
			if (pieces > 0)
			{
				distribution[incompletePuzzles[i]] = pieces;
			}
		}
		return distribution;
	}

	public void AddPiecesToPuzzles()
	{
		JigsawEvent jigsawEvent = CurrentActiveEvent;
		if (jigsawEvent == null)
		{
			return;
		}
		int totalPieces = JigsawPuzzleHelper.GetTotalPiecesForEvent(jigsawEvent);
		int collectedPieces = JigsawPuzzleHelper.GetCollectedPiecesForEvent(jigsawEvent);
		int remaining = totalPieces - collectedPieces;
		if (remaining <= 0)
		{
			return;
		}
		Dictionary<string, int> distribution = DistributePiecesToPuzzles(jigsawEvent, remaining);
		foreach (var kvp in distribution)
		{
			for (int i = 0; i < kvp.Value; i++)
			{
				AddRandomPiece(kvp.Key);
			}
		}
	}

	public Sprite GetBgImageForSize(Vector2Int size)
	{
		if (m_db != null)
		{
			return m_db.GetBgImage(size);
		}
		return null;
	}

	public bool AreAllPuzzlesCompleted(string clientId)
	{
		List<string> puzzleIds = BucketJigsaw.GetPuzzleIds(clientId);
		if (puzzleIds == null || puzzleIds.Count == 0)
		{
			return false;
		}
		for (int i = 0; i < puzzleIds.Count; i++)
		{
			if (!IsCompleted(puzzleIds[i]))
			{
				return false;
			}
		}
		return true;
	}

	public bool CheckForNewEvent(Action finishCallback = null, bool needsRefreshing = false)
	{
		List<string> activeEventIds = JigsawPuzzleHelper.GetActiveJigsawEventIds();
		if (activeEventIds == null || activeEventIds.Count == 0)
		{
			finishCallback?.Invoke();
			return false;
		}
		m_needsRefreshing = needsRefreshing;
		m_checkForNewEventWhenBack = false;
		finishCallback?.Invoke();
		return true;
	}

	public Sprite GetEventPoster(string eventId)
	{
		if (m_db != null)
		{
			JigsawPuzzlesDb.EventPosterData posterData = m_db.GetEventPoster(eventId);
			return posterData.image;
		}
		return null;
	}

	public Sprite GetPastEventPoster(string eventId)
	{
		if (m_db != null)
		{
			JigsawPuzzlesDb.EventPosterData posterData = m_db.GetEventPoster(eventId);
			return posterData.eventFinishedImage;
		}
		return null;
	}

	public void StartProcess(Action finishCallback)
	{
		bool hasNewEvent = CheckForNewEvent(null, false);
		if (hasNewEvent && m_newJigsawEvent != null)
		{
			NewJigsawEventClosed(finishCallback);
		}
		else
		{
			finishCallback?.Invoke();
		}
	}

	private void NewJigsawEventClosed(Action finishCallback)
	{
		m_newJigsawEvent = null;
		m_checkForNewEventWhenBack = false;
		finishCallback?.Invoke();
	}

	public int GetPriority()
	{
		return 100;
	}

	public int GetUnlockLocationMask()
	{
		return 0xFFFF;
	}

	public void SetOverrideEventId(string eventId)
	{
		m_overrideEventId = eventId;
	}

	public void SetNeedsRefreshing(bool needsRefreshing)
	{
		m_needsRefreshing = needsRefreshing;
	}

	public void SetCheckForNewEvent(bool needsCheckForNewEvent)
	{
		m_checkForNewEventWhenBack = needsCheckForNewEvent;
	}

	public void CheckPastEvents()
	{
		List<string> eventIds = BucketJigsaw.GetEventIds();
		if (eventIds == null || eventIds.Count == 0)
		{
			return;
		}
		for (int i = 0; i < eventIds.Count; i++)
		{
			string eventId = eventIds[i];
			bool isActive = BucketJigsaw.GetIsEventActive(eventId);
			if (isActive)
			{
				JigsawEvent jigsawEvent = GetEvent(eventId);
				if (jigsawEvent == null)
				{
					BucketJigsaw.SetIsEventActive(eventId, false);
					m_pastJigsawEventId = eventId;
				}
			}
		}
	}
}
