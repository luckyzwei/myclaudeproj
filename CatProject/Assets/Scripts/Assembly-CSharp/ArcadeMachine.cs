using System;
using UnityEngine;

public class ArcadeMachine : BuildingBase
{
	[SerializeField]
	private E_ArcadeMachineType ArcadeMachineType;

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
