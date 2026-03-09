using Balancy.Models;
using UnityEngine;

public class ItemWithAmountZeroCell : ItemWithAmountCell
{
	[SerializeField]
	private GameObject m_amountGameObject;

	[SerializeField]
	private bool m_showNothingIfValue1;

	protected override void HandleAmountDisplay(int amount, KwaleeItem kwaleeItem)
	{
	}
}
