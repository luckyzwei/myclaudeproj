using Treeplla;
using UniRx;
using UnityEngine;

public class TutorialEntityWaitUIBase : TutorialEntity
{
	public enum UIBaseType
	{
		PopupOfficeUpgrade = 0,
		PopupCompanyList = 1,
		PopupCompanyInfo = 2,
		PopupMission = 3,
		PageCompanyLevelUp = 4,
		PopupAdsupply = 5,
		PopupCompanyRecontract = 6,
		PopupOfficeOpen = 7,
		PopupFactoryWorkPlace = 8,
		PopupFactoryOrder = 9,
		PageReward = 10,
		PageLoading = 11,
		PageShop = 12,
		PageGacha = 13,
		PageManagerHireList = 14,
		PageManager = 15,
		PopupManagerInfo = 16,
		PageManagerInfo = 17,
		PopupManagerOfficeHire = 18,
		PopupItemProduction = 19,
		PopupDockList = 20,
		PageSeasonalSlotmachine = 21,
		PageMilestone = 22,
		PopupSkills = 23,
		PopupMilestoneReward = 24,
		PopupToastmessageStrike = 25,
		PageOfficeManagement = 26,
		PageRichPointInfo = 27,
		PageAcquisitionMain = 28,
		PageAcquisitionStart = 29,
		PopupHouseSale = 30,
		PageConversation = 31,
		PopupExpAccelerate = 32,
		PopupFactoryItemUse = 33
	}

	[SerializeField]
	private UIBaseType uiBaseType;

	[SerializeField]
	private bool showWait;

	[SerializeField]
	private bool openskip;

	private UIBase uiBase;

	public override void StartEntity()
	{
		base.StartEntity();
		if (showWait)
		{
			// Show waiting indicator
		}
		Wait();
	}

	private void Wait()
	{
		// Wait for the specified UI to open, then mark done
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;

		// Poll for the UIBase to become active
		Observable.EveryUpdate().Subscribe(_ =>
		{
			// Check if the target UI is active/open
			// When UI is detected, mark entity as done
			if (uiBase != null && uiBase.gameObject.activeSelf)
			{
				Done();
			}
		}).AddTo(this);
	}

	private void OnDestroy()
	{
		uiBase = null;
	}
}
