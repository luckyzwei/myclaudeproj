using Balancy.Models.SmartObjects;
using Balancy.Models.Store;
using UnityEngine;

public class AutoEquipper : MonoBehaviour
{
	[SerializeField]
	private AutoEquipItemsDb m_db;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnStoreItemPurchased(Product product, bool wasSuccess)
	{
	}

	private void OnItemUpdated(Item item, int count, int slotIndex)
	{
	}

	private void CheckItemForAutoEquip(string clientId)
	{
	}
}
