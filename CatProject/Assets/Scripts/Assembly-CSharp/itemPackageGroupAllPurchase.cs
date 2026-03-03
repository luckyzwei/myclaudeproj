using System;
using UnityEngine;
using UnityEngine.UI;

public class itemPackageGroupAllPurchase : MonoBehaviour
{
	[SerializeField]
	private Text packageName;

	[SerializeField]
	private GameObject saleObj;

	[SerializeField]
	private Text saleValueText;

	[SerializeField]
	private Text saleOriginText;

	[SerializeField]
	private Button buyBtn;

	[SerializeField]
	private Text buyPriceText;

	[SerializeField]
	private GameObject bgSale;

	public Action<int> ClickCb;

	public Action HideCb;

	private int packageIdx;

	private void Awake()
	{
	}

	public void Set(int packageIdx)
	{
	}

	public void SetSale(bool value)
	{
	}

	private void OnClickBuy()
	{
	}
}
