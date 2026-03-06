using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupFactoryStorage", false, false)]
public class PopupFactoryStorage : UIBase
{
	public enum Tab
	{
		Storage = 0,
		Upgrade = 1
	}

	[SerializeField]
	private TabToggleGroup TabGroup;

	[SerializeField]
	private Text StorageCount;

	[SerializeField]
	private Slider StorageProgress;

	[SerializeField]
	private Button ProcessBtn;

	[SerializeField]
	private Text StorageLevel;

	[SerializeField]
	private Slider StorageLevelProgress;

	[Header("SelectProduct")]
	[SerializeField]
	private Text SelectName;

	[SerializeField]
	private Text SelectDesc;

	[SerializeField]
	private Image SelectImg;

	[SerializeField]
	private Text SelectCount;

	[SerializeField]
	private Button ThrowBtn;

	[SerializeField]
	private GameObject NothingObj;

	[SerializeField]
	private GameObject SelectInfoObj;

	[Header("List")]
	[SerializeField]
	private Transform ListRoot;

	[SerializeField]
	private GameObject ProductItem;

	[Header("Upgrade")]
	[SerializeField]
	private Text UpgradeLevelText;

	[SerializeField]
	private Text UpgradeLimitText;

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

	[Header("Etc")]
	[SerializeField]
	private GameObject StorageLvUpNotiObj;

	[SerializeField]
	private GameObject StorageFullNotiObj;

	private int StorageIdx;

	private int SelectProduct;

	private bool IsMaxLevel;

	private CompositeDisposable storage_disposables;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		storage_disposables = new CompositeDisposable();

		if (ProcessBtn != null) ProcessBtn.onClick.AddListener(OnClickProcess);
		if (ThrowBtn != null) ThrowBtn.onClick.AddListener(OnClickOrganize);
		if (UpgradeBtn != null) UpgradeBtn.onClick.AddListener(OnClickUpgrade);
	}

	public void Init(Tab openTab = Tab.Storage)
	{
		SelectProduct = -1;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateList();
		UpdateUpgrade();
		UpdateSelectItem();

		if (TabGroup != null)
			TabGroup.ChangeTab((int)openTab);
	}

	public void ShowUpgradeGuideArrow(bool bShow)
	{
		if (UpgradeGuideArrow != null) UpgradeGuideArrow.SetActive(bShow);
	}

	private void UpdateList()
	{
	}

	private void ListActiveCallback()
	{
		UpdateSelectItem();
	}

	private void UpdateUpgrade()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (UpgradeMaxObj != null) UpgradeMaxObj.SetActive(IsMaxLevel);
		if (UpgradeNeedObj != null) UpgradeNeedObj.SetActive(!IsMaxLevel);

		if (StorageLvUpNotiObj != null) StorageLvUpNotiObj.SetActive(false);
	}

	private void UpdateSelectItem()
	{
		bool hasSelect = SelectProduct >= 0;
		if (NothingObj != null) NothingObj.SetActive(!hasSelect);
		if (SelectInfoObj != null) SelectInfoObj.SetActive(hasSelect);
	}

	private void OnClickSelectItem(int product)
	{
		SelectProduct = product;
		UpdateSelectItem();
	}

	private void OnClickUpgrade()
	{
		if (IsMaxLevel) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateUpgrade();
	}

	private void OnClickOrganize()
	{
		if (SelectProduct < 0) return;
		SelectProduct = -1;
		UpdateList();
		UpdateSelectItem();
	}

	private void OnClickProcess()
	{
		Hide();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
		if (storage_disposables != null) { storage_disposables.Dispose(); storage_disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
		if (storage_disposables != null) { storage_disposables.Dispose(); storage_disposables = new CompositeDisposable(); }
	}
}
