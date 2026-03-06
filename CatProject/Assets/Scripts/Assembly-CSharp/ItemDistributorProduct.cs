using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
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
		Disposables = new CompositeDisposable();
		if (ProductCostShortcutBtn != null) ProductCostShortcutBtn.onClick.AddListener(OnClickedProductCostShortcutBtn);
		if (ProductSellBtn != null) ProductSellBtn.onClick.AddListener(OnClickedProductSellBtn);
		if (ProductSellingBtn != null) ProductSellingBtn.onClick.AddListener(OnClickedProductSellingCancelBtn);
		if (btn_upgrade != null) btn_upgrade.OnPressed = OnClickedProductUpgrade;
		if (btn_UpgradeOpen != null) btn_UpgradeOpen.onClick.AddListener(OnClickProductUpgradeOpen);
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public void Init(int productIdx, bool isSelling, int distributeCoolTimeSec)
	{
		ProductIdx = productIdx;
		bLockedSlot = false;
		SetLockedLayout();
		SetProductIsSelling(isSelling);
	}

	public void SetProductIsSelling(bool isSelling)
	{
		if (ProductSellBtn != null) ProductSellBtn.gameObject.SetActive(!isSelling);
		if (ProductSellingBtn != null) ProductSellingBtn.gameObject.SetActive(isSelling);
		if (SoldoutObj != null) SoldoutObj.SetActive(false);
	}

	public void SetFocusActive(bool bActive)
	{
		if (FocusFxTween != null)
		{
			if (bActive) FocusFxTween.Play();
			else FocusFxTween.Pause();
		}
	}

	private void SetLockedLayout()
	{
		if (UnlockStateObj != null) UnlockStateObj.SetActive(!bLockedSlot);
		if (LockStateObj != null) LockStateObj.SetActive(bLockedSlot);
		if (EnableOpenObj != null) EnableOpenObj.SetActive(false);
	}

	private void SetProductNameText(string nameKey)
	{
		if (ProductNameText != null) ProductNameText.text = nameKey;
	}

	private void SetProductIconImage(string iconKey)
	{
		if (ProductIconImage != null)
		{
			Sprite sprite = Resources.Load<Sprite>(iconKey);
			if (sprite != null) ProductIconImage.sprite = sprite;
		}
	}

	private void SetDistributorImage(string iconKey)
	{
		if (DistributorImage != null)
		{
			Sprite sprite = Resources.Load<Sprite>(iconKey);
			if (sprite != null) DistributorImage.sprite = sprite;
		}
	}

	private void SetProductOnceDistributeCountText(BigInteger needCount_PerMile)
	{
		if (ProductOnceDistributeCountText != null)
			ProductOnceDistributeCountText.text = ProjectUtility.GetThousandCommaText(needCount_PerMile);
	}

	private void SetProductOnceDistributeCountColor(BigInteger onceDistributeCount_PerMile, BigInteger hasProductCount_PerMile)
	{
		if (ProductOnceDistributeCountText != null)
		{
			bool isEnough = hasProductCount_PerMile >= onceDistributeCount_PerMile;
			ProductOnceDistributeCountText.color = isEnough ? Color.white : Color.red;
		}
	}

	private void SetProductOnceDistributeIncomeText(BigInteger onceSellingValue_PerMile, int distributeCoolTimeSec)
	{
		if (ProductOnceDistributeIncomeText != null)
			ProductOnceDistributeIncomeText.text = ProjectUtility.GetThousandCommaText(onceSellingValue_PerMile);
	}

	private void SetProductCostImage(string iconKey)
	{
		if (ProductCostImage != null)
		{
			Sprite sprite = Resources.Load<Sprite>(iconKey);
			if (sprite != null) ProductCostImage.sprite = sprite;
		}
	}

	private void SetProductInventoryCountText(BigInteger hasValue_PerMile)
	{
		if (ProductInventoryCountText != null)
			ProductInventoryCountText.text = ProjectUtility.GetThousandCommaText(hasValue_PerMile);
	}

	private void SetUpgradeNeedValue(BigInteger hasValue_PerMile, BigInteger needValue_PerMile)
	{
		UpgradeNeedValue = needValue_PerMile;
		if (text_btn_upgrade != null)
			text_btn_upgrade.text = ProjectUtility.GetThousandCommaText(needValue_PerMile);
		UpdateButtonInteract(hasValue_PerMile >= needValue_PerMile);
	}

	private void UpdateButtonInteract(bool isEnoughMoney)
	{
		if (btn_upgrade != null)
			btn_upgrade.Interactable = isEnoughMoney;
	}

	public void RedrawUpgradeValue()
	{
		if (text_upgrade_value != null) text_upgrade_value.text = "";
		if (text_transportation_upgrade_inc_value != null) text_transportation_upgrade_inc_value.text = "";
		if (text_revenu_upgrade_inc_value != null) text_revenu_upgrade_inc_value.text = "";
	}

	private void RedrawSellingBtn()
	{
		if (ProductSellBtn != null) ProductSellBtn.gameObject.SetActive(true);
		if (ProductSellingBtn != null) ProductSellingBtn.gameObject.SetActive(false);
		if (SoldoutObj != null) SoldoutObj.SetActive(false);
	}

	private void OnClickedProductCostShortcutBtn()
	{
		// Navigate to the production source for the product cost
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickedProductSellBtn()
	{
		SetProductIsSelling(true);
	}

	private void OnClickedProductSellingCancelBtn()
	{
		SetProductIsSelling(false);
	}

	private void OnClickedProductUpgrade()
	{
		RedrawUpgradeValue();
	}

	private void OnClickProductUpgradeOpen()
	{
		if (!bLockedSlot) return;
		bLockedSlot = false;
		SetLockedLayout();
		if (unlockAni != null)
			unlockAni.SetTrigger("Unlock");
	}

	private void Reset()
	{
		ProductIdx = 0;
		bLockedSlot = false;
		UpgradeNeedValue = BigInteger.Zero;
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}
}
