using System.Collections.Generic;
using Balancy.Models.Store;
using KWCore.Utils;
using UnityEngine;

public class StoreItemManager : MonoSingleton<StoreItemManager>
{
	private const string DEFAULT_EQUIPPED_ITEM_CLIENT_ID_VALUE = "default";

	[SerializeField]
	private ProductContainer m_productContainer;

	[SerializeField]
	private string m_defaultEquippedItemClientId;

	private Dictionary<Category, string> m_equippedItems;

	public ProductContainer productContainer => null;

	protected override void Init()
	{
	}

	private void OnItemEquipped(string clientId, Category category)
	{
	}

	public string GetEquippedItem(Category category)
	{
		return null;
	}
}
