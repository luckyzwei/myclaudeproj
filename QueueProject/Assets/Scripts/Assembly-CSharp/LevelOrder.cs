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
		if (dailyChallenges == null || dailyChallenges.levels == null || dailyChallenges.levels.Count == 0)
			return null;

		// Calculate day offset from starting date
		int daysSinceStart = (date.year - DAILY_CHALLENGE_STARTING_YEAR) * 365 + (date.month - 1) * 30 + date.day;
		int index = SanitiseLevelIndex(daysSinceStart, dailyChallenges.levels.Count, 0);
		return dailyChallenges.levels[index];
	}

	public LevelDataScriptable GetLevel(int index, bool sendEvent = false)
	{
		if (levelOrder == null || levelOrder.levels == null || levelOrder.levels.Count == 0)
			return null;
		int safeIndex = SanitiseLevelIndex(index, levelOrder.levels.Count, 10);
		return levelOrder.levels[safeIndex];
	}

	public LevelDataScriptable GetTournamentLevel(int index)
	{
		if (royalTournament == null || royalTournament.levels == null || royalTournament.levels.Count == 0)
			return null;
		int safeIndex = SanitiseLevelIndex(index, royalTournament.levels.Count, 0);
		return royalTournament.levels[safeIndex];
	}

	public LevelDataScriptable GetLevel(string clientID)
	{
		if (m_levelDictionary == null)
		{
			m_levelDictionary = new Dictionary<string, LevelDataScriptable>();
			if (levelOrder != null && levelOrder.levels != null)
			{
				for (int i = 0; i < levelOrder.levels.Count; i++)
				{
					var lvl = levelOrder.levels[i];
					if (lvl != null && lvl.data != null && !string.IsNullOrEmpty(lvl.data.name))
						m_levelDictionary[lvl.data.name] = lvl;
				}
			}
		}

		LevelDataScriptable result;
		if (m_levelDictionary.TryGetValue(clientID, out result))
			return result;
		return null;
	}

	public LevelDataScriptable GetExpertLevel(int index)
	{
		if (expertMode == null || expertMode.levels == null || expertMode.levels.Count == 0)
			return null;
		int safeIndex = SanitiseLevelIndex(index, expertMode.levels.Count, 0);
		return expertMode.levels[safeIndex];
	}

	private int SanitiseLevelIndex(int index, int levelCount, int loopBuffer)
	{
		if (levelCount <= 0) return 0;
		if (index < 0) index = 0;
		if (index >= levelCount)
		{
			// Loop back with buffer
			int loopStart = Mathf.Max(0, levelCount - loopBuffer);
			int loopRange = levelCount - loopStart;
			if (loopRange <= 0) return levelCount - 1;
			index = loopStart + (index - levelCount) % loopRange;
		}
		return index;
	}
}
