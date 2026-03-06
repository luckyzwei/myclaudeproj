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
		base.Awake();
		BuildingDisposables = new CompositeDisposable();
		BuildingProgressSlotList = new List<ItemBuildingProgressSlot>();
		if (PremiumBuildingSlotBuyBtn != null) PremiumBuildingSlotBuyBtn.onClick.AddListener(OnClickedPremiumBuildingSlotBuyBtn);
		if (DimBtn != null) DimBtn.onClick.AddListener(() => Hide());
	}

	private void OnDestroy()
	{
		if (BuildingDisposables != null) { BuildingDisposables.Dispose(); BuildingDisposables = null; }
		if (StatueDisposable != null) { StatueDisposable.Dispose(); StatueDisposable = null; }
	}

	public override void OnShowBefore()
	{
		Reset();
		UpdateBuildingConstruction();
	}

	public override void OnHideBefore()
	{
		if (BuildingDisposables != null) { BuildingDisposables.Dispose(); BuildingDisposables = new CompositeDisposable(); }
	}

	private void Reset()
	{
		if (BuildingProgressSlotList != null) BuildingProgressSlotList.Clear();
		if (ProgressSlotFullStateObj != null) ProgressSlotFullStateObj.SetActive(false);
		if (PremiumBuildingSlotObj != null) PremiumBuildingSlotObj.SetActive(false);
	}

	private void SetPremiumBuildingSlotPriceText(string textStr)
	{
		if (PremiumBuildingSlotPriceText != null)
			PremiumBuildingSlotPriceText.text = textStr;
	}

	private void OnClickedPremiumBuildingSlotBuyBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void UpdateBuildingConstruction()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (ProgressSlotContentsBox != null) ProgressSlotContentsBox.SetActive(true);
	}
}
