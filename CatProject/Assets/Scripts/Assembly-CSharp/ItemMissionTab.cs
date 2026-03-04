using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemMissionTab : MonoBehaviour, ITabToggleTab
{
	[SerializeField]
	private Transform MoneyRoot;

	[SerializeField]
	private List<ItemMission> MissionItems;

	[Header("MoneySafe")]
	[SerializeField]
	private GameObject MoneySafeObj;

	[SerializeField]
	private GameObject MoneySafeEmptyDecoObj;

	[SerializeField]
	private DoTweenScriptComponent MoneySafeTween;

	[SerializeField]
	private Text MoneySafeCount;

	[SerializeField]
	private Text MoneySafeMoney;

	[SerializeField]
	private Text MoneySafeNextMoney;

	[SerializeField]
	private Button MoneySafeBtn;

	[SerializeField]
	private GameObject MoneySafeNextRoot;

	[SerializeField]
	private Transform MoneySafeEffectTrans;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	[SerializeField]
	private Transform oneTimeCurrencyIconT;

	[Header("Banner")]
	[SerializeField]
	private ItemShopSpecialBanner OpenNowBanner;

	[SerializeField]
	private ItemBannerNextRegion NextRegionBanner;

	[Header("SubMission")]
	[SerializeField]
	private GameObject SubMissionRoot;

	[SerializeField]
	private GameObject SubMissionEmptyDecoObj;

	[SerializeField]
	private List<ItemMission> SubMissionItems;

	[Header("Milestone")]
	[SerializeField]
	private GameObject MilestoneRoot;

	[SerializeField]
	private Button MilestoneOpenBtn;

	private CompositeDisposable disposables;

	private Action OnGotoNavi;

	public OnetimeCurrencyComponent OneTimeComponent { get { return null; } }

	public Transform OneTimeCurrencyIconT { get { return null; } }

	private void Awake()
	{
	}

	public void InitTab(Action onGotoNavi)
	{
	}

	private void OnClickMilestoneOpenBtn()
	{
	}

	private void GotoNavi(int slot)
	{
	}

	private void GotoSubMissionNavi(int slot)
	{
	}

	private void GetMissionReward(int rewardType, int rewardIdx, BigInteger rewardCnt, bool isDoubleReward)
	{
	}

	private void UpdateMoneySafe()
	{
	}

	private void GetMoneySafe(BigInteger money)
	{
	}

	private void OnClickGetMoneySafe()
	{
	}

	private void UpdateOpenNowBanner()
	{
	}

	private void UpdateNextRegionBanner()
	{
	}

	private void UpdateSubMission()
	{
	}

	private void UpdateMilestone()
	{
	}

	private void OnClickOpenNowBanner(int idx)
	{
	}

	public void Refresh()
	{
	}

	public void Reset()
	{
	}

	private void OnDestroy()
	{
	}
}
