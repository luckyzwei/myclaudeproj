using System;
using System.Collections.Generic;
using Balancy.Data;
using Balancy.Models.KWProgressReward;
using Balancy.Models.SmartObjects;
using KWCore.Utils;

public class ProgressRewardManager : MonoSingleton<ProgressRewardManager>
{
	private List<ProgressRewardWidget> m_activeProgressRewardWidgets;

	public Action progressRewardUpdated;

	protected override void Init()
	{
		m_activeProgressRewardWidgets = new List<ProgressRewardWidget>();
	}

	public void RegisterActiveProgressRewardWidget(ProgressRewardWidget progressRewardWidget)
	{
		if (progressRewardWidget != null && !m_activeProgressRewardWidgets.Contains(progressRewardWidget))
		{
			m_activeProgressRewardWidgets.Add(progressRewardWidget);
		}
	}

	public void DeRegisterActivateProgressRewardWidget(ProgressRewardWidget progressRewardWidget)
	{
		if (progressRewardWidget != null)
		{
			m_activeProgressRewardWidgets.Remove(progressRewardWidget);
		}
	}

	public ProgressRewardWidget GetActiveProgressRewardWidget(string progressWidgetID)
	{
		if (m_activeProgressRewardWidgets == null)
			return null;

		for (int i = 0; i < m_activeProgressRewardWidgets.Count; i++)
		{
			if (m_activeProgressRewardWidgets[i] != null &&
				m_activeProgressRewardWidgets[i].WidgetID == progressWidgetID)
			{
				return m_activeProgressRewardWidgets[i];
			}
		}
		return null;
	}

	private void UpdateInventory(Item item, int count, int slotIndex)
	{
	}

	private void UpdateProgressRewardData(string itemID, int count)
	{
		progressRewardUpdated?.Invoke();
	}

	public bool IsWidgetEnabled(string widgetID)
	{
		var widget = GetBalancyProgressRewardWidget(widgetID);
		return widget != null;
	}

	public bool IsWidgetUnlocked(string widgetID)
	{
		var saveData = GetBalancyProgressRewardSaveData(widgetID);
		return saveData != null;
	}

	public void OverrideProgressRewardProfile(string progressRewardID, int progress = -1, int visualProgress = -1)
	{
	}

	public void ResetProgressRewardWidgetProfile(string widgetID, long progressValue = 0L)
	{
	}

	public ProgressRewardMilestone[] GetBalancyCurrentProgressRewardMilestones(string widgetID)
	{
		// Requires Balancy runtime data - returns null until Balancy is initialized
		return null;
	}

	public ProgressReward GetBalancyCurrentProgressReward(string widgetID)
	{
		// Requires Balancy runtime data
		return null;
	}

	public ProgressRewardSaveData GetBalancyProgressRewardSaveData(string widgetID)
	{
		// Requires Balancy runtime data
		return null;
	}

	public Balancy.Models.KWProgressReward.ProgressRewardWidget GetBalancyProgressRewardWidget(string widgetID)
	{
		// Requires Balancy runtime data
		return null;
	}

	public void GiveProgressPoint(string widgetID, int amount = 1)
	{
		progressRewardUpdated?.Invoke();
	}

	public int CalculateTotalProgressRequirement(string widgetID)
	{
		return 0;
	}
}
