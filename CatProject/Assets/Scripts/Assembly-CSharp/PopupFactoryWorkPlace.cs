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
		base.Awake();
		need_disposables = new CompositeDisposable();
		battery_disposables = new CompositeDisposable();
		ProductItems = new List<ItemFactoryProduct>();
		SelectProduct = 0;

		if (SelectBtn != null) SelectBtn.onClick.AddListener(OnClickMakeSelect);
		if (DeSelectBtn != null) DeSelectBtn.onClick.AddListener(() => OnClickMakeSelect());
		if (UpgradeBtn != null) UpgradeBtn.onClick.AddListener(OnClickUpgrade);
		if (UseItemBtn != null) UseItemBtn.onClick.AddListener(OnClickUseItem);
		if (MoveBeforeBtn != null) MoveBeforeBtn.onClick.AddListener(OnClickPrevMove);
		if (MoveAfterBtn != null) MoveAfterBtn.onClick.AddListener(OnClickNextMove);
		if (RecipeBtn != null) RecipeBtn.onClick.AddListener(OnClickRecipe);
		if (SelectNeedShortCutBtn != null) SelectNeedShortCutBtn.onClick.AddListener(() => OnClickSelectNeedShortCut(0));
		if (SelectNeedShortCutBtn2 != null) SelectNeedShortCutBtn2.onClick.AddListener(() => OnClickSelectNeedShortCut(1));
	}

	private void Update()
	{
		UpdateUseBattery();
	}

	public void Set(int idx, Tab tab = Tab.Product)
	{
		FactoryIdx = idx;
		SelectProduct = 0;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;

		if (FactoryName != null) FactoryName.text = "";
		UpdateList();
		UpdateSelectItem();
		UpdateUpgrade();
		UpdateMoveBtn();
		UpdateBattery();
		ChangeTab(tab);
	}

	public void ChangeTab(Tab tab)
	{
		if (ProductRoot != null) ProductRoot.SetActive(tab == Tab.Product);
		if (UpgradeRoot != null) UpgradeRoot.SetActive(tab == Tab.Upgrade);
	}

	public void ShowProductGuideArrow(int productIdx)
	{
		GuideProductIdx = productIdx;
		if (ProductGuideArrow != null) ProductGuideArrow.SetActive(true);
	}

	public void HideProductGuideArrow()
	{
		if (ProductGuideArrow != null) ProductGuideArrow.SetActive(false);
	}

	public void ShowUpgradeGuideArrow(bool bShow)
	{
		if (UpgradeGuideArrow != null) UpgradeGuideArrow.SetActive(bShow);
	}

	public override void OnHideAfter()
	{
		HideProductGuideArrow();
		ShowUpgradeGuideArrow(false);
	}

	private void UpdateMoveBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
		// Determine previous/next factory indices
		if (MoveBeforeBtn != null) MoveBeforeBtn.gameObject.SetActive(PrevFactoryIdx >= 0);
		if (MoveAfterBtn != null) MoveAfterBtn.gameObject.SetActive(NextFactoryIdx >= 0);
	}

	private void UpdateBattery()
	{
		if (BatteryRoot == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null) { BatteryRoot.SetActive(false); return; }
		// Check if factory has battery boost active
		BatteryRoot.SetActive(false);
	}

	private void UpdateUseBattery()
	{
		// Update battery progress timer each frame
		if (BatteryRemainTime == null || BatteryRoot == null || !BatteryRoot.activeSelf) return;
	}

	private void UpdateList()
	{
		if (ProductItems == null) ProductItems = new List<ItemFactoryProduct>();
		// Populate product item list from factory data
		if (NewProductRedDotObj != null) NewProductRedDotObj.SetActive(false);
	}

	private void ShowUnlockProducts()
	{
	}

	private void UpdateSelectItem()
	{
		if (ProductItems == null) return;
		// Update selected product info
		UpdateNeedProduct();
	}

	private void UpdateNeedProduct()
	{
		if (need_disposables != null)
		{
			need_disposables.Dispose();
			need_disposables = new CompositeDisposable();
		}
		// Show needed materials for selected product
		bool hasNeeds = false;
		if (SelectNeedObj != null) SelectNeedObj.SetActive(hasNeeds);
		if (SelectNeedNothing != null) SelectNeedNothing.SetActive(!hasNeeds);
	}

	private void UpdateUpgrade()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
		// Update factory upgrade UI
		bool isMaxLevel = false;
		if (UpgradeNeedObj != null) UpgradeNeedObj.SetActive(!isMaxLevel);
		if (UpgradeMaxObj != null) UpgradeMaxObj.SetActive(isMaxLevel);
		if (UpgradeMaxBtn != null) UpgradeMaxBtn.SetActive(isMaxLevel);
	}

	private void UpdateNeedLack(bool isLack)
	{
		if (SelectNeedBG != null)
			SelectNeedBG.color = isLack ? Color.red : Color.white;
	}

	private void OnClickSelectItem(int product)
	{
		SelectProduct = product;
		UpdateSelectItem();
	}

	private void OnClickMakeSelect()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
		UpdateSelectItem();
	}

	private void OnClickUpgrade()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
		UpdateUpgrade();
		UpdateList();
	}

	private void OnClickUseItem()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void GotoFactory(int idx)
	{
		FactoryIdx = idx;
		Set(idx);
	}

	private void OnClickNextMove()
	{
		if (NextFactoryIdx >= 0) GotoFactory(NextFactoryIdx);
	}

	private void OnClickPrevMove()
	{
		if (PrevFactoryIdx >= 0) GotoFactory(PrevFactoryIdx);
	}

	private void OnClickRecipe()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickSelectNeedShortCut(int idx)
	{
		// Navigate to the needed material's factory
		Hide();
	}

	private void OnDestroy()
	{
		if (need_disposables != null)
		{
			need_disposables.Dispose();
			need_disposables = null;
		}
		if (battery_disposables != null)
		{
			battery_disposables.Dispose();
			battery_disposables = null;
		}
	}

	private void OnDisable()
	{
		if (need_disposables != null)
		{
			need_disposables.Dispose();
			need_disposables = new CompositeDisposable();
		}
		if (battery_disposables != null)
		{
			battery_disposables.Dispose();
			battery_disposables = new CompositeDisposable();
		}
	}
}
