using UnityEngine;
using UnityEngine.UI;

public class ItemShopLimitProduct : ItemShopProduct
{
	[Header("-------------------------")]
	[SerializeField]
	private GameObject LimitRoot;

	[SerializeField]
	private Text RemainEnablePurchaseCount;

	[SerializeField]
	private GameObject CannotPurchaseBtn;

	protected override void SetIdx(int idx, int region = -1)
	{
		base.SetIdx(idx, region);
	}

	private void PurchaseComp()
	{
		if (RemainEnablePurchaseCount != null)
			RemainEnablePurchaseCount.text = "0";
		if (CannotPurchaseBtn != null)
			CannotPurchaseBtn.SetActive(true);
	}

	protected override void OnClickCash()
	{
		base.OnClickCash();
	}
}
