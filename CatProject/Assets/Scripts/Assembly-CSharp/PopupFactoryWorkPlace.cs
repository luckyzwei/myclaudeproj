using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupFactoryWorkPlace", false, false)]
public class PopupFactoryWorkPlace : UIBase
{
	public enum Tab
	{
		None = -1,
		Product = 0,
		Upgrade = 1
	}

	[SerializeField]
	private Text FactoryName;

	[SerializeField]
	private Text FactoryLevel;

	[SerializeField]
	private Slider FactoryLevelProgress;

	[SerializeField]
	private TabToggleGroup TabGroup;

	[SerializeField]
	private GameObject ProductRoot;

	[SerializeField]
	private GameObject UpgradeRoot;

	[SerializeField]
	private Button UseItemBtn;

	[SerializeField]
	private GameObject StorageFullNotiObj;

	[Header("SelectProduct")]
	[SerializeField]
	private Text SelectName;

	[SerializeField]
	private Text SelectDesc;

	[SerializeField]
	private Image SelectImg;

	[SerializeField]
	private Image SelectNeedBG;

	[SerializeField]
	private Text SelectNeedStr;

	[SerializeField]
	private Image SelectNeedItem;

	[SerializeField]
	private Text SelectNeedCount;

	[SerializeField]
	private Button SelectNeedShortCutBtn;

	[SerializeField]
	private Image SelectNeedItem2;

	[SerializeField]
	private Text SelectNeedCount2;

	[SerializeField]
	private Button SelectNeedShortCutBtn2;

	[SerializeField]
	private GameObject SelectNeedObj;

	[SerializeField]
	private GameObject SelectNeedNothing;

	[SerializeField]
	private Button SelectBtn;

	[SerializeField]
	private Button DeSelectBtn;

	[SerializeField]
	private Button RecipeBtn;

	[Header("List")]
	[SerializeField]
	private ScrollRect ProductScrollRect;

	[SerializeField]
	private GameObject ProductItem;

	[SerializeField]
	private GameObject ProductGuideArrow;

	[Header("Upgrade")]
	[SerializeField]
	private Text UpgradeLevelText;

	[SerializeField]
	private Text UpgradeMakeTypeCountText;

	[SerializeField]
	private Text UpgradeMakeAddText;

	[SerializeField]
	private Text UpgradeCostText;

	[SerializeField]
	private GameObject UpgradeNeedObj;

	[SerializeField]
	private GameObject UpgradeMaxObj;

	[SerializeField]
	private GameObject UpgradeMaxBtn;

	[SerializeField]
	private Button UpgradeBtn;

	[SerializeField]
	private GameObject UpgradeGuideArrow;

	[Header("Battery")]
	[SerializeField]
	private GameObject BatteryRoot;

	[SerializeField]
	private Text BatteryBuff;

	[SerializeField]
	private Slider BatteryProgress;

	[SerializeField]
	private Text BatteryRemainTime;

	[SerializeField]
	private Image BatteryIcon;

	[Header("Etc")]
	[SerializeField]
	private Button MoveBeforeBtn;

	[SerializeField]
	private Button MoveAfterBtn;

	[SerializeField]
	private GameObject NewProductRedDotObj;

	private List<ItemFactoryProduct> ProductItems;

	private int FactoryIdx;

	private int SelectProduct;

	private int PrevFactoryIdx;

	private int NextFactoryIdx;

	private GameObject GuideItem;

	private int GuideProductIdx;

	private CompositeDisposable need_disposables;

	private CompositeDisposable battery_disposables;

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	public void Set(int idx, Tab tab = Tab.Product)
	{
	}

	public void ChangeTab(Tab tab)
	{
	}

	public void ShowProductGuideArrow(int productIdx)
	{
	}

	public void HideProductGuideArrow()
	{
	}

	public void ShowUpgradeGuideArrow(bool bShow)
	{
	}

	public override void OnHideAfter()
	{
	}

	private void UpdateMoveBtn()
	{
	}

	private void UpdateBattery()
	{
	}

	private void UpdateUseBattery()
	{
	}

	private void UpdateList()
	{
	}

	private void ShowUnlockProducts()
	{
	}

	private void UpdateSelectItem()
	{
	}

	private void UpdateNeedProduct()
	{
	}

	private void UpdateUpgrade()
	{
	}

	private void UpdateNeedLack(bool isLack)
	{
	}

	private void OnClickSelectItem(int product)
	{
	}

	private void OnClickMakeSelect()
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickUseItem()
	{
	}

	private void GotoFactory(int idx)
	{
	}

	private void OnClickNextMove()
	{
	}

	private void OnClickPrevMove()
	{
	}

	private void OnClickRecipe()
	{
	}

	private void OnClickSelectNeedShortCut(int idx)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
