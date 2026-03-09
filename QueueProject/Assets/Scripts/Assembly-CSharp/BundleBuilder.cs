using Balancy.Models.Store;
using UnityEngine;

public class BundleBuilder : MonoBehaviour
{
	[SerializeField]
	private Transform m_parent;

	[SerializeField]
	private StoreLayoutData m_layoutData;

	[SerializeField]
	private float m_cellAnimationDelay;

	private Product[] m_cachedBundles;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ClearAllChildren()
	{
	}

	public void BuildBundles(Product[] productsForBundle)
	{
	}

	private void StoreEventsOnItemPurchased(Product product, bool wasSuccess)
	{
	}

	private void RefreshGameObject()
	{
	}
}
