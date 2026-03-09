using Balancy.Models.LiveOps.Store;
using Balancy.Models.Store;
using TMPro;
using UnityEngine;

public class SpecialOfferProductCell : StoreProductCellCurrencyExplosion
{
	private const string PERCENT_FORMAT_KEY = "Store.PercentOff";

	[SerializeField]
	private GameObject m_discountTag;

	[SerializeField]
	private GameObject m_valueTag;

	[SerializeField]
	private TextMeshProUGUI m_valueText;

	[SerializeField]
	private TextMeshProUGUI m_percentageOffText;

	public override void Setup(Product product, Slot slot)
	{
	}
}
