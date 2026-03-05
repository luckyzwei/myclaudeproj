using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx;
using UnityEngine;

public class WorldmapBuilding : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitUICloseAndOpen_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WorldmapBuilding _003C_003E4__this;

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
		public _003CWaitUICloseAndOpen_003Ed__15(int _003C_003E1__state)
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
	private Transform Trans;

	private InGameWorldBuildingUI buildingUI;

	private bool isInGuide;

	private int ZoneIdx;

	private Config.BuildingType BuildingType;

	private WaitUntil WaitBuildingUIHide;

	private CompositeDisposable disposable;

	public int BuildingIdx { get; private set; }

	public void Init(int idx)
	{
		BuildingIdx = idx;
		disposable = new CompositeDisposable();
		WaitBuildingUIHide = new WaitUntil(() => buildingUI == null || !buildingUI.gameObject.activeSelf);
		LoadSignUI();
	}

	public void SetOpened(bool isOpen)
	{
		if (isOpen)
			ShowBuildingUI(true);
	}

	public void ShowGuide()
	{
		isInGuide = true;
		ShowBuildingUI(true);
	}

	public void ShowBuildingUI(bool value)
	{
		if (buildingUI != null)
			buildingUI.gameObject.SetActive(value);
	}

	[IteratorStateMachine(typeof(_003CWaitUICloseAndOpen_003Ed__15))]
	private IEnumerator WaitUICloseAndOpen()
	{
		yield return WaitBuildingUIHide;
		ShowBuildingUI(true);
	}

	private void LoadSignUI()
	{
		// Load building sign UI via resource system at Trans position
	}

	private void OnClickBuilding(int building)
	{
		if (building != BuildingIdx) return;
		ShowBuildingInfo(ShopSystem.InAppPurchaseLocation.other);
	}

	public void WaitAndShowBuildingInfo(ShopSystem.InAppPurchaseLocation location)
	{
		if (buildingUI != null && buildingUI.gameObject.activeSelf)
			StartCoroutine(WaitUICloseAndOpen());
		else
			ShowBuildingInfo(location);
	}

	private void ShowBuildingInfo(ShopSystem.InAppPurchaseLocation location)
	{
		// Show building info popup for this building
	}

	public Transform GetUITrans()
	{
		return Trans;
	}

	private void OnDestroy()
	{
		if (disposable != null)
		{
			disposable.Dispose();
			disposable = null;
		}
	}
}
