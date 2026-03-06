using System;
using Treeplla;
using UnityEngine;

[UIPath("UI/Popup/PopupMission", false, false)]
public class PopupMission : UIBase, ITabToggleGroup
{
	public enum Tab
	{
		None = -1,
		Mission = 0,
		Factory = 1,
		DailyQuest = 2
	}

	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private TabToggleGroup MainTabToggleGroup;

	[SerializeField]
	private ItemMissionTab MissionTab;

	[SerializeField]
	private ItemDailyQuestTab DailyQuestTab;

	[SerializeField]
	private ItemMissionFactoryTab FactoryTab;

	public Action OnGoNaviHide;

	public ItemMissionTab GetMissionTab { get { return MissionTab; } }

	public void Init(Tab openTab = Tab.None)
	{
		if (HUDTopInfo != null) HUDTopInfo.UpdateCurrencyInfos();
		var root = Singleton<GameRoot>.Instance;
		bool isDailyQuestOpen = root != null && root.ContentsOpenSystem != null;
		bool isFactoryMode = root != null && root.FactorySystem != null;
		int initTab = GetInitTabIndex(openTab, isDailyQuestOpen, isFactoryMode);
		if (MainTabToggleGroup != null)
		{
			MainTabToggleGroup.OnTabChanged = OnTabChanged;
			MainTabToggleGroup.ChangeTab(initTab);
		}
	}

	private int GetInitTabIndex(Tab openTab, bool isDailyQuestOpen, bool isFactoryMode)
	{
		if (openTab != Tab.None) return (int)openTab;
		return (int)Tab.Mission;
	}

	private void SetHudTopInfo(int region)
	{
		if (HUDTopInfo != null) HUDTopInfo.UpdateCurrencyInfos();
	}

	private void OnTabChanged(int index)
	{
		// TODO
	}

	private void OnGoNavi()
	{
		OnGoNaviHide?.Invoke();
		Hide();
	}

	public override void Hide()
	{
		base.Hide();
	}

	private void OnDestroy()
	{
		OnGoNaviHide = null;
	}

	public TabToggleGroup GetTabToggleGroup()
	{
		return MainTabToggleGroup;
	}
}
