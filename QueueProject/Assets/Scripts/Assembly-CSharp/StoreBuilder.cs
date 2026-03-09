using System.Collections.Generic;
using Balancy.Models.LiveOps.Store;
using Balancy.Models.SmartObjects;
using Balancy.Models.Store;
using UnityEngine;
using UnityEngine.UI;

public abstract class StoreBuilder : MonoBehaviour
{
	[SerializeField]
	protected Transform m_rootLayout;

	[SerializeField]
	protected StoreLayoutData m_layoutData;

	[SerializeField]
	private StoreScrollManager m_storeScrollManager;

	[SerializeField]
	private GameObject[] m_fixedCells;

	protected LayoutGroup m_lastUsedLayoutPrefab;

	protected LayoutGroup m_lastSpawnedLayoutGroup;

	protected ContainerType m_lastType;

	private int m_typeCounter;

	private List<Page> m_pages;

	protected readonly Dictionary<string, List<StoreProductCell>> m_productCells;

	protected List<Page> Pages => null;

	public virtual void Build(SmartConfig storeToBuild)
	{
	}

	protected void ConfigSlot(Slot slot)
	{
	}

	internal void SetLastType(Product product)
	{
	}

	private void CacheProductCells(Slot slot, StoreProductCell productCell)
	{
	}

	protected abstract StoreProductCell ConfigSlotProduct(Product product, Slot slot);

	public void ResetLayout()
	{
	}

	internal Transform GetLayoutForProduct(Product product)
	{
		return null;
	}

	protected Transform GetRoot()
	{
		return null;
	}

	internal void ScrollToPage(string pageName)
	{
	}
}
