using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemDistributorProduct : MonoBehaviour
{
	[SerializeField]
	private Text ProductNameText;

	[SerializeField]
	private Image ProductIconImage;

	[SerializeField]
	private Image DistributorImage;

	[SerializeField]
	private Text ProductInventoryCountText;

	[SerializeField]
	private Text ProductOnceDistributeCountText;

	[SerializeField]
	private Text ProductOnceDistributeIncomeText;

	[SerializeField]
	private Image ProductCostImage;

	[SerializeField]
	private Button ProductCostShortcutBtn;

	[SerializeField]
	private Button ProductSellBtn;

	[SerializeField]
	private Button ProductSellingBtn;

	[SerializeField]
	private GameObject SoldoutObj;

	[Header("Lock")]
	[SerializeField]
	private GameObject UnlockStateObj;

	[SerializeField]
	private GameObject LockStateObj;

	[SerializeField]
	private Animator unlockAni;

	[SerializeField]
	private Button btn_UpgradeOpen;

	[SerializeField]
	private GameObject EnableOpenObj;

	[Header("Upgrade")]
	[SerializeField]
	private ButtonPressed btn_upgrade;

	[SerializeField]
	private Text text_btn_upgrade;

	[SerializeField]
	private Text text_upgrade_value;

	[SerializeField]
	private Text text_transportation_upgrade_inc_value;

	[SerializeField]
	private Text text_revenu_upgrade_inc_value;

	[Header("Focus")]
	[SerializeField]
	private DoTweenScriptComponent FocusFxTween;

	private PopupDistributorMenu cash_ui_popupDistributorMenu;

	private BigInteger UpgradeNeedValue;

	private CompositeDisposable Disposables;

	public int ProductIdx { get; private set; }

	public bool bLockedSlot { get; private set; }

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(int productIdx, bool isSelling, int distributeCoolTimeSec)
	{
	}

	public void SetProductIsSelling(bool isSelling)
	{
	}

	public void SetFocusActive(bool bActive)
	{
	}

	private void SetLockedLayout()
	{
	}

	private void SetProductNameText(string nameKey)
	{
	}

	private void SetProductIconImage(string iconKey)
	{
	}

	private void SetDistributorImage(string iconKey)
	{
	}

	private void SetProductOnceDistributeCountText(BigInteger needCount_PerMile)
	{
	}

	private void SetProductOnceDistributeCountColor(BigInteger onceDistributeCount_PerMile, BigInteger hasProductCount_PerMile)
	{
	}

	private void SetProductOnceDistributeIncomeText(BigInteger onceSellingValue_PerMile, int distributeCoolTimeSec)
	{
	}

	private void SetProductCostImage(string iconKey)
	{
	}

	private void SetProductInventoryCountText(BigInteger hasValue_PerMile)
	{
	}

	private void SetUpgradeNeedValue(BigInteger hasValue_PerMile, BigInteger needValue_PerMile)
	{
	}

	private void UpdateButtonInteract(bool isEnoughMoney)
	{
	}

	public void RedrawUpgradeValue()
	{
	}

	private void RedrawSellingBtn()
	{
	}

	private void OnClickedProductCostShortcutBtn()
	{
	}

	private void OnClickedProductSellBtn()
	{
	}

	private void OnClickedProductSellingCancelBtn()
	{
	}

	private void OnClickedProductUpgrade()
	{
	}

	private void OnClickProductUpgradeOpen()
	{
	}

	private void Reset()
	{
	}
}
