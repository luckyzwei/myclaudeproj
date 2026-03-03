using System;
using System.Collections.Generic;

public class DailyQuestData : IClientData
{
	public int DayPoint;

	public int WeekPoint;

	public DateTime NextWeekResetTime;

	public DateTime QuestResetTime;

	public List<int> CompleteQuests;

	public List<int> GetDailyRewards;

	public List<int> GetWeekRewards;

	public List<int> GetWeekReplaces;

	public List<QuestData> Quests;
}
