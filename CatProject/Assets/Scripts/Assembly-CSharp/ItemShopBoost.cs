using UnityEngine;
using UnityEngine.UI;

public class ItemShopBoost : ItemShopProduct
{
	[Header("Boost")]
	[SerializeField]
	private Text boostTimeText;

	[SerializeField]
	private GameObject benefitObj;

	[SerializeField]
	private Image benefitIcon;

	[SerializeField]
	private Text benefitCount;

	[SerializeField]
	private GameObject dimObj;
}
