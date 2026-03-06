using System.Collections.Generic;
using UnityEngine;

public class WorldmapZone : MonoBehaviour
{
	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject UnLockObj;

	[SerializeField]
	private List<WorldmapBuilding> Buildings;

	[SerializeField]
	private Transform UITrans;

	[SerializeField]
	private Transform NameTrans;

	[SerializeField]
	private GameObject OpenEffect;

	private InGameZoneUI zoneUI;

	private InGameZoneNotOpen zoneNotOpenUI;

	private InGameZoneName zoneName;

	private bool Waitzone;

	public int Idx { get; private set; }

	public InGameZoneUI ZoneUI { get { return zoneUI; } }

	public Transform ZoneTrans { get { return UITrans; } }

	public void Init(int zoneidx, bool notopen = false)
	{
		Idx = zoneidx;
		Waitzone = false;
		if (notopen)
		{
			if (LockObj != null) LockObj.SetActive(true);
			if (UnLockObj != null) UnLockObj.SetActive(false);
		}
		else
		{
			SetOpened(false);
		}
		if (Buildings != null)
		{
			for (int i = 0; i < Buildings.Count; i++)
			{
				if (Buildings[i] != null)
					Buildings[i].Init(Buildings[i].BuildingIdx);
			}
		}
	}

	public void SetOpened(bool playTweens)
	{
		if (LockObj != null) LockObj.SetActive(false);
		if (UnLockObj != null) UnLockObj.SetActive(true);
		if (playTweens && OpenEffect != null)
			OpenEffect.SetActive(true);
	}

	public void GuideStage()
	{
		ShowUI();
	}

	public void ShowUI(int buildingIdx = -1)
	{
		if (zoneUI != null)
		{
			zoneUI.gameObject.SetActive(true);
		}
		else
		{
			LoadZoneUI();
		}
	}

	private void LoadZoneUI()
	{
	}

	public void OpenZone()
	{
		SetOpened(true);
	}

	public void PlayZoneOpenEffect()
	{
		if (OpenEffect != null)
			OpenEffect.SetActive(true);
	}

	public WorldmapBuilding GetBuilding(int idx)
	{
		if (Buildings == null) return null;
		for (int i = 0; i < Buildings.Count; i++)
		{
			if (Buildings[i] != null && Buildings[i].BuildingIdx == idx)
				return Buildings[i];
		}
		return null;
	}
}
