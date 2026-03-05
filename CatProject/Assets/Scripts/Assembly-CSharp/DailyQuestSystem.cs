using System;
using Treeplla;
using UniRx;

public class DailyQuestSystem
{
	public enum QuestType
	{
		OfficeItemUpgrade = 1,
		CompanyLevelUp = 2,
		PlantGiveTonic = 3,
		AdsupplyView = 4,
		GetDailyQuestPoint = 5,
		AnyAdsView = 6,
		RunRoulette = 7,
		AnyProductPurchase = 8,
		ContractCompany = 9,
		FactoryOrderComplete = 10,
		FactoryBuyOrUpgrade = 11,
		GameConnectionDuration = 12,
		BizAcqBattleStart = 13
	}

	private CompositeDisposable disposables;

	public IReactiveProperty<int> RemainDailyResetTime;

	public IReactiveProperty<int> RemainWeekResetTime;

	public void Init()
	{
		disposables = new CompositeDisposable();
		RemainDailyResetTime = new ReactiveProperty<int>(0);
		RemainWeekResetTime = new ReactiveProperty<int>(0);
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.DailyQuestData == null) return;
		var questData = userData.DailyQuestData;
		if (questData.Quests != null)
		{
			for (int i = 0; i < questData.Quests.Count; i++)
			{
				SubscribeQuest(i);
			}
		}
	}

	public void UpdateOneSeconds()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.DailyQuestData == null) return;
		var questData = userData.DailyQuestData;
		var now = DateTime.UtcNow;
		int dailyRemain = (int)(questData.QuestResetTime - now).TotalSeconds;
		RemainDailyResetTime.Value = Math.Max(0, dailyRemain);
		int weekRemain = (int)(questData.NextWeekResetTime - now).TotalSeconds;
		RemainWeekResetTime.Value = Math.Max(0, weekRemain);
		if (dailyRemain <= 0)
			ResetDailyQuest();
		if (weekRemain <= 0)
			ResetWeekQuest();
	}

	private void SubscribeQuest(int order)
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.DailyQuestData == null) return;
		var questData = userData.DailyQuestData;
		if (questData.Quests == null || order < 0 || order >= questData.Quests.Count) return;
		var quest = questData.Quests[order];
		if (quest == null || quest.Value == null) return;
		quest.Value.Subscribe(v =>
		{
			// Check quest completion
		}).AddTo(disposables);
	}

	public void AddQuest(QuestType type, int count)
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.DailyQuestData == null) return;
		var questData = userData.DailyQuestData;
		if (questData.Quests == null) return;
		int typeIdx = (int)type;
		for (int i = 0; i < questData.Quests.Count; i++)
		{
			var quest = questData.Quests[i];
			if (quest != null && quest.Idx == typeIdx)
			{
				quest.Value.Value += count;
				break;
			}
		}
	}

	public void AddQuest(QuestType type)
	{
		AddQuest(type, 1);
	}

	public void GetDailyReward(int reward, bool isWeekly)
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.DailyQuestData == null) return;
		var questData = userData.DailyQuestData;
		if (isWeekly)
		{
			if (questData.GetWeekRewards == null)
				questData.GetWeekRewards = new System.Collections.Generic.List<int>();
			if (!questData.GetWeekRewards.Contains(reward))
				questData.GetWeekRewards.Add(reward);
		}
		else
		{
			if (questData.GetDailyRewards == null)
				questData.GetDailyRewards = new System.Collections.Generic.List<int>();
			if (!questData.GetDailyRewards.Contains(reward))
				questData.GetDailyRewards.Add(reward);
		}
	}

	public void CompleteQuest(int quest)
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.DailyQuestData == null) return;
		var questData = userData.DailyQuestData;
		if (questData.CompleteQuests == null)
			questData.CompleteQuests = new System.Collections.Generic.List<int>();
		if (!questData.CompleteQuests.Contains(quest))
			questData.CompleteQuests.Add(quest);
	}

	private void ResetDailyQuest()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.DailyQuestData == null) return;
		var questData = userData.DailyQuestData;
		if (questData.CompleteQuests != null) questData.CompleteQuests.Clear();
		if (questData.GetDailyRewards != null) questData.GetDailyRewards.Clear();
		if (questData.Quests != null)
		{
			for (int i = 0; i < questData.Quests.Count; i++)
			{
				if (questData.Quests[i] != null && questData.Quests[i].Value != null)
					questData.Quests[i].Value.Value = 0;
			}
		}
		questData.DayPoint = 0;
		questData.QuestResetTime = DateTime.UtcNow.Date.AddDays(1);
	}

	private void ResetWeekQuest()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.DailyQuestData == null) return;
		var questData = userData.DailyQuestData;
		if (questData.GetWeekRewards != null) questData.GetWeekRewards.Clear();
		if (questData.GetWeekReplaces != null) questData.GetWeekReplaces.Clear();
		questData.WeekPoint = 0;
		questData.NextWeekResetTime = DateTime.UtcNow.Date.AddDays(7 - (int)DateTime.UtcNow.DayOfWeek);
	}
}
