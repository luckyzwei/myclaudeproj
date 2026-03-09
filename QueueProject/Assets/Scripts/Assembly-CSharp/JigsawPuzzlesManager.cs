using System;
using System.Collections.Generic;
using Balancy.Models.JigsawPuzzleEvent;
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

	public JigsawEvent CurrentActiveEvent => null;

	public JigsawPuzzlesDb JigsawPuzzlesDb => null;

	public string OverrideEventId => null;

	public bool NeedsRefreshing => false;

	public bool CheckForNewEventWhenBack => false;

	public JigsawGenerator GetJigsawGenerator(string clientID)
	{
		return null;
	}

	protected override void Init()
	{
	}

	public JigsawPuzzlesDb.EventPosterData GetEventPosterData(string clientId)
	{
		return default(JigsawPuzzlesDb.EventPosterData);
	}

	public Texture2D GetPuzzleImage(string clientID)
	{
		return null;
	}

	public SkeletonDataAsset GetSpineSkeleton(string clientID)
	{
		return null;
	}

	public JigsawPuzzles GetPuzzleData(string clientID)
	{
		return null;
	}

	public Vector2Int GetPuzzleSize(string clientID)
	{
		return default(Vector2Int);
	}

	public int GetPuzzlePiecesCount(string clientID)
	{
		return 0;
	}

	public bool IsCompleted(string clientID, bool countOnlyVisited = false)
	{
		return false;
	}

	public void AddRandomPiece(string clientID)
	{
	}

	public int AddRemainingPieces(string clientID)
	{
		return 0;
	}

	public JigsawEvent GetEvent(string eventId)
	{
		return null;
	}

	private Dictionary<string, int> DistributePiecesToPuzzles(JigsawEvent jigsawEvent, int amountOfPieces)
	{
		return null;
	}

	public void AddPiecesToPuzzles()
	{
	}

	public Sprite GetBgImageForSize(Vector2Int size)
	{
		return null;
	}

	public bool AreAllPuzzlesCompleted(string clientId)
	{
		return false;
	}

	public bool CheckForNewEvent(Action finishCallback = null, bool needsRefreshing = false)
	{
		return false;
	}

	public Sprite GetEventPoster(string eventId)
	{
		return null;
	}

	public Sprite GetPastEventPoster(string eventId)
	{
		return null;
	}

	public void StartProcess(Action finishCallback)
	{
	}

	private void NewJigsawEventClosed(Action finishCallback)
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

	public void SetOverrideEventId(string eventId)
	{
	}

	public void SetNeedsRefreshing(bool needsRefreshing)
	{
	}

	public void SetCheckForNewEvent(bool needsCheckForNewEvent)
	{
	}

	public void CheckPastEvents()
	{
	}
}
