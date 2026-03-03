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
	}

	public override void OnShowBefore()
	{
	}

	private void OnClickChangeTab(Config.ManagerCategory tab)
	{
	}

	private void OnClickManagerHire()
	{
	}

	private void OnClickSorting()
	{
	}

	private void OnClickInfoBtn()
	{
	}

	public void UpdateList()
	{
	}

	public void SelectManager(int managerIdx)
	{
	}

	private void SetSort(managerSortingType type)
	{
	}
}
