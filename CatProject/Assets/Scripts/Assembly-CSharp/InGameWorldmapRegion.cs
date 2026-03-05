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
		public _003CWaitArrowUI_003Ed__19(int _003C_003E1__state)
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
					if (_003C_003E4__this.Arrow == null)
					{
						_003C_003E4__this.LoadArrow();
					}
					_003C_003E1__state = 1;
					_003C_003E2__current = null;
					return true;
				case 1:
					_003C_003E1__state = -1;
					if (_003C_003E4__this.Arrow == null)
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
					Cb?.Invoke();
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
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
		public _003CWaitUI_003Ed__21(int _003C_003E1__state)
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
					if (_003C_003E4__this.InfoPopup == null)
					{
						_003C_003E4__this.LoadBuildingInfoUI();
					}
					_003C_003E1__state = 1;
					_003C_003E2__current = null;
					return true;
				case 1:
					_003C_003E1__state = -1;
					if (_003C_003E4__this.InfoPopup == null)
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
					Cb?.Invoke();
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
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
		Region = region;
		if (Zones != null)
		{
			for (int i = 0; i < Zones.Count; i++)
			{
				if (Zones[i] != null)
					Zones[i].gameObject.SetActive(false);
			}
		}
	}

	public void SetActiveEffectZone(bool value)
	{
		if (effectFocusZone != null)
			effectFocusZone.SetActive(value);
	}

	public void FocusCamera(int zone)
	{
		if (ZonesCamPos == null || zone < 0 || zone >= ZonesCamPos.Count) return;
		var camPos = ZonesCamPos[zone];
		if (camPos != null)
		{
			Camera.main.transform.position = camPos.position;
		}
	}

	public void FocusCameraToBuilding(int buildingIdx)
	{
		if (Zones == null) return;
		for (int i = 0; i < Zones.Count; i++)
		{
			if (Zones[i] == null) continue;
			var uiTrans = GetUITrans(buildingIdx);
			if (uiTrans != null)
			{
				FocusCamera(i);
				break;
			}
		}
	}

	public void ShowArrow(int zone)
	{
		StartCoroutine(WaitArrowUI(() =>
		{
			if (Arrow != null && ZonesCamPos != null && zone >= 0 && zone < ZonesCamPos.Count)
			{
				var pos = ZonesCamPos[zone];
				if (pos != null)
				{
					Arrow.Init(pos);
					Arrow.Show();
				}
			}
		}));
	}

	[IteratorStateMachine(typeof(_003CWaitArrowUI_003Ed__19))]
	private IEnumerator WaitArrowUI(Action Cb)
	{
		var d = new _003CWaitArrowUI_003Ed__19(0);
		d._003C_003E4__this = this;
		d.Cb = Cb;
		return d;
	}

	public void WaitInfoUI(Action Cb)
	{
		StartCoroutine(WaitUI(Cb));
	}

	[IteratorStateMachine(typeof(_003CWaitUI_003Ed__21))]
	private IEnumerator WaitUI(Action Cb)
	{
		var d = new _003CWaitUI_003Ed__21(0);
		d._003C_003E4__this = this;
		d.Cb = Cb;
		return d;
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
		if (Zones == null) return;
		for (int i = 0; i < Zones.Count; i++)
		{
			if (Zones[i] != null)
				Zones[i].gameObject.SetActive(true);
		}
	}

	public void ShowBuildingInfo(int buildingIdx, Transform trans, ShopSystem.InAppPurchaseLocation location = ShopSystem.InAppPurchaseLocation.other)
	{
		WaitInfoUI(() =>
		{
			if (InfoPopup != null)
			{
				InfoPopup.Init(trans);
				InfoPopup.Show();
			}
		});
	}

	public Transform GetUITrans(int buildingIdx)
	{
		if (Zones == null) return null;
		for (int i = 0; i < Zones.Count; i++)
		{
			if (Zones[i] == null) continue;
			var zone = Zones[i];
			var trans = zone.transform.Find("Building_" + buildingIdx);
			if (trans != null) return trans;
		}
		return null;
	}

	public void PlayZoneOpenEffect(int idx)
	{
		if (Zones == null || idx < 0 || idx >= Zones.Count) return;
		if (Zones[idx] != null)
			Zones[idx].gameObject.SetActive(true);
	}

	public WorldmapZone GetZone(int zoneIdx)
	{
		if (Zones == null || zoneIdx < 0 || zoneIdx >= Zones.Count) return null;
		return Zones[zoneIdx];
	}

	private void UpdateSpecialTheme()
	{
	}

	private void OnDestroy()
	{
		if (Arrow != null)
		{
			Destroy(Arrow.gameObject);
			Arrow = null;
		}
		if (InfoPopup != null)
		{
			Destroy(InfoPopup.gameObject);
			InfoPopup = null;
		}
		if (specialBG != null)
		{
			Destroy(specialBG);
			specialBG = null;
		}
	}

	public void ClickAdBoard()
	{
	}
}
