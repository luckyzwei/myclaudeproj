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
	}

	public void UpdateOneSeconds()
	{
	}

	private void SubscribeQuest(int order)
	{
	}

	public void AddQuest(QuestType type, int count)
	{
	}

	public void AddQuest(QuestType type)
	{
	}

	public void GetDailyReward(int reward, bool isWeekly)
	{
	}

	public void CompleteQuest(int quest)
	{
	}

	private void ResetDailyQuest()
	{
	}

	private void ResetWeekQuest()
	{
	}
}
