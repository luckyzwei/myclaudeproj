using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemRewardGetGuide : MonoBehaviour
{
	private enum E_RewardGuideType
	{
		None = 0,
		Acq_WeeklyShop_Reinforce = 1,
		MoreEvent = 2,
		Acq_WeeklyShop_SkillStone = 3,
		Acq_Enter = 101,
		Acq_ManagerReset = 102,
		Acq_JewelryBox = 103,
		Acq_Battle_Normal = 201,
		Acq_Battle_Hard = 301,
		Acq_Pass_Open = 401,
		Acq_Pass_ShortCut = 402,
		Acq_Endless_1 = 403,
		Acq_Endless_2 = 404,
		Acq_AllInOne_1 = 405,
		Acq_AllInOne_2 = 406,
		Item_Dispatch = 501,
		Item_Seasonal = 502,
		Item_Acq_IdleReward = 503,
		Item_Package = 504,
		Item_DailyQuest = 505,
		Item_MissionMilestone = 506
	}

	[SerializeField]
	private Image GuideImage;

	[SerializeField]
	private Image GuideDecoImage;

	[SerializeField]
	private Text GuideDescText;

	[SerializeField]
	private GameObject ShortCutObj;

	[SerializeField]
	private Button ShortCutBtn;

	public int GuideIdx { get; private set; }

	private void Awake()
	{
		if (ShortCutBtn != null)
			ShortCutBtn.onClick.AddListener(OnClickShortCut);
	}

	public void SetGuideSlot(int guideIdx)
	{
		GuideIdx = guideIdx;
		if (ShortCutObj != null)
			ShortCutObj.SetActive(guideIdx > 0);
	}

	private void SetGuideIconImage(List<string> iconNameList)
	{
		// Set guide icon from icon name list
	}

	private void SetGuideDecoImage(string iconName)
	{
		// Set guide decoration image
	}

	private void SetGuideDescText(int guidIdx, string desc)
	{
		if (GuideDescText != null)
			GuideDescText.text = MakeGuideDescText(guidIdx, desc);
	}

	private string MakeGuideDescText(int guideIdx, string desc)
	{
		return desc ?? string.Empty;
	}

	private object[] GetShortCutArgs()
	{
		return new object[] { GuideIdx };
	}

	private void OnClickShortCut()
	{
		// Navigate to guide target via shortcut
	}
}
