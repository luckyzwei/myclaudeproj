using System.Collections.Generic;
using TextOutline;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupManagerList", false, false)]
public class PopupManagerList : UIBase
{
	private enum managerSortingType
	{
		none = -1,
		ability = 0,
		grade = 1
	}

	[Header("PopupManagerList")]
	[Header("Tap")]
	[SerializeField]
	private Toggle RewardTabToggle;

	[SerializeField]
	private Toggle ExpTabToggle;

	[SerializeField]
	private GameObject ManagerRoot;

	[Header("Info")]
	[SerializeField]
	private Button InfoBtn;

	[Space(5f)]
	[SerializeField]
	private Button ManagerHireBtn;

	[SerializeField]
	private Image ManagerImage;

	[SerializeField]
	private Image ManagerAbilityIcon;

	[SerializeField]
	private Text ManagerLevelName;

	[SerializeField]
	private Text ManagerAbilityDesc;

	[SerializeField]
	private Text ManagerAbilityValue;

	[Space(5f)]
	[SerializeField]
	private GameObject ManagerHireRoot;

	[SerializeField]
	private Image ManagerHireRegionIcon;

	[SerializeField]
	private Text ManagerHireText;

	[SerializeField]
	private CircleOutline ManagerHireOutLine;

	[Header("ManagerList")]
	[SerializeField]
	private ItemManagerCardMin ManagerMinItem;

	[SerializeField]
	private ScrollRect RewardScroll;

	[SerializeField]
	private ScrollRect ExpScroll;

	[Space(5f)]
	[SerializeField]
	private Button SortingBtn;

	[SerializeField]
	private Text SortingText;

	private Dictionary<int, ItemManagerCardMin> cardDic;

	private ManagerCardData CurCardData;

	private Config.ManagerCategory curTab;

	private managerSortingType curSort;

	public int CurOfficeIdx { get; set; }

	protected override void Awake()
	{
		base.Awake();
		cardDic = new Dictionary<int, ItemManagerCardMin>();
		curSort = managerSortingType.none;

		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfoBtn);
		if (ManagerHireBtn != null) ManagerHireBtn.onClick.AddListener(OnClickManagerHire);
		if (SortingBtn != null) SortingBtn.onClick.AddListener(OnClickSorting);

		if (RewardTabToggle != null)
			RewardTabToggle.onValueChanged.AddListener((isOn) => { if (isOn) OnClickChangeTab(Config.ManagerCategory.Office); });
		if (ExpTabToggle != null)
			ExpTabToggle.onValueChanged.AddListener((isOn) => { if (isOn) OnClickChangeTab(Config.ManagerCategory.Factory); });
	}

	public override void OnShowBefore()
	{
		curTab = Config.ManagerCategory.Office;
		UpdateList();
	}

	private void OnClickChangeTab(Config.ManagerCategory tab)
	{
		curTab = tab;
		if (RewardScroll != null) RewardScroll.gameObject.SetActive(tab == Config.ManagerCategory.Office);
		if (ExpScroll != null) ExpScroll.gameObject.SetActive(tab == Config.ManagerCategory.Factory);
		UpdateList();
	}

	private void OnClickManagerHire()
	{
		Hide();
	}

	private void OnClickSorting()
	{
		if (curSort == managerSortingType.ability)
			SetSort(managerSortingType.grade);
		else
			SetSort(managerSortingType.ability);
	}

	private void OnClickInfoBtn()
	{
		// Handle click
	}

	public void UpdateList()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public void SelectManager(int managerIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (ManagerRoot != null) ManagerRoot.SetActive(true);
	}

	private void SetSort(managerSortingType type)
	{
		curSort = type;
		UpdateList();
	}
}
