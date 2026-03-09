using Balancy.Models.Store;
using UnityEngine;

public class EquippableItemManager : MonoBehaviour
{
	[SerializeField]
	private Category m_category;

	private EquippableItem[] m_allItems;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnItemEquipped(string clientID, Category category)
	{
	}
}
