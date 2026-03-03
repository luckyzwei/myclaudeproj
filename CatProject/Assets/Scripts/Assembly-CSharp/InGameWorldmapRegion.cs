using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InGameWorldmapRegion : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitArrowUI_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameWorldmapRegion _003C_003E4__this;

		public Action Cb;

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
		public _003CWaitArrowUI_003Ed__19(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWaitUI_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameWorldmapRegion _003C_003E4__this;

		public Action Cb;

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
		public _003CWaitUI_003Ed__21(int _003C_003E1__state)
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
	private List<WorldmapZone> Zones;

	[SerializeField]
	private List<Transform> ZonesCamPos;

	[SerializeField]
	private GameObject effectFocusZone;

	[Header("Cam Bound")]
	public float boundMinX;

	public float boundMaxX;

	public float boundMinY;

	public float boundMaxY;

	[Header("SpecialDay")]
	[SerializeField]
	private Transform bgRoot;

	[SerializeField]
	private GameObject OriginBG;

	private GameObject specialBG;

	private int Region;

	private int StartStage;

	private InGameWorldBuildingInfo InfoPopup;

	private InGameArrow Arrow;

	public void Init(int region)
	{
	}

	public void SetActiveEffectZone(bool value)
	{
	}

	public void FocusCamera(int zone)
	{
	}

	public void FocusCameraToBuilding(int buildingIdx)
	{
	}

	public void ShowArrow(int zone)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitArrowUI_003Ed__19))]
	private IEnumerator WaitArrowUI(Action Cb)
	{
		return null;
	}

	public void WaitInfoUI(Action Cb)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitUI_003Ed__21))]
	private IEnumerator WaitUI(Action Cb)
	{
		return null;
	}

	private void LoadArrow(Action loadCb = null)
	{
	}

	private void LoadBuildingInfoUI(Action loadCb = null)
	{
	}

	public void ShowGuide(int guide)
	{
	}

	public void ShowBuildingUI(int buildingIdx)
	{
	}

	public void ShowBuildingInfo(int buildingIdx, Transform trans, ShopSystem.InAppPurchaseLocation location = ShopSystem.InAppPurchaseLocation.other)
	{
	}

	public Transform GetUITrans(int buildingIdx)
	{
		return null;
	}

	public void PlayZoneOpenEffect(int idx)
	{
	}

	public WorldmapZone GetZone(int zoneIdx)
	{
		return null;
	}

	private void UpdateSpecialTheme()
	{
	}

	private void OnDestroy()
	{
	}

	public void ClickAdBoard()
	{
	}
}
