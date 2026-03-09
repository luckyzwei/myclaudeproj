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
	}

	public void RegisterActiveProgressRewardWidget(ProgressRewardWidget progressRewardWidget)
	{
	}

	public void DeRegisterActivateProgressRewardWidget(ProgressRewardWidget progressRewardWidget)
	{
	}

	public ProgressRewardWidget GetActiveProgressRewardWidget(string progressWidgetID)
	{
		return null;
	}

	private void UpdateInventory(Item item, int count, int slotIndex)
	{
	}

	private void UpdateProgressRewardData(string itemID, int count)
	{
	}

	public bool IsWidgetEnabled(string widgetID)
	{
		return false;
	}

	public bool IsWidgetUnlocked(string widgetID)
	{
		return false;
	}

	public void OverrideProgressRewardProfile(string progressRewardID, int progress = -1, int visualProgress = -1)
	{
	}

	public void ResetProgressRewardWidgetProfile(string widgetID, long progressValue = 0L)
	{
	}

	public ProgressRewardMilestone[] GetBalancyCurrentProgressRewardMilestones(string widgetID)
	{
		return null;
	}

	public ProgressReward GetBalancyCurrentProgressReward(string widgetID)
	{
		return null;
	}

	public ProgressRewardSaveData GetBalancyProgressRewardSaveData(string widgetID)
	{
		return null;
	}

	public Balancy.Models.KWProgressReward.ProgressRewardWidget GetBalancyProgressRewardWidget(string widgetID)
	{
		return null;
	}

	public void GiveProgressPoint(string widgetID, int amount = 1)
	{
	}

	public int CalculateTotalProgressRequirement(string widgetID)
	{
		return 0;
	}
}
