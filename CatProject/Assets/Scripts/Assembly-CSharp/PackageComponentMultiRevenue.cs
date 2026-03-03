using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class PackageComponentMultiRevenue : PackageComponent
{
	[SerializeField]
	private GameObject doubleSale;

	[SerializeField]
	private GameObject orignSale;

	[SerializeField]
	private Text beforePriceText;

	[SerializeField]
	private Text beforeBeforePriceText;

	[SerializeField]
	private Text priceText;

	[SerializeField]
	private Text saleText;

	[SerializeField]
	private Text beforeSaleText;

	[SerializeField]
	private Text remainTimeText;

	[SerializeField]
	private Button buyBtn;

	private CompositeDisposable disposables;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void SetSpecial(int packageIdx)
	{
	}

	private void OnClickBuy()
	{
	}
}
