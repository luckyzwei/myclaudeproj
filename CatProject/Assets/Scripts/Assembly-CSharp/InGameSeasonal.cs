using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class InGameSeasonal : InGameMode
{
	[SerializeField]
	private Transform CharacterRoot;

	[SerializeField]
	private AssetReference WorkshopEmployeePrefab;

	[SerializeField]
	private AssetReference AdsupplyVipPref;

	[HideInInspector]
	public AdSupplyVIP AdsupplyMoneyVip;

	[SerializeField]
	private AssetReference NightSkipVipPref;

	[HideInInspector]
	public NightSkipVIP NightSkipVip;

	public InGameSeasonalStage SeasonalStage { get; private set; }

	public override void Load()
	{
	}

	public override void UnLoad()
	{
	}

	public override void LoadUI()
	{
	}

	public void LoadWorkshopEmployee(Action<WorkshopEmployee> CompCb)
	{
	}

	public void LoadAdsupplyVip(Action<AdSupplyVIP> CompCb)
	{
	}

	public void LoadNightSkipVip(Action<NightSkipVIP> CompCb)
	{
	}

	public void FocusToObject(GameObject target, CamOffset camOffset)
	{
	}

	public void FocusToBuilding(GameObject target, CamOffset camOffset)
	{
	}

	public void FocusOut()
	{
	}
}
