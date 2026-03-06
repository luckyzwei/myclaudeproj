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
		LoadUI();
	}

	public override void UnLoad()
	{
		AdsupplyMoneyVip = null;
		NightSkipVip = null;
		SeasonalStage = null;
	}

	public override void LoadUI()
	{
		base.LoadUI();
	}

	public void LoadWorkshopEmployee(Action<WorkshopEmployee> CompCb)
	{
		CompCb?.Invoke(null);
	}

	public void LoadAdsupplyVip(Action<AdSupplyVIP> CompCb)
	{
		CompCb?.Invoke(AdsupplyMoneyVip);
	}

	public void LoadNightSkipVip(Action<NightSkipVIP> CompCb)
	{
		CompCb?.Invoke(NightSkipVip);
	}

	public void FocusToObject(GameObject target, CamOffset camOffset)
	{
		if (target == null || IngameCamera == null) return;
		Vector3 pos = target.transform.position + camOffset.ToVector();
		IngameCamera.FocusPosition(pos, camOffset.zoomSize);
	}

	public void FocusToBuilding(GameObject target, CamOffset camOffset)
	{
		if (target == null || IngameCamera == null) return;
		Vector3 pos = target.transform.position + camOffset.ToVector();
		IngameCamera.FocusPosition(pos, camOffset.zoomSize);
	}

	public void FocusOut()
	{
		if (IngameCamera != null)
			IngameCamera.FocusOut();
	}
}
