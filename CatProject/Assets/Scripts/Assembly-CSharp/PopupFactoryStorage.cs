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
	}

	public void Init(Tab openTab = Tab.Storage)
	{
	}

	public void ShowUpgradeGuideArrow(bool bShow)
	{
	}

	private void UpdateList()
	{
	}

	private void ListActiveCallback()
	{
	}

	private void UpdateUpgrade()
	{
	}

	private void UpdateSelectItem()
	{
	}

	private void OnClickSelectItem(int product)
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickOrganize()
	{
	}

	private void OnClickProcess()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
