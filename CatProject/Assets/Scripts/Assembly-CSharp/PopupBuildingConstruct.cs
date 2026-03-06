using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		base.Awake();
		Disposables = new CompositeDisposable();

		if (ConstructBtn != null) ConstructBtn.onClick.AddListener(OnClickedConstructBtn);
		if (FactConstructBtn != null) FactConstructBtn.onClick.AddListener(OnClickedFactConstructBtn);
		if (CloseBtnDim != null) CloseBtnDim.onClick.AddListener(() => Hide());
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	private void Update()
	{
		UpdateTimeText();
	}

	public void SetBuildingInfo(int buildingIdx)
	{
		BuildingIdx = buildingIdx;
		bool isConstructing = false;
		if (ConstructInfoObj != null) ConstructInfoObj.SetActive(!isConstructing);
		if (FastConstructObj != null) FastConstructObj.SetActive(isConstructing);
	}

	private void setBuildingName(string nameKey)
	{
		if (BuildingNameText != null) BuildingNameText.text = nameKey;
	}

	private void SetBuildingMainImage(string imageKey)
	{
		if (BuildingMainImage == null) return;
	}

	private void setBuildingProductionInfo(string descKey)
	{
		if (ProductionDescText != null) ProductionDescText.text = descKey;
	}

	private void setBuildingTimeText(int needTime)
	{
		if (BuildNeedTimeText != null)
			BuildNeedTimeText.text = ProjectUtility.GetTimeStringFormattingShort(needTime);
	}

	private void SetBuildingCostIconImage(string iconKey)
	{
		if (BuildingCostIconImage == null) return;
	}

	private void setBuildingCostValue(BigInteger costValue_PerMile)
	{
		BuildNeedCost_PerMile = costValue_PerMile;
		if (BuildingCostValueText != null)
			BuildingCostValueText.text = ProjectUtility.GetThousandCommaText(costValue_PerMile);
	}

	private void SetConstructBtnInteractable(bool bInteractable)
	{
		if (ConstructBtn != null) ConstructBtn.interactable = bInteractable;
	}

	private void UpdateTimeText()
	{
		if (ConstructionCompleteDateTime <= DateTime.MinValue) return;
		int remainSec = (int)(ConstructionCompleteDateTime - DateTime.UtcNow).TotalSeconds;
		if (remainSec <= 0)
		{
			// Construction complete
			Hide();
			return;
		}
		if (RemainTimeText != null) RemainTimeText.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
		if (RemainTimeProgress != null && TotalConstructTimeSec > 0)
			RemainTimeProgress.value = 1f - (float)remainSec / (float)TotalConstructTimeSec;
	}

	private void OnClickedConstructBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickedFactConstructBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
