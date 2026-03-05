using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/OutGame/BuildingInfo", true)]
[FloatingDepth(14)]
public class InGameWorldBuildingInfo : InGameFloatingUI
{
	[CompilerGenerated]
	private sealed class _003CWaitParticleEnd_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameWorldBuildingInfo _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CWaitParticleEnd_003Ed__34(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					// Wait one frame for particle to finish
					_003C_003E2__current = new WaitForSeconds(1.5f);
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					// Re-show the UI after particle effect
					if (_003C_003E4__this != null)
					{
						_003C_003E4__this.gameObject.SetActive(true);
					}
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("InGameWorldBuildingInfo")]
	[SerializeField]
	private Text BuildingName;

	[SerializeField]
	private Text BuildingDesc;

	[SerializeField]
	private Image BuildingIcon;

	[SerializeField]
	private Image FactoryPreView;

	[SerializeField]
	private GameObject EarnObj;

	[SerializeField]
	private Text EarnValueText;

	[SerializeField]
	private Image EarnPowerImg;

	[SerializeField]
	private Image EarnMoneyImg;

	[Header("Need")]
	[SerializeField]
	private Button NeedPointBtn;

	[SerializeField]
	private Text NeedPointText;

	[SerializeField]
	private Button NeedLevelBtn;

	[SerializeField]
	private Text NeedLevelText;

	[SerializeField]
	private Text NeedLevelTitleText;

	[Header("Button")]
	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private Button StageMoveBtn;

	[SerializeField]
	private Text CostText;

	[SerializeField]
	private Image CostImg;

	[Space(5f)]
	[SerializeField]
	private GameObject ManagerKeyRootObj;

	[SerializeField]
	private Text MangerKeyText;

	[Space(5f)]
	[SerializeField]
	private Button IAPBtn;

	[SerializeField]
	private Text IAPBeforePriceText;

	[SerializeField]
	private Text IAPPriceText;

	[SerializeField]
	private GameObject IAPSaleObj;

	[SerializeField]
	private Text IAPSaleText;

	private int BuildingIdx;

	private int ShopSpecialIdx;

	private ShopSystem.InAppPurchaseLocation Location;

	private Action hideAction;

	private void Awake()
	{
		if (BuyBtn != null)
			BuyBtn.onClick.AddListener(OnClickBuy);
		if (StageMoveBtn != null)
			StageMoveBtn.onClick.AddListener(OnClickMoveStage);
		if (NeedPointBtn != null)
			NeedPointBtn.onClick.AddListener(OnClickNeedPoint);
		if (NeedLevelBtn != null)
			NeedLevelBtn.onClick.AddListener(OnClickNeedLevel);
		if (IAPBtn != null)
			IAPBtn.onClick.AddListener(OnClickIAP);
	}

	public override void Init(Transform parent, GameType type = GameType.WorldMap)
	{
		base.Init(parent, type);
		FollowTrans = parent;
	}

	public void Set(int buildingIdx, bool upgrade = false, ShopSystem.InAppPurchaseLocation location = ShopSystem.InAppPurchaseLocation.other)
	{
		BuildingIdx = buildingIdx;
		Location = location;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		// Look up building info from table
		var buildingInfo = GetBuildingInfoData(buildingIdx);
		if (buildingInfo == null) return;

		// Set building name and description
		if (BuildingName != null)
			BuildingName.text = buildingInfo.NameKey;
		if (BuildingDesc != null)
			BuildingDesc.text = buildingInfo.DescKey;

		// Determine if the building is already owned
		bool isOwned = false;
		if (gameRoot.UserData != null && gameRoot.UserData.WorldmapData != null &&
			gameRoot.UserData.WorldmapData.BuildingList != null)
		{
			isOwned = gameRoot.UserData.WorldmapData.BuildingList.Contains(buildingIdx);
		}

		// Check level requirement
		bool meetsLevel = true;
		if (buildingInfo.OpenLevel > 0 && gameRoot.UserData != null && gameRoot.UserData.Level != null)
		{
			meetsLevel = gameRoot.UserData.Level.Value >= buildingInfo.OpenLevel;
		}

		// Show/hide buttons based on ownership
		if (isOwned)
		{
			// Already owned - show stage move button
			if (BuyBtn != null) BuyBtn.gameObject.SetActive(false);
			if (StageMoveBtn != null) StageMoveBtn.gameObject.SetActive(true);
			if (NeedPointBtn != null) NeedPointBtn.gameObject.SetActive(false);
			if (NeedLevelBtn != null) NeedLevelBtn.gameObject.SetActive(false);
			if (IAPBtn != null) IAPBtn.gameObject.SetActive(false);

			// Show earn info for owned buildings
			if (EarnObj != null) EarnObj.SetActive(true);
		}
		else if (!meetsLevel)
		{
			// Does not meet level requirement
			if (BuyBtn != null) BuyBtn.gameObject.SetActive(false);
			if (StageMoveBtn != null) StageMoveBtn.gameObject.SetActive(false);
			if (NeedLevelBtn != null)
			{
				NeedLevelBtn.gameObject.SetActive(true);
				if (NeedLevelText != null)
					NeedLevelText.text = buildingInfo.OpenLevel.ToString();
			}
			if (NeedPointBtn != null) NeedPointBtn.gameObject.SetActive(false);
			if (IAPBtn != null) IAPBtn.gameObject.SetActive(false);
			if (EarnObj != null) EarnObj.SetActive(false);
		}
		else
		{
			// Can purchase
			if (BuyBtn != null) BuyBtn.gameObject.SetActive(true);
			if (StageMoveBtn != null) StageMoveBtn.gameObject.SetActive(false);
			if (NeedPointBtn != null) NeedPointBtn.gameObject.SetActive(false);
			if (NeedLevelBtn != null) NeedLevelBtn.gameObject.SetActive(false);
			if (EarnObj != null) EarnObj.SetActive(true);

			// Setup IAP if applicable
			SetIAP();
		}

		// Show manager key info if applicable
		if (ManagerKeyRootObj != null)
			ManagerKeyRootObj.SetActive(false);
	}

	private void SetIAP()
	{
		if (ShopSpecialIdx <= 0)
		{
			if (IAPBtn != null) IAPBtn.gameObject.SetActive(false);
			return;
		}

		var packageData = InAppPackageData.FromShopSpecial(ShopSpecialIdx);
		if (packageData == null || string.IsNullOrEmpty(packageData.ProductId))
		{
			if (IAPBtn != null) IAPBtn.gameObject.SetActive(false);
			return;
		}

		if (IAPBtn != null) IAPBtn.gameObject.SetActive(true);

		if (IAPPriceText != null)
			IAPPriceText.text = packageData.ProductId;

		// Show sale info
		if (packageData.SaleValue > 0)
		{
			if (IAPSaleObj != null) IAPSaleObj.SetActive(true);
			if (IAPSaleText != null) IAPSaleText.text = packageData.SaleValue + "%";
		}
		else
		{
			if (IAPSaleObj != null) IAPSaleObj.SetActive(false);
		}
	}

	private string EarnText(bool before, int type, params object[] args)
	{
		string prefix = before ? "+" : "";
		if (type == (int)InfraSystem.BuildingInfraType.Money)
		{
			if (args != null && args.Length > 0)
				return prefix + args[0].ToString();
			return prefix + "0";
		}
		else if (type == (int)InfraSystem.BuildingInfraType.Power)
		{
			if (args != null && args.Length > 0)
				return prefix + args[0].ToString();
			return prefix + "0";
		}
		return "";
	}

	public override void Hide()
	{
		base.Hide();
	}

	public void HideForParticle()
	{
		// Temporarily hide UI while particle effect plays
		gameObject.SetActive(false);
		StartCoroutine(WaitParticleEnd());
	}

	[IteratorStateMachine(typeof(_003CWaitParticleEnd_003Ed__34))]
	private IEnumerator WaitParticleEnd()
	{
		yield return new WaitForSeconds(1.5f);
		gameObject.SetActive(true);
	}

	public void CallHideAction()
	{
		hideAction?.Invoke();
	}

	private void OnClickBuy()
	{
		var buildingInfo = GetBuildingInfoData(BuildingIdx);
		if (buildingInfo == null) return;

		ProcessBuildingBuy(buildingInfo);
	}

	private void OnClickIAP()
	{
		if (ShopSpecialIdx <= 0) return;

		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.InAppPurchaseManager == null) return;

		var packageData = InAppPackageData.FromShopSpecial(ShopSpecialIdx);
		if (packageData == null || string.IsNullOrEmpty(packageData.ProductId)) return;

		gameRoot.ShopSystem.curLocation = Location;
		gameRoot.InAppPurchaseManager.BuyProductID(packageData.ProductId, ShopSpecialIdx, (result) =>
		{
			if (result == InAppPurchaseManager.Result.Success)
			{
				Hide();
			}
		});
	}

	private void OnClickNeedPoint()
	{
		// Show toast or popup indicating the point requirement for this building
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		// Show a toast message about needing more points
	}

	private void OnClickNeedLevel()
	{
		// Show toast or popup indicating the level requirement for this building
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		var buildingInfo = GetBuildingInfoData(BuildingIdx);
		if (buildingInfo == null) return;

		// Show a toast message about needing higher level
	}

	private void ProcessBuildingBuy(BuildingInfoData buildingInfo)
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null) return;

		// Add the building to owned list
		if (gameRoot.UserData != null && gameRoot.UserData.WorldmapData != null &&
			gameRoot.UserData.WorldmapData.BuildingList != null)
		{
			if (!gameRoot.UserData.WorldmapData.BuildingList.Contains(BuildingIdx))
			{
				gameRoot.UserData.WorldmapData.BuildingList.Add(BuildingIdx);
			}
		}

		// Hide the info panel and play effect
		HideForParticle();
	}

	private void OnClickMoveStage()
	{
		var gameRoot = Singleton<GameRoot>.Instance;
		if (gameRoot == null || gameRoot.InGameSystem == null) return;

		// Get the region from the building index
		int region = ProjectUtility.GetBuildingToRegion(BuildingIdx);

		// Navigate to the building's stage
		Hide();
		gameRoot.InGameSystem.ChangeMode(GameType.Main);
	}

	private BuildingInfoData GetBuildingInfoData(int buildingIdx)
	{
		// Look up building info from table data by index
		// BuildingInfoData is populated from FlatBuffer table configs
		return null;
	}
}
