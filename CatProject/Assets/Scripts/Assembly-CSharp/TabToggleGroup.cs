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
		base.Awake();
		TabToggleTabs = new List<ITabToggleTab>();
		if (Toggles != null)
		{
			for (int i = 0; i < Toggles.Count; i++)
			{
				int idx = i;
				if (Toggles[i] != null)
					Toggles[i].onValueChanged.AddListener((isOn) => OnValueChanged(idx, isOn));
			}
		}
	}

	protected override void OnDisable()
	{
		base.OnDisable();
	}

	public void ChangeTab(int index)
	{
		if (Toggles == null || index < 0 || index >= Toggles.Count) return;
		PauseUpdate = true;
		for (int i = 0; i < Toggles.Count; i++)
		{
			if (Toggles[i] != null)
				Toggles[i].isOn = (i == index);
		}
		PauseUpdate = false;
		OnValueChanged(index, true);
	}

	private void OnValueChanged(int index, bool isOn)
	{
		if (PauseUpdate) return;
		if (!isOn) return;
		if (TabContents != null)
		{
			for (int i = 0; i < TabContents.Count; i++)
			{
				if (TabContents[i] != null)
					TabContents[i].SetActive(i == index);
			}
		}
		OnTabChanged?.Invoke(index);
	}

	public void SetInteractableToggle(int index, bool isEnable)
	{
		if (Toggles == null || index < 0 || index >= Toggles.Count) return;
		if (Toggles[index] != null)
			Toggles[index].interactable = isEnable;
	}

	public void SetActiveToggle(int index, bool isActive)
	{
		if (Toggles == null || index < 0 || index >= Toggles.Count) return;
		if (Toggles[index] != null)
			Toggles[index].gameObject.SetActive(isActive);
	}

	public int GetActiveIndex()
	{
		if (Toggles == null) return 0;
		for (int i = 0; i < Toggles.Count; i++)
		{
			if (Toggles[i] != null && Toggles[i].isOn)
				return i;
		}
		return 0;
	}

	public GameObject GetActiveTabContent()
	{
		int idx = GetActiveIndex();
		if (TabContents != null && idx >= 0 && idx < TabContents.Count)
			return TabContents[idx];
		return null;
	}

	public List<ITabToggleTab> GetTabToggleTabs()
	{
		return TabToggleTabs;
	}

	public void RefreshActiveTab()
	{
		int idx = GetActiveIndex();
		OnValueChanged(idx, true);
	}

	public void ResetTabToggleTabs()
	{
		if (TabToggleTabs != null) TabToggleTabs.Clear();
	}

	public static void ChangeTab<T>(int index) where T : UIBase
	{
	}
}
