using System;
using System.Numerics;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSlotOpen", false, false)]
public class PopupBuildingConstruct : UIBase
{
	[SerializeField]
	private Text BuildingNameText;

	[SerializeField]
	private Image BuildingMainImage;

	[SerializeField]
	private GameObject ConstructInfoObj;

	[SerializeField]
	private Text ProductionDescText;

	[SerializeField]
	private Text BuildNeedTimeText;

	[SerializeField]
	private Image BuildingCostIconImage;

	[SerializeField]
	private Text BuildingCostValueText;

	[SerializeField]
	private Button ConstructBtn;

	[SerializeField]
	private Button CloseBtnDim;

	[Header("InConstruction")]
	[SerializeField]
	private GameObject FastConstructObj;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Slider RemainTimeProgress;

	[SerializeField]
	private Button FactConstructBtn;

	[SerializeField]
	private Image FactConstructNeedCostIconImage;

	[SerializeField]
	private Text FactConstructNeedCostText;

	private int BuildingIdx;

	private BigInteger BuildNeedCost_PerMile;

	private DateTime ConstructionCompleteDateTime;

	private int TotalConstructTimeSec;

	private int FastConstructNeedCostValue;

	private CompositeDisposable Disposables;

	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void SetBuildingInfo(int buildingIdx)
	{
	}

	private void setBuildingName(string nameKey)
	{
	}

	private void SetBuildingMainImage(string imageKey)
	{
	}

	private void setBuildingProductionInfo(string descKey)
	{
	}

	private void setBuildingTimeText(int needTime)
	{
	}

	private void SetBuildingCostIconImage(string iconKey)
	{
	}

	private void setBuildingCostValue(BigInteger costValue_PerMile)
	{
	}

	private void SetConstructBtnInteractable(bool bInteractable)
	{
	}

	private void UpdateTimeText()
	{
	}

	private void OnClickedConstructBtn()
	{
	}

	private void OnClickedFactConstructBtn()
	{
	}
}
