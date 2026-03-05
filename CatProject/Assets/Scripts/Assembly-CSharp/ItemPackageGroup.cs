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

	public int PackageIdx { get { return packageIdx; } }

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (buyBtn != null)
			buyBtn.onClick.AddListener(OnClickBuy);
	}

	public virtual void Set(int packageIdx)
	{
		this.packageIdx = packageIdx;
	}

	private void SetBgColor(string color)
	{
		if (bgImg != null && !string.IsNullOrEmpty(color))
		{
			Color c;
			if (ColorUtility.TryParseHtmlString(color, out c))
				bgImg.color = c;
		}
	}

	public void SetSale(bool value)
	{
		if (saleObj != null)
			saleObj.SetActive(value);
		if (bgSale != null)
			bgSale.SetActive(value);
	}

	public virtual void OnBuySuccess()
	{
		Set(packageIdx);
	}

	protected virtual void OnClickBuy()
	{
		ClickCb?.Invoke(packageIdx);
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}

	private void OnDisable()
	{
		if (disposables != null)
			disposables.Clear();
		HideCb?.Invoke();
	}
}
