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
	}

	private void PurchaseComp()
	{
	}

	protected override void OnClickCash()
	{
	}
}
