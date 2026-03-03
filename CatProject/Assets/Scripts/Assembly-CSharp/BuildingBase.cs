using System;
using System.Collections.Generic;
using SeasonalDef;
using UnityEngine;

public class BuildingBase : MonoBehaviour
{
	[Header("Carmera Set")]
	[SerializeField]
	[Range(-15f, 15f)]
	private float xOffset;

	[SerializeField]
	[Range(-15f, 15f)]
	private float yOffset;

	[SerializeField]
	[Range(-15f, 15f)]
	private float zoomSize;

	[Header("Sound")]
	[SerializeField]
	protected string BuildingMenuSoundName;

	[Header("Light")]
	public List<DaySystem.FarsightedObject> FarsightedObjs;

	public int BuildingIdx { get; protected set; }

	public E_BuildingType BuildingType { get; protected set; }

	public bool bFocusable { get; protected set; }

	public bool IsConstructableBuilding { get; protected set; }

	public virtual void Init(in int buildingIdx)
	{
	}

	public virtual void OnSelectedBuilding(Action onSelectedBuilding)
	{
	}

	public virtual void UnselectBuilding(bool bHideUI)
	{
	}

	protected virtual void OnReleaseBuilding()
	{
	}

	protected void PlayBuildingMenuSound()
	{
	}

	public void OnClickedBuilding()
	{
	}

	public void FocusToBuilding()
	{
	}

	private void FocusOut()
	{
	}
}
