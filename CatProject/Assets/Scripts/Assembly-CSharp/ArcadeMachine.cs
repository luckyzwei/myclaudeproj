using System;
using SeasonalDef;
using UnityEngine;

public class ArcadeMachine : BuildingBase
{
	[SerializeField]
	private E_ArcadeMachineType ArcadeMachineType;

	public override void Init(in int buildingIdx)
	{
		base.Init(buildingIdx);
		BuildingType = E_BuildingType.ArcadeMachine;
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
