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
		InGameSeasonalMode = new WeakReference<InGameSeasonal>(inGameSeasonalMode);
		Disposables = new CompositeDisposable();
		InitBuildingInfos();
		InitStatue();
		yield return null;
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public InGameAstar GetStageAstar()
	{
		return Astar;
	}

	public BuildingBase FindBuilding(E_BuildingType buildingType, int buildingIdx)
	{
		if (StageBuildingList == null) return null;
		for (int i = 0; i < StageBuildingList.Count; i++)
		{
			if (StageBuildingList[i] != null &&
			    StageBuildingList[i].BuildingType == buildingType &&
			    StageBuildingList[i].BuildingIdx == buildingIdx)
				return StageBuildingList[i];
		}
		return null;
	}

	public Transform FindWorkshopEmployeeTransform(int workshopIdx, int workshopTransformIdx)
	{
		if (WorkshopList == null || workshopIdx < 0 || workshopIdx >= WorkshopList.Count) return null;
		var workshop = WorkshopList[workshopIdx];
		if (workshop == null) return null;
		return workshop.transform;
	}

	public Transform FindRestaurantEmployeeTransform(int workshopNumber, int workshopTransformIdx)
	{
		if (Restaurant == null) return null;
		return Restaurant.transform;
	}

	public List<InGameAstar.Node> GetVipPathNodes()
	{
		if (Astar == null) return null;
		if (VipEnterTrans == null || VipEndTrans == null) return null;
		return Astar.FindPath(VipEnterTrans.position, VipEndTrans.position);
	}

	public Vector3 EndVipPos()
	{
		if (VipEndTrans != null)
			return VipEndTrans.position;
		return default(Vector3);
	}

	private void InitBuildingInfos()
	{
		StageBuildingList = new List<BuildingBase>();
		if (WorkshopList != null)
		{
			for (int i = 0; i < WorkshopList.Count; i++)
			{
				if (WorkshopList[i] != null)
					StageBuildingList.Add(WorkshopList[i]);
			}
		}
		if (DormitoryList != null)
		{
			for (int i = 0; i < DormitoryList.Count; i++)
			{
				if (DormitoryList[i] != null)
					StageBuildingList.Add(DormitoryList[i]);
			}
		}
		if (Distributor != null)
			StageBuildingList.Add(Distributor);
		if (Restaurant != null)
			StageBuildingList.Add(Restaurant);
		if (ArcadeMachine != null)
			StageBuildingList.Add(ArcadeMachine);
	}

	private void UpdateNightSkipProperty(AdSupplySystem.Status status)
	{
		if (NightSkipTrans != null)
			NightSkipTrans.gameObject.SetActive(status == AdSupplySystem.Status.Show);
	}

	public void UpdateDayViewState(DaySystem.DayStatus dayStatus, float changeTime)
	{
		if (DayFilter == null || DayFilterInfos == null) return;
		for (int i = 0; i < DayFilterInfos.Count; i++)
		{
			if (DayFilterInfos[i].status == dayStatus)
			{
				DayFilter.color = DayFilterInfos[i].color;
				DayFilter.sortingOrder = DayFilterInfos[i].sortingOrder;
				break;
			}
		}
		UpdateFarsightedObjs(dayStatus);
	}

	private void UpdateFarsightedObjs(DaySystem.DayStatus dayStatus)
	{
		if (FarsightedObjs == null) return;
		for (int i = 0; i < FarsightedObjs.Count; i++)
		{
			var fObj = FarsightedObjs[i];
			if (fObj == null || fObj.obj == null) continue;
			bool active = fObj.time != null && fObj.time.Contains(dayStatus);
			fObj.obj.SetActive(active);
			fObj.On = active;
		}
	}

	private void InitStatue()
	{
		if (Statue != null)
			Statue.Init();
	}
}
