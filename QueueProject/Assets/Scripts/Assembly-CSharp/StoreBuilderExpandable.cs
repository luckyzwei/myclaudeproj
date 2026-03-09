using System.Collections.Generic;
using Balancy.Models.LiveOps.Store;
using UnityEngine;

public class StoreBuilderExpandable : StoreBuilderVertical
{
	[SerializeField]
	private int m_numberOfLargeItemsInMinimalView;

	[SerializeField]
	private int m_numberOfSmallItemsInMinimalView;

	[SerializeField]
	private GameObject m_expandButtonObject;

	private GameObject m_buttonObjectInstance;

	private bool m_isExpanded;

	private readonly List<Slot> m_activeLargeSlots;

	private readonly List<Slot> m_activeSmallSlots;

	private readonly List<Slot> m_placedSlots;

	private List<Slot> m_placedSmallSlots;

	internal void ShowMinimalView()
	{
	}

	internal void ShowExpandedView()
	{
	}

	private void CacheSlotsByContainerType(List<Slot> activeLargeSlots, List<Slot> activeSmallSlots)
	{
	}

	private void PlaceMinimalSlots(List<Slot> activeLargeSlots, List<Slot> activeSmallSlots)
	{
	}

	private void PlaceExpandButton()
	{
	}

	private List<Slot> PlaceLargeSlots(List<Slot> activeLargeSlots, int count)
	{
		return null;
	}

	private List<Slot> PlaceSmallSlots(List<Slot> activeSmallSlots, int count)
	{
		return null;
	}
}
