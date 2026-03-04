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

	public ItemMissionTab GetMissionTab { get { return null; } }

	public void Init(Tab openTab = Tab.None)
	{
	}

	private int GetInitTabIndex(Tab openTab, bool isDailyQuestOpen, bool isFactoryMode)
	{
		return 0;
	}

	private void SetHudTopInfo(int region)
	{
	}

	private void OnTabChanged(int index)
	{
	}

	private void OnGoNavi()
	{
	}

	public override void Hide()
	{
	}

	private void OnDestroy()
	{
	}

	public TabToggleGroup GetTabToggleGroup()
	{
		return null;
	}
}
