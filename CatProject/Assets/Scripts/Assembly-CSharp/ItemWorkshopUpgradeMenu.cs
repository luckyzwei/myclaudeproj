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
		Disposables = new CompositeDisposable();
		if (BuildingUpgradeMenuCloseBtn != null)
			BuildingUpgradeMenuCloseBtn.onClick.AddListener(OnClickedUpgradeMenuCloseBtn);
		if (BuildingUpgradeBtn != null)
			BuildingUpgradeBtn.onClick.AddListener(OnClickedUpgradeBtn);
		if (BuildingUpgradeImmediatelyCompleteButton != null)
			BuildingUpgradeImmediatelyCompleteButton.onClick.AddListener(OnClickedUpgradeImmediatelyCompleteButton);
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public void Init(int buildingIdx)
	{
		BuildingIdx = buildingIdx;
		UpdateBuildingUpgradeCondition();
	}

	private void SetBuildingUpgradeCostInfo(int upgradeNeedTime)
	{
		UpgradeNeedTimeSec = upgradeNeedTime;
		if (BuildingUpgradeNeedTimeText != null)
		{
			var ts = TimeSpan.FromSeconds(upgradeNeedTime);
			BuildingUpgradeNeedTimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
		}
	}

	private void OnChangeBuildingConstruction(bool isConstruct)
	{
		if (BuildingUpgradeReadyObj != null)
			BuildingUpgradeReadyObj.SetActive(!isConstruct);
		if (BuildingUpgradingObj != null)
			BuildingUpgradingObj.SetActive(isConstruct);
		if (isConstruct)
			StartCoroutine(UpdateUpgradeTime());
	}

	public bool CheckUpgradeCost()
	{
		IsEnoughCost = true; // Would check actual currency
		return IsEnoughCost;
	}

	private void UpdateBuildingUpgradeCondition()
	{
		CheckUpgradeCost();
		if (BuildingUpgradeBtn != null)
			BuildingUpgradeBtn.interactable = IsEnoughCost;
		if (BuildingUpgradeCostValueText != null)
			BuildingUpgradeCostValueText.text = ProjectUtility.GetThousandCommaText(UpgradeNeedCost_PerMile);
	}

	private void SetBuildingUpgradeImmediatelyCompleteCostText(int valueString)
	{
		BuildingUpgradeImmediatelyCompleteCostValue = valueString;
		if (BuildingUpgradeImmediatelyCompleteCostText != null)
			BuildingUpgradeImmediatelyCompleteCostText.text = valueString.ToString();
	}

	private void OnClickedUpgradeMenuCloseBtn()
	{
		gameObject.SetActive(false);
		OnCloseEvent?.Invoke();
	}

	private void OnClickedUpgradeBtn()
	{
		if (!CheckUpgradeCost()) return;
		OnChangeBuildingConstruction(true);
	}

	private void OnClickedUpgradeImmediatelyCompleteButton()
	{
		// Handle click
	}

	[IteratorStateMachine(typeof(_003CUpdateUpgradeTime_003Ed__30))]
	private IEnumerator UpdateUpgradeTime()
	{
		while (UpgradeCompleteDateTime > DateTime.UtcNow)
		{
			int remainSec = (int)(UpgradeCompleteDateTime - DateTime.UtcNow).TotalSeconds;
			if (remainSec <= 0) break;
			if (BuildingUpgradeTimeText != null)
			{
				var ts = TimeSpan.FromSeconds(remainSec);
				BuildingUpgradeTimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
			}
			if (BuildingUpgradeTimeGauge != null && UpgradeNeedTimeSec > 0)
				BuildingUpgradeTimeGauge.value = 1f - (float)remainSec / UpgradeNeedTimeSec;
			yield return new WaitForSeconds(1f);
		}
		OnChangeBuildingConstruction(false);
	}
}
