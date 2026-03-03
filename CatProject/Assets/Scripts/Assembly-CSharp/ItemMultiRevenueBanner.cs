using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMultiRevenueBanner : ItemShopSpecialBanner
{
	[Serializable]
	private struct RegionObj
	{
		public int Region;

		public GameObject Obj;
	}

	[SerializeField]
	private Text BeforeRentalFee;

	[SerializeField]
	private Text AfterRentalFee;

	[SerializeField]
	private List<RegionObj> RegionObjs;

	[SerializeField]
	private bool InShop;

	public override void Init(int idx)
	{
	}
}
