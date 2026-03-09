using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelOrder", menuName = "ScriptableObjects/LevelOrder")]
public class LevelOrder : ScriptableObject
{
	public const int DAILY_CHALLENGE_STARTING_YEAR = 2025;

	public const int SEED_MULTIPLIER = 17;

	public LevelList levelOrder;

	public LevelList dailyChallenges;

	public LevelList royalTournament;

	public LevelList alternativeLevels;

	public LevelList expertMode;

	private Dictionary<string, LevelDataScriptable> m_levelDictionary;

	public LevelDataScriptable GetDailyChallenge(DCDate date)
	{
		return null;
	}

	public LevelDataScriptable GetLevel(int index, bool sendEvent = false)
	{
		return null;
	}

	public LevelDataScriptable GetTournamentLevel(int index)
	{
		return null;
	}

	public LevelDataScriptable GetLevel(string clientID)
	{
		return null;
	}

	public LevelDataScriptable GetExpertLevel(int index)
	{
		return null;
	}

	private int SanitiseLevelIndex(int index, int levelCount, int loopBuffer)
	{
		return 0;
	}
}
