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
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitParticleEnd_003Ed__34(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
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

	private void Awake()
	{
	}

	public override void Init(Transform parent, GameType type = GameType.WorldMap)
	{
	}

	public void Set(int buildingIdx, bool upgrade = false, ShopSystem.InAppPurchaseLocation location = ShopSystem.InAppPurchaseLocation.other)
	{
	}

	private void SetIAP()
	{
	}

	private string EarnText(bool before, int type, params object[] args)
	{
		return null;
	}

	public override void Hide()
	{
	}

	public void HideForParticle()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitParticleEnd_003Ed__34))]
	private IEnumerator WaitParticleEnd()
	{
		return null;
	}

	public void CallHideAction()
	{
	}

	private void OnClickBuy()
	{
	}

	private void OnClickIAP()
	{
	}

	private void OnClickNeedPoint()
	{
	}

	private void OnClickNeedLevel()
	{
	}

	private void ProcessBuildingBuy(BuildingInfoData buildingInfo)
	{
	}

	private void OnClickMoveStage()
	{
	}
}
