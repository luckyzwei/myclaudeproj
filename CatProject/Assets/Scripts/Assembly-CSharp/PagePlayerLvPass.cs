using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[UIPath("UI/Page/PagePlayerLvPass", false, false)]
public class PagePlayerLvPass : UIBase
{
	[Header("[PagePlayerLvPass]")]
	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject Item;

	[SerializeField]
	private GameObject DecoObj;

	[Space(10f)]
	[SerializeField]
	private GameObject BtnAreaObj;

	[SerializeField]
	private Button PurchaseBtn;

	[SerializeField]
	private Text Price;

	[SerializeField]
	private Text BeforePrice;

	[SerializeField]
	private Text SaleText;

	[Space(5f)]
	[SerializeField]
	private GameObject CurRewardGemFrame;

	[SerializeField]
	private Text TotalRewardGemText;

	[SerializeField]
	private Text CurRewardGemText;

	[Header("DoubleSale")]
	[SerializeField]
	private GameObject DoubleSaleAreaObj;

	[SerializeField]
	private Button DoubleSalePurchaseBtn;

	[Space(5f)]
	[SerializeField]
	private Text DoubleSaleText1;

	[SerializeField]
	private Text DoubleSaleText2;

	[SerializeField]
	private Text DoubleSalePrice;

	[SerializeField]
	private Text DoubleSalePrice1;

	[SerializeField]
	private Text DoubleSalePrice2;

	[SerializeField]
	private Text DoubleSaleRemainTime;

	[Space(10f)]
	[SerializeField]
	private GameObject ClaimAllBtnObj;

	[SerializeField]
	private Button ClaimAllBtn;

	[SerializeField]
	private Animator PurchaseAnim;

	private bool inPurchase;

	private CompositeDisposable disposables;

	[Header("Onetime")]
	[SerializeField]
	private GameObject oneTimeUIRoot;

	[SerializeField]
	private Image oneTimeCurrencyIcon;

	[SerializeField]
	private Text oneTimeCurrencyCount;

	private int GroupIdx;

	private bool IsNoAds;

	public Image OneTimeCurrencyIcon => null;

	protected override void Awake()
	{
	}

	public void Init(int groupIdx, UnityAction endCb = null)
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnRefresh()
	{
	}

	private void RefreshPage()
	{
	}

	private void CheckAndUpdatePass()
	{
	}

	private void SetClaimAllButtonState()
	{
	}

	private void OnClickPurchase()
	{
	}

	private void OnClickClaimAllBtn()
	{
	}

	private void SetTotalRewardGem()
	{
	}

	private void SetCurRewardGem(bool isPass)
	{
	}

	private void SetOneTime()
	{
	}

	private void UpdateOneTimeCurrencyIcon()
	{
	}

	public void UpdateOneTimeCurrencyCount()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
