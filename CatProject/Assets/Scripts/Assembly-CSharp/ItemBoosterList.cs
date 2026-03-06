using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemBoosterList : MonoBehaviour
{
	private enum E_BoosterState
	{
		Normal = 0,
		Active = 1,
		MultiRevenue = 2
	}

	[SerializeField]
	private Image BoosterIconImg;

	[SerializeField]
	private Text BoosterNameText;

	[SerializeField]
	private Text BoosterValueText;

	[SerializeField]
	private GameObject BoosterArrowObj;

	[SerializeField]
	private Image BoosterAbilityIconImg;

	[SerializeField]
	private Text BoosterAbilityDescText;

	[SerializeField]
	private Button BoosterActiveBtn;

	[SerializeField]
	private Image BoosterCostImg;

	[SerializeField]
	private Text BoosterCostText;

	[SerializeField]
	private GameObject TimeProgressObj;

	[SerializeField]
	private Text TimeProgressText;

	[SerializeField]
	private Slider TimeProgressSlider;

	[SerializeField]
	private GameObject NormalStateObj;

	[SerializeField]
	private GameObject ActiveStateObj;

	[SerializeField]
	private GameObject MultiRevenueObj;

	[SerializeField]
	private Button MultiRevenueBtn;

	[Header("Booster Ticket")]
	[SerializeField]
	private GameObject TicketRootObj;

	[SerializeField]
	private ToggleController TicketToggleCtrl;

	[SerializeField]
	private List<Image> TicketIconImgList;

	[SerializeField]
	private Button TicketUseBtn;

	[SerializeField]
	private Text TicketCountText;

	[Header("ETC")]
	[SerializeField]
	private GameObject RedDotObj;

	private int AbilityIdx;

	private int TicketItemIdx;

	private bool ActiveUseTicket;

	private CompositeDisposable Disposables;

	public Action<bool> OnActivateMultiRevenue;

	public int BoosterIdx { get; private set; }

	private void Awake()
	{
		Disposables = new CompositeDisposable();

		if (BoosterActiveBtn != null) BoosterActiveBtn.onClick.AddListener(OnClickBoosterActiveBtn);
		if (MultiRevenueBtn != null) MultiRevenueBtn.onClick.AddListener(OnClickMultiRevenueBtn);
		if (TicketUseBtn != null) TicketUseBtn.onClick.AddListener(OnClickTicketUseBtn);
		if (TicketToggleCtrl != null) TicketToggleCtrl.setToggleListener(OnChangeTicketToggle);
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public void Init(BoosterData boosterTable)
	{
		if (boosterTable == null) return;
		BoosterIdx = boosterTable.Idx;
		AbilityIdx = boosterTable.AbilityType;

		if (BoosterNameText != null) BoosterNameText.text = "";
		if (BoosterValueText != null) BoosterValueText.text = boosterTable.AbilityValue.ToString() + "%";

		SetMultiRevenueProduct(boosterTable);
		InitTicketInfo();
		UpdateBoosterState();
	}

	private void SetMultiRevenueProduct(BoosterData boosterTable)
	{
		if (MultiRevenueObj != null) MultiRevenueObj.SetActive(false);
	}

	private void InitTicketInfo()
	{
		ActiveUseTicket = false;
		if (TicketRootObj != null) TicketRootObj.SetActive(false);
		if (TicketCountText != null) TicketCountText.text = "0";
	}

	private void UpdateBoosterState()
	{
		var buffData = GetBoosterBuffData(BoosterIdx);
		bool isActive = buffData != null && buffData.BoosterRemainTimeSec != null && buffData.BoosterRemainTimeSec.Value > 0;

		if (isActive)
		{
			SetBoosterBgState(E_BoosterState.Active);
			if (TimeProgressObj != null) TimeProgressObj.SetActive(true);
		}
		else
		{
			SetBoosterBgState(E_BoosterState.Normal);
			if (TimeProgressObj != null) TimeProgressObj.SetActive(false);
		}

		if (RedDotObj != null) RedDotObj.SetActive(false);
	}

	private void SetBoosterBgState(E_BoosterState state)
	{
		if (NormalStateObj != null) NormalStateObj.SetActive(state == E_BoosterState.Normal);
		if (ActiveStateObj != null) ActiveStateObj.SetActive(state == E_BoosterState.Active);
		if (MultiRevenueObj != null) MultiRevenueObj.SetActive(state == E_BoosterState.MultiRevenue);
	}

	private void OnClickBoosterActiveBtn()
	{
		ActivateBooster(ActiveUseTicket);
	}

	private bool ActivateBooster(bool useTicket)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		// Activate booster
		UpdateBoosterState();
		return true;
	}

	private void OnClickMultiRevenueBtn()
	{
		OnActivateMultiRevenue?.Invoke(true);
	}

	private void OnChangeTicketToggle(bool isOn)
	{
		ActiveUseTicket = isOn;
	}

	private void OnClickTicketUseBtn()
	{
		ActivateBooster(true);
	}

	private BoosterRegionBuffUserData GetBoosterBuffData(int boosterIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return null;
		// Look up booster buff data by idx
		return null;
	}

	public Button GetBoosterActiveBtn()
	{
		return BoosterActiveBtn;
	}

	private TpAnalyticsProp.LogCostCashType GetLogCostCashType(int abilityIdx)
	{
		return default(TpAnalyticsProp.LogCostCashType);
	}

	private TpMaxProp.AdRewardType GetAdRewardType(int abilityIdx)
	{
		return default(TpMaxProp.AdRewardType);
	}
}
