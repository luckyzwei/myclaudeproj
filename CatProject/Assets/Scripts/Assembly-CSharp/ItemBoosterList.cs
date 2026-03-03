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
	}

	private void OnDisable()
	{
	}

	public void Init(BoosterData boosterTable)
	{
	}

	private void SetMultiRevenueProduct(BoosterData boosterTable)
	{
	}

	private void InitTicketInfo()
	{
	}

	private void UpdateBoosterState()
	{
	}

	private void SetBoosterBgState(E_BoosterState state)
	{
	}

	private void OnClickBoosterActiveBtn()
	{
	}

	private bool ActivateBooster(bool useTicket)
	{
		return false;
	}

	private void OnClickMultiRevenueBtn()
	{
	}

	private void OnChangeTicketToggle(bool isOn)
	{
	}

	private void OnClickTicketUseBtn()
	{
	}

	private BoosterRegionBuffUserData GetBoosterBuffData(int boosterIdx)
	{
		return null;
	}

	public Button GetBoosterActiveBtn()
	{
		return null;
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
