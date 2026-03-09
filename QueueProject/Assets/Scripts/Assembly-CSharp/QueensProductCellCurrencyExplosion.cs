using Balancy.Models.LiveOps.Store;
using Balancy.Models.Store;
using UnityEngine;
using UnityEngine.UI;

public class QueensProductCellCurrencyExplosion : StoreProductCellCurrencyExplosion
{
	[SerializeField]
	private Button m_fullSizeButton;

	protected override void SetupTimer()
	{
	}

	public override void Setup(Product product, Slot slot)
	{
	}

	private void FullSizeButtonClicked()
	{
	}

	protected override void OnProductPurchased(bool wasSuccess)
	{
	}
}
