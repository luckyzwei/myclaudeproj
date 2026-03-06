using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemPopupNoAdsBanner : MonoBehaviour
{
	[SerializeField]
	private Button BuyBtn;

	[Space(5f)]
	[SerializeField]
	private Text BeforePrice;

	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private Text SaleText;

	[Space(5f)]
	[SerializeField]
	private GameObject RemainTimeRoot;

	[SerializeField]
	private Text RemainTimeText;

	private int NoAdsIdx;

	private int NoAdsType;

	private CompositeDisposable Disposables;

	private void Awake()
	{
		Disposables = new CompositeDisposable();
		if (BuyBtn != null) BuyBtn.onClick.AddListener(OnClick);
	}

	public void Init()
	{
		SetNoAdsBanner();
	}

	private void SetNoAdsBanner()
	{
		if (RemainTimeRoot != null) RemainTimeRoot.SetActive(false);
	}

	private void OnClick()
	{
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
