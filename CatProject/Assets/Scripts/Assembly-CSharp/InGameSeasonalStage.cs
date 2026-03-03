using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SeasonalDef;
using UniRx;
using UnityEngine;

public class InGameSeasonalStage : MonoBehaviour
{
	[Serializable]
	private struct DayFilterInfo
	{
		public DaySystem.DayStatus status;

		public Color color;

		public int sortingOrder;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public bool adsupplyLoaded;

		public bool nightSkipLoaded;

		public InGameSeasonalStage _003C_003E4__this;

		internal void _003CSet_003Eb__2(AdSupplyVIP vip)
		{
		}

		internal void _003CSet_003Eb__3(NightSkipVIP nightSkip)
		{
		}

		internal bool _003CSet_003Eb__4()
		{
			return false;
		}

		internal bool _003CSet_003Eb__5()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CSet_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameSeasonalStage _003C_003E4__this;

		public InGameSeasonal inGameSeasonalMode;

		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

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
		public _003CSet_003Ed__25(int _003C_003E1__state)
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

	[Header("Road")]
	[SerializeField]
	private InGameAstar Astar;

	[SerializeField]
	private Transform NightSkipTrans;

	[Header("DaySystem")]
	[SerializeField]
	private SpriteRenderer DayFilter;

	[SerializeField]
	private List<DayFilterInfo> DayFilterInfos;

	[SerializeField]
	private List<DaySystem.FarsightedObject> FarsightedObjs;

	[Header("Input Value")]
	[SerializeField]
	private float camOrthographicSize;

	[SerializeField]
	private float cameraFirstZoomSize;

	[SerializeField]
	private float cameraMinXPadding;

	[SerializeField]
	private float cameraMaxXPadding;

	[SerializeField]
	private float cameraMinYPadding;

	[SerializeField]
	private float cameraMaxYPadding;

	[SerializeField]
	public Vector3 BuildingFocusOffset;

	[SerializeField]
	public float BuildingFocusZoomSize;

	[Header("Building")]
	[SerializeField]
	private List<Workshop> WorkshopList;

	[SerializeField]
	private List<Dormitory> DormitoryList;

	[SerializeField]
	private Distributor Distributor;

	[SerializeField]
	private Restaurant Restaurant;

	[SerializeField]
	private ArcadeMachine ArcadeMachine;

	[Header("Adsupply")]
	[SerializeField]
	private Transform VipEnterTrans;

	[SerializeField]
	private Transform VipEndTrans;

	[Header("Statue")]
	[SerializeField]
	private SeasonalStatue Statue;

	private List<BuildingBase> StageBuildingList;

	private WeakReference<InGameSeasonal> InGameSeasonalMode;

	private CompositeDisposable Disposables;

	[IteratorStateMachine(typeof(_003CSet_003Ed__25))]
	public IEnumerator Set(InGameSeasonal inGameSeasonalMode)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public InGameAstar GetStageAstar()
	{
		return null;
	}

	public BuildingBase FindBuilding(E_BuildingType buildingType, int buildingIdx)
	{
		return null;
	}

	public Transform FindWorkshopEmployeeTransform(int workshopIdx, int workshopTransformIdx)
	{
		return null;
	}

	public Transform FindRestaurantEmployeeTransform(int workshopNumber, int workshopTransformIdx)
	{
		return null;
	}

	public List<InGameAstar.Node> GetVipPathNodes()
	{
		return null;
	}

	public Vector3 EndVipPos()
	{
		return default(Vector3);
	}

	private void InitBuildingInfos()
	{
	}

	private void UpdateNightSkipProperty(AdSupplySystem.Status status)
	{
	}

	public void UpdateDayViewState(DaySystem.DayStatus dayStatus, float changeTime)
	{
	}

	private void UpdateFarsightedObjs(DaySystem.DayStatus dayStatus)
	{
	}

	private void InitStatue()
	{
	}
}
