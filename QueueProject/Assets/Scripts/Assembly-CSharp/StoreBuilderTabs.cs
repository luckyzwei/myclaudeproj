using System.Collections.Generic;
using Balancy.Models.LiveOps.Store;
using Balancy.Models.SmartObjects;
using Balancy.Models.Store;
using UnityEngine;

public class StoreBuilderTabs : StoreBuilder
{
	[SerializeField]
	private StorePageTab m_tabPrefab;

	[SerializeField]
	private Transform m_tabsLayout;

	[SerializeField]
	private int m_defaultPage;

	private List<StorePageTab> m_tabs;

	public override void Build(SmartConfig storeToBuild)
	{
	}

	private void DisplayPage(Page page)
	{
	}

	internal void DisplayPage(string pageName)
	{
	}

	internal void DisplayPage(int pageIndex)
	{
	}

	protected override StoreProductCell ConfigSlotProduct(Product product, Slot slot)
	{
		return null;
	}
}
