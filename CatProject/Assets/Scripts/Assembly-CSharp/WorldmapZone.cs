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

	public InGameZoneUI ZoneUI => null;

	public Transform ZoneTrans => null;

	public void Init(int zoneidx, bool notopen = false)
	{
	}

	public void SetOpened(bool playTweens)
	{
	}

	public void GuideStage()
	{
	}

	public void ShowUI(int buildingIdx = -1)
	{
	}

	private void LoadZoneUI()
	{
	}

	public void OpenZone()
	{
	}

	public void PlayZoneOpenEffect()
	{
	}

	public WorldmapBuilding GetBuilding(int idx)
	{
		return null;
	}
}
