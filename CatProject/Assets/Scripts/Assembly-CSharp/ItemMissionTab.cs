using System;
using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
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

	public OnetimeCurrencyComponent OneTimeComponent { get { return oneTimeComponent; } }

	public Transform OneTimeCurrencyIconT { get { return oneTimeCurrencyIconT; } }

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (MoneySafeBtn != null) MoneySafeBtn.onClick.AddListener(OnClickGetMoneySafe);
		if (MilestoneOpenBtn != null) MilestoneOpenBtn.onClick.AddListener(OnClickMilestoneOpenBtn);
	}

	public void InitTab(Action onGotoNavi)
	{
		OnGotoNavi = onGotoNavi;

		if (MissionItems != null)
		{
			for (int i = 0; i < MissionItems.Count; i++)
			{
				if (MissionItems[i] == null) continue;
				MissionItems[i].NaviCb = GotoNavi;
				MissionItems[i].GetRewardCb = GetMissionReward;
				MissionItems[i].MoneySafeRefreshCb = UpdateMoneySafe;
			}
		}

		if (SubMissionItems != null)
		{
			for (int i = 0; i < SubMissionItems.Count; i++)
			{
				if (SubMissionItems[i] == null) continue;
				SubMissionItems[i].NaviCb = GotoSubMissionNavi;
				SubMissionItems[i].GetRewardCb = GetMissionReward;
			}
		}
	}

	private void OnClickMilestoneOpenBtn()
	{
		// Open milestone popup
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	private void GotoNavi(int slot)
	{
		OnGotoNavi?.Invoke();
	}

	private void GotoSubMissionNavi(int slot)
	{
		OnGotoNavi?.Invoke();
	}

	private void GetMissionReward(int rewardType, int rewardIdx, BigInteger rewardCnt, bool isDoubleReward)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Apply reward to user data
		UpdateMoneySafe();
	}

	private void UpdateMoneySafe()
	{
		if (MoneySafeObj != null) MoneySafeObj.SetActive(true);
		if (MoneySafeEmptyDecoObj != null) MoneySafeEmptyDecoObj.SetActive(false);
		if (MoneySafeCount != null) MoneySafeCount.text = "0";
		if (MoneySafeMoney != null) MoneySafeMoney.text = "0";
		// Populate from stage money safe data
	}

	private void GetMoneySafe(BigInteger money)
	{
		// Add money safe reward to user data
		if (MoneySafeTween != null) MoneySafeTween.Play();
		UpdateMoneySafe();
	}

	private void OnClickGetMoneySafe()
	{
		// Collect accumulated money safe reward
		GetMoneySafe(BigInteger.Zero);
	}

	private void UpdateOpenNowBanner()
	{
		if (OpenNowBanner == null) return;
		OpenNowBanner.gameObject.SetActive(false);
		// Check if there is an active special sale banner
	}

	private void UpdateNextRegionBanner()
	{
		if (NextRegionBanner == null) return;
		NextRegionBanner.gameObject.SetActive(false);
		// Check if next region banner should show
	}

	private void UpdateSubMission()
	{
		if (SubMissionRoot == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		bool hasSubMission = SubMissionItems != null && SubMissionItems.Count > 0;
		SubMissionRoot.SetActive(hasSubMission);
		if (SubMissionEmptyDecoObj != null) SubMissionEmptyDecoObj.SetActive(!hasSubMission);

		if (SubMissionItems != null)
		{
			for (int i = 0; i < SubMissionItems.Count; i++)
			{
				if (SubMissionItems[i] != null)
					SubMissionItems[i].SetSubMission(i);
			}
		}
	}

	private void UpdateMilestone()
	{
		if (MilestoneRoot == null) return;
		MilestoneRoot.SetActive(false);
		// Check milestone availability
	}

	private void OnClickOpenNowBanner(int idx)
	{
		// Navigate to the open-now shop item
	}

	public void Refresh()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (MissionItems != null)
		{
			for (int i = 0; i < MissionItems.Count; i++)
			{
				if (MissionItems[i] != null)
					MissionItems[i].Set(i);
			}
		}

		UpdateMoneySafe();
		UpdateOpenNowBanner();
		UpdateNextRegionBanner();
		UpdateSubMission();
		UpdateMilestone();
	}

	public void Reset()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = new CompositeDisposable();
		}
		if (MissionItems != null)
		{
			for (int i = 0; i < MissionItems.Count; i++)
			{
				if (MissionItems[i] != null) MissionItems[i].Reset();
			}
		}
		if (SubMissionItems != null)
		{
			for (int i = 0; i < SubMissionItems.Count; i++)
			{
				if (SubMissionItems[i] != null) SubMissionItems[i].Reset();
			}
		}
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
