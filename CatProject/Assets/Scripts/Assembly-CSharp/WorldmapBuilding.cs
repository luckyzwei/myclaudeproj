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
	}

	public void SetOpened(bool isOpen)
	{
	}

	public void ShowGuide()
	{
	}

	public void ShowBuildingUI(bool value)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitUICloseAndOpen_003Ed__15))]
	private IEnumerator WaitUICloseAndOpen()
	{
		return null;
	}

	private void LoadSignUI()
	{
	}

	private void OnClickBuilding(int building)
	{
	}

	public void WaitAndShowBuildingInfo(ShopSystem.InAppPurchaseLocation location)
	{
	}

	private void ShowBuildingInfo(ShopSystem.InAppPurchaseLocation location)
	{
	}

	public Transform GetUITrans()
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
