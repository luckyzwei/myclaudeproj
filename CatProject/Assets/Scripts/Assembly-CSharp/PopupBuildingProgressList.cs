using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupBuildingProgressList", false, false)]
public class PopupBuildingProgressList : UIBase
{
	[SerializeField]
	private GameObject ProgressSlotFullStateObj;

	[SerializeField]
	private GameObject ProgressSlotContentsBox;

	[SerializeField]
	private GameObject PremiumBuildingSlotObj;

	[SerializeField]
	private Button PremiumBuildingSlotBuyBtn;

	[SerializeField]
	private Text PremiumBuildingSlotPriceText;

	[SerializeField]
	private Button DimBtn;

	private List<ItemBuildingProgressSlot> BuildingProgressSlotList;

	private CompositeDisposable BuildingDisposables;

	private IDisposable StatueDisposable;

	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	private void Reset()
	{
	}

	private void SetPremiumBuildingSlotPriceText(string textStr)
	{
	}

	private void OnClickedPremiumBuildingSlotBuyBtn()
	{
	}

	private void UpdateBuildingConstruction()
	{
	}
}
