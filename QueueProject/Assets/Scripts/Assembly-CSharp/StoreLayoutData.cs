using System;
using System.Collections.Generic;
using Balancy.Models.Store;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "LayoutContainer", menuName = "KWServerShop/LayoutContainer", order = 1)]
public class StoreLayoutData : ScriptableObject
{
	[Serializable]
	public struct LayoutWrapper
	{
		public ContainerType containerType;

		public LayoutGroup layoutGroup;

		public StoreProductCell productCell;

		public int maxContainersPerLayout;
	}

	[SerializeField]
	private LayoutWrapper[] m_layoutWrappers;

	private Dictionary<ContainerType, LayoutWrapper> m_wrapperDictionary;

	public LayoutGroup GetLayoutGroupForContainerType(ContainerType containerType)
	{
		return null;
	}

	public StoreProductCell GetCellForContainerType(ContainerType containerType)
	{
		return null;
	}

	public int GetMaxContainersPerLayoutForContainerType(ContainerType containerType)
	{
		return 0;
	}

	private void TryPopulateDict()
	{
	}

	private bool CheckContainerTypeExists(ContainerType containerType)
	{
		return false;
	}
}
