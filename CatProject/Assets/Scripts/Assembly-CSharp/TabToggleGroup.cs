using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class TabToggleGroup : ToggleGroup
{
	[SerializeField]
	private List<GameObject> TabContents;

	[SerializeField]
	private List<Toggle> Toggles;

	private List<ITabToggleTab> TabToggleTabs;

	public Action<int> OnTabChanged;

	private bool PauseUpdate;

	protected override void Awake()
	{
	}

	protected override void OnDisable()
	{
	}

	public void ChangeTab(int index)
	{
	}

	private void OnValueChanged(int index, bool isOn)
	{
	}

	public void SetInteractableToggle(int index, bool isEnable)
	{
	}

	public void SetActiveToggle(int index, bool isActive)
	{
	}

	public int GetActiveIndex()
	{
		return 0;
	}

	public GameObject GetActiveTabContent()
	{
		return null;
	}

	public List<ITabToggleTab> GetTabToggleTabs()
	{
		return null;
	}

	public void RefreshActiveTab()
	{
	}

	public void ResetTabToggleTabs()
	{
	}

	public static void ChangeTab<T>(int index) where T : UIBase
	{
	}
}
