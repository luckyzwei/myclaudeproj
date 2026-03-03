using Treeplla;
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
	}

	private void Wait()
	{
	}

	private void OnDestroy()
	{
	}
}
