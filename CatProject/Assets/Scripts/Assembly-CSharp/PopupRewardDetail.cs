using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRewardDetail", false, false)]
public class PopupRewardDetail : UIBase
{
	[SerializeField]
	private Transform Root;

	[SerializeField]
	private GameObject Item;

	[Space(5f)]
	[SerializeField]
	private GameObject BuffRoot;

	[SerializeField]
	private Image BuffIcon;

	[SerializeField]
	private Text BuffDesc;

	[Space(5f)]
	[SerializeField]
	private Text CompanyName;

	[SerializeField]
	private GameObject CompanyRoot;

	[SerializeField]
	private Text CompanyRegion;

	[SerializeField]
	private Image CompanyGradeBG;

	[SerializeField]
	private Text CompanyGrade;

	[SerializeField]
	private GameObject CompanySpecialObj;

	[Space(5f)]
	[SerializeField]
	private Text BottomDescText;

	[Space(5f)]
	[SerializeField]
	private Text TopTitleText;

	[Header("Shortcut")]
	[SerializeField]
	private GameObject ShortcutRoot;

	[SerializeField]
	private Button MissionMilestoneShortcutBtn;

	private List<ItemArticle> ItemArticleList;

	protected override void Awake()
	{
	}

	private void InitPopup()
	{
	}

	public void ShowShortcut()
	{
	}

	public void SetDailyReward(int idx)
	{
	}

	public void SetPiggyReward(int level)
	{
	}

	public void SetRouletteReward(int order)
	{
	}

	public void SetManagerBox(int goodsIdx)
	{
	}

	public void SetReward(RewardItemData rewardItemData)
	{
	}

	public void SetPlant(int plantidx)
	{
	}

	public void SetBuffObject(int objIdx)
	{
	}

	public void SetCompany(int companyIdx)
	{
	}

	public void SetCar(int carIdx)
	{
	}

	public void SetItem(int itemIdx)
	{
	}

	public void SetTarotTicket(int tarotTicketIdx)
	{
	}

	public void SetManagerCard(int rewardIdx)
	{
	}

	public void SetCeoCostume(int rewardIdx, string iconPath)
	{
	}

	public void SetSimpleReward(List<IRewardItemData> rewardItemDataList)
	{
	}

	private void SetBuffArea(int idx)
	{
	}

	private void SetBuffAreaForObject(int idx)
	{
	}

	private void SetCompanyArea(int idx)
	{
	}

	private void SetCarArea(int idx)
	{
	}

	private void SetItemArea(int idx)
	{
	}

	private void SetTarotTicketArea(int idx)
	{
	}

	private void SetManagerCardArea(int managerGrade)
	{
	}

	private void SetCeoCostumeArea(int rewardIdx)
	{
	}

	public void SetTopTitleText(string tarotStr)
	{
	}

	private void OnClickMissionMilestoneShortcut()
	{
	}
}
