using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemPackageGroup : MonoBehaviour
{
	[SerializeField]
	protected Text packageName;

	[SerializeField]
	protected Image img;

	[SerializeField]
	protected Transform articleRoot;

	[SerializeField]
	protected GameObject articleObj;

	[SerializeField]
	protected GameObject saleObj;

	[SerializeField]
	protected Text saleValueText;

	[SerializeField]
	protected Text saleOriginText;

	[SerializeField]
	protected Button buyBtn;

	[SerializeField]
	protected Text buyPriceText;

	[SerializeField]
	protected Image bgImg;

	[SerializeField]
	protected GameObject bgSale;

	[SerializeField]
	protected GameObject TimeRoot;

	[SerializeField]
	protected Text RemainTimeText;

	[SerializeField]
	protected GameObject SaleCountRoot;

	[SerializeField]
	protected Text SaleCountText;

	public Action<int> ClickCb;

	public Action HideCb;

	protected CompositeDisposable disposables;

	protected int packageIdx;

	public int PackageIdx => 0;

	private void Awake()
	{
	}

	public virtual void Set(int packageIdx)
	{
	}

	private void SetBgColor(string color)
	{
	}

	public void SetSale(bool value)
	{
	}

	public virtual void OnBuySuccess()
	{
	}

	protected virtual void OnClickBuy()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
