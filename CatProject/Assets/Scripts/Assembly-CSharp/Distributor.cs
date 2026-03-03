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

	public List<DockDistributorObject> GetDistributorObjectList => null;

	public override void Init(in int buildingIdx)
	{
	}

	public override void OnSelectedBuilding(Action onSelectedBuilding)
	{
	}

	public override void UnselectBuilding(bool bHideUI)
	{
	}
}
