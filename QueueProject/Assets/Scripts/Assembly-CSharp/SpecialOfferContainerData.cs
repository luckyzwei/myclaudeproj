using System;
using System.Collections.Generic;
using Balancy.Models;
using UnityEngine;

[CreateAssetMenu(fileName = "SpecialOfferContainerData", menuName = "KWServerShop/SpecialOfferContainerData", order = 1)]
public class SpecialOfferContainerData : ScriptableObject
{
	[Serializable]
	public struct SpecialOfferWrapper
	{
		public SpecialOfferPopUpType specialOfferPopUpType;

		public PrefabReference specialOfferPrefab;

		public Sprite specialOfferIcon;
	}

	[SerializeField]
	private SpecialOfferWrapper[] m_specialOfferWrappers;

	private Dictionary<SpecialOfferPopUpType, SpecialOfferWrapper> m_wrapperDictionary;

	public PrefabReference GetPrefabForPopUpType(SpecialOfferPopUpType specialOfferPopupType)
	{
		return null;
	}

	public Sprite GetIconForPopUpType(SpecialOfferPopUpType specialOfferPopupType)
	{
		return null;
	}

	private void TryPopulateDict()
	{
	}

	private bool CheckContainerTypeExists(SpecialOfferPopUpType specialOfferPopUpType)
	{
		return false;
	}
}
