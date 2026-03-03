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
	}

	public void Init()
	{
	}

	private void SetNoAdsBanner()
	{
	}

	private void OnClick()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
