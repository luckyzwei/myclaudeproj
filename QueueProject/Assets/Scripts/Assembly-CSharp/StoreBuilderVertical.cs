using System.Collections.Generic;
using Balancy.Models.LiveOps.Store;
using Balancy.Models.SmartObjects;
using Balancy.Models.Store;
using UnityEngine;

public class StoreBuilderVertical : StoreBuilder
{
	[SerializeField]
	private StorePageDisplay m_divider;

	[SerializeField]
	private float m_cellAnimationDelay;

	protected Slot m_lastSlot;

	private int m_cellIndex;

	public override void Build(SmartConfig storeToBuild)
	{
	}

	protected void TryPlaceDivider(Page page)
	{
	}

	protected void TryPlaceDivider(string pageName)
	{
	}

	private void BuildSection(Page page)
	{
	}

	protected void BuildSection(List<Slot> activeSlots)
	{
	}

	protected override StoreProductCell ConfigSlotProduct(Product product, Slot slot)
	{
		return null;
	}

	internal void SetCellIndex(int index)
	{
	}
}
