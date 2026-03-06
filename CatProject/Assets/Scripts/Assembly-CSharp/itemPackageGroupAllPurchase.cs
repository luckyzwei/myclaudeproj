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
		if (buyBtn != null) buyBtn.onClick.AddListener(OnClickBuy);
	}

	public void Set(int packageIdx)
	{
		this.packageIdx = packageIdx;
	}

	public void SetSale(bool value)
	{
		if (saleObj != null) saleObj.SetActive(value);
		if (bgSale != null) bgSale.SetActive(value);
	}

	private void OnClickBuy()
	{
		ClickCb?.Invoke(packageIdx);
	}
}
