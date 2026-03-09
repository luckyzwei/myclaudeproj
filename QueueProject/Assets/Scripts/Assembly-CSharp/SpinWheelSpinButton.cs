using Balancy.Models.SmartObjects;
using UnityEngine;

public class SpinWheelSpinButton : MonoBehaviour
{
	[SerializeField]
	private GameObject m_freeSpinGroup;

	[SerializeField]
	private GameObject m_rvSpinGroup;

	[SerializeField]
	private GameObject m_softSpinGroup;

	[SerializeField]
	private ItemWithAmountCell m_itemWithAmountCell;

	public void Config(Price price)
	{
	}
}
