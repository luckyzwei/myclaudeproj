using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemSeasonalPackageBanner : MonoBehaviour
{
	[Header("ItemSeasonalPackageBanner")]
	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Text Price;

	[SerializeField]
	private Button BuyBtn;

	[Header("Sale")]
	[SerializeField]
	private GameObject SaleRoot;

	[SerializeField]
	private Text SaleText;

	[SerializeField]
	private Text SalePrice;

	[Header("ItemArticle")]
	[SerializeField]
	private Transform articleRoot;

	[SerializeField]
	private GameObject articleObj;

	[Header("RemainTime")]
	[SerializeField]
	private GameObject RemainTimeRoot;

	[SerializeField]
	private Text RemainTimeText;

	private ShopSystem.SeasonalPackageMatchType CurType;

	private CompositeDisposable Disposables;

	public int Idx { get; private set; }

	private void Awake()
	{
		Disposables = new CompositeDisposable();
		if (BuyBtn != null) BuyBtn.onClick.AddListener(OnClickBtn);
	}

	public virtual void Init(ShopSystem.SeasonalPackageMatchType type, ShopSystem.InAppPurchaseLocation location = ShopSystem.InAppPurchaseLocation.none)
	{
		CurType = type;
		Idx = 0;
		if (SaleRoot != null) SaleRoot.SetActive(false);
		if (RemainTimeRoot != null) RemainTimeRoot.SetActive(false);
	}

	public virtual void InitMaxTimeLevelUpPackage(int packageIdx, ShopSystem.InAppPurchaseLocation location = ShopSystem.InAppPurchaseLocation.none)
	{
		Idx = packageIdx;
		if (SaleRoot != null) SaleRoot.SetActive(false);
		if (RemainTimeRoot != null) RemainTimeRoot.SetActive(false);
	}

	private void BuyPackage(int idx)
	{
	}

	public void OnClickBtn()
	{
		BuyPackage(Idx);
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}
}
