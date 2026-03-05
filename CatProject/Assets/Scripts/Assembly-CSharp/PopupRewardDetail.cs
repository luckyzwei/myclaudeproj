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
		base.Awake();
		ItemArticleList = new List<ItemArticle>();
		if (MissionMilestoneShortcutBtn != null)
			MissionMilestoneShortcutBtn.onClick.AddListener(OnClickMissionMilestoneShortcut);
	}

	private void InitPopup()
	{
		// Clear existing items
		if (ItemArticleList != null) ItemArticleList.Clear();
		if (BuffRoot != null) BuffRoot.SetActive(false);
		if (CompanyRoot != null) CompanyRoot.SetActive(false);
		if (ShortcutRoot != null) ShortcutRoot.SetActive(false);
		if (BottomDescText != null) BottomDescText.gameObject.SetActive(false);
	}

	public void ShowShortcut()
	{
		if (ShortcutRoot != null) ShortcutRoot.SetActive(true);
	}

	public void SetDailyReward(int idx)
	{
		InitPopup();
		// Set daily reward item display based on idx
	}

	public void SetPiggyReward(int level)
	{
		InitPopup();
		// Set piggy bank reward display for given level
	}

	public void SetRouletteReward(int order)
	{
		InitPopup();
		// Set roulette reward display for given order
	}

	public void SetManagerBox(int goodsIdx)
	{
		InitPopup();
		// Set manager box reward display
	}

	public void SetReward(RewardItemData rewardItemData)
	{
		InitPopup();
		if (rewardItemData == null) return;
		SetBuffArea(rewardItemData.rewardIdx);
	}

	public void SetPlant(int plantidx)
	{
		InitPopup();
		// Set plant reward display
	}

	public void SetBuffObject(int objIdx)
	{
		InitPopup();
		SetBuffAreaForObject(objIdx);
	}

	public void SetCompany(int companyIdx)
	{
		InitPopup();
		SetCompanyArea(companyIdx);
	}

	public void SetCar(int carIdx)
	{
		InitPopup();
		SetCarArea(carIdx);
	}

	public void SetItem(int itemIdx)
	{
		InitPopup();
		SetItemArea(itemIdx);
	}

	public void SetTarotTicket(int tarotTicketIdx)
	{
		InitPopup();
		SetTarotTicketArea(tarotTicketIdx);
	}

	public void SetManagerCard(int rewardIdx)
	{
		InitPopup();
		SetManagerCardArea(rewardIdx);
	}

	public void SetCeoCostume(int rewardIdx, string iconPath)
	{
		InitPopup();
		SetCeoCostumeArea(rewardIdx);
	}

	public void SetSimpleReward(List<IRewardItemData> rewardItemDataList)
	{
		InitPopup();
		if (rewardItemDataList == null || Root == null || Item == null) return;
		for (int i = 0; i < rewardItemDataList.Count; i++)
		{
			var go = Object.Instantiate(Item, Root);
			go.SetActive(true);
			var article = go.GetComponent<ItemArticle>();
			if (article != null)
			{
				article.Set(rewardItemDataList[i]);
				ItemArticleList.Add(article);
			}
		}
	}

	private void SetBuffArea(int idx)
	{
		if (BuffRoot == null) return;
		BuffRoot.SetActive(true);
		// Set buff icon and description from buff table
	}

	private void SetBuffAreaForObject(int idx)
	{
		if (BuffRoot == null) return;
		BuffRoot.SetActive(true);
		// Set buff area for buff object
	}

	private void SetCompanyArea(int idx)
	{
		if (CompanyRoot == null) return;
		CompanyRoot.SetActive(true);
		// Set company name, grade, region from table
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	private void SetCarArea(int idx)
	{
		// Set car info display
	}

	private void SetItemArea(int idx)
	{
		// Set item info display
	}

	private void SetTarotTicketArea(int idx)
	{
		// Set tarot ticket info display
	}

	private void SetManagerCardArea(int managerGrade)
	{
		// Set manager card info by grade
	}

	private void SetCeoCostumeArea(int rewardIdx)
	{
		// Set CEO costume preview
	}

	public void SetTopTitleText(string tarotStr)
	{
		if (TopTitleText != null) TopTitleText.text = tarotStr;
	}

	private void OnClickMissionMilestoneShortcut()
	{
		// Navigate to mission milestone page
		Hide();
	}
}
