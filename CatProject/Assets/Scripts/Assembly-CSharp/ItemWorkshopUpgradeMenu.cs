using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using System.Runtime.CompilerServices;
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemWorkshopUpgradeMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateUpgradeTime_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemWorkshopUpgradeMenu _003C_003E4__this;

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
		public _003CUpdateUpgradeTime_003Ed__30(int _003C_003E1__state)
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

	[SerializeField]
	private GameObject BuildingUpgradeReadyObj;

	[SerializeField]
	private GameObject BuildingUpgradingObj;

	[SerializeField]
	private Button BuildingUpgradeMenuCloseBtn;

	[SerializeField]
	private Button BuildingUpgradeBtn;

	[SerializeField]
	private Image BuildingUpgradeCostImage;

	[SerializeField]
	private Text BuildingUpgradeCostValueText;

	[SerializeField]
	private Text BuildingUpgradeNeedTimeText;

	[SerializeField]
	private Text BuildingUpgradeTimeText;

	[SerializeField]
	private Slider BuildingUpgradeTimeGauge;

	[SerializeField]
	private Button BuildingUpgradeImmediatelyCompleteButton;

	[SerializeField]
	private Text BuildingUpgradeImmediatelyCompleteCostText;

	private int BuildingIdx;

	private BigInteger UpgradeNeedCost_PerMile;

	public bool IsEnoughCost;

	private int UpgradeNeedTimeSec;

	private DateTime UpgradeCompleteDateTime;

	private int BuildingUpgradeImmediatelyCompleteCostValue;

	private CompositeDisposable Disposables;

	public UnityAction OnCloseEvent;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(int buildingIdx)
	{
	}

	private void SetBuildingUpgradeCostInfo(int upgradeNeedTime)
	{
	}

	private void OnChangeBuildingConstruction(bool isConstruct)
	{
	}

	public bool CheckUpgradeCost()
	{
		return false;
	}

	private void UpdateBuildingUpgradeCondition()
	{
	}

	private void SetBuildingUpgradeImmediatelyCompleteCostText(int valueString)
	{
	}

	private void OnClickedUpgradeMenuCloseBtn()
	{
	}

	private void OnClickedUpgradeBtn()
	{
	}

	private void OnClickedUpgradeImmediatelyCompleteButton()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateUpgradeTime_003Ed__30))]
	private IEnumerator UpdateUpgradeTime()
	{
		yield break;
	}
}
