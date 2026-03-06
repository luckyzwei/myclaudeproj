using System;
using System.Collections.Generic;
using UnityEngine;

public class Distributor : BuildingBase
{
	[Header("Distributor")]
	[SerializeField]
	private float DistributeNextShowDelay;

	[SerializeField]
	private float DistributorObjectProgressScale;

	[SerializeField]
	private List<DockDistributorObject> DistributorObjectList;

	public List<DockDistributorObject> GetDistributorObjectList { get { return DistributorObjectList; } }

	public override void Init(in int buildingIdx)
	{
		base.Init(in buildingIdx);
	}

	public override void OnSelectedBuilding(Action onSelectedBuilding)
	{
		base.OnSelectedBuilding(onSelectedBuilding);
	}

	public override void UnselectBuilding(bool bHideUI)
	{
		base.UnselectBuilding(bHideUI);
	}
}
