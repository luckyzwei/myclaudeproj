using System;
using UniRx;

public class EventData : IClientData
{
	public IReactiveProperty<bool> PremiumPassProperty;

	public IReactiveProperty<int> MissionOrderProperty;

	public int EventIdx { get; set; }

	public int EventTheme { get; set; }

	public bool RapidCatPackageShown { get; set; }

	public bool RapidCatPurchaseCheck { get; set; }

	public bool buyContinue { get; set; }

	public bool StartBoostShown { get; set; }

	public bool continuityPageShown { get; set; }

	public bool newMapEventNoti { get; set; }

	public bool isWeekInit { get; set; }

	public int LastEnterStageMapEventIdx { get; set; }

	public bool lastEventClearPopup { get; set; }

	public bool weekFirstEventRemaining { get; set; }

	public DateTime EventStaffShowTime { get; set; }

	public DateTime EventStaffAdTime { get; set; }

	public void SetEventIdx(int idx, int theme, bool isClear, bool isNextEventClear)
	{
		// Update display
	}
}
