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
		BuildingIdx = buildingIdx;
		bFocusable = true;
		IsConstructableBuilding = false;
	}

	public virtual void OnSelectedBuilding(Action onSelectedBuilding)
	{
		PlayBuildingMenuSound();
		onSelectedBuilding?.Invoke();
	}

	public virtual void UnselectBuilding(bool bHideUI)
	{
		if (bHideUI)
			OnReleaseBuilding();
	}

	protected virtual void OnReleaseBuilding()
	{
		// Override in subclasses to release building-specific UI
	}

	protected void PlayBuildingMenuSound()
	{
		if (!string.IsNullOrEmpty(BuildingMenuSoundName))
		{
			// Play sound via SoundSystem
		}
	}

	public void OnClickedBuilding()
	{
		if (!bFocusable) return;
		FocusToBuilding();
	}

	public void FocusToBuilding()
	{
		if (!bFocusable) return;
		var cam = Camera.main;
		if (cam != null)
		{
			var pos = cam.transform.position;
			pos.x = transform.position.x + xOffset;
			pos.y = transform.position.y + yOffset;
			cam.transform.position = pos;
			cam.orthographicSize = cam.orthographicSize + zoomSize;
		}
	}

	private void FocusOut()
	{
		var cam = Camera.main;
		if (cam != null)
		{
			cam.orthographicSize = cam.orthographicSize - zoomSize;
		}
	}
}
