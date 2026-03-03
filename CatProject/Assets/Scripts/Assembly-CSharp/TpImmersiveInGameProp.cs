using System;
using GoogleMobileAds.Api;
using UnityEngine;

public class TpImmersiveInGameProp
{
	private const string _stageAdUnitId = "ca-app-pub-5463897644029535/5614665973";

	private const string _loadingAdUnitId = "ca-app-pub-5463897644029535/7092055711";

	private string placementName;

	private ImmersiveInGameDisplayAd inGameAd;

	private ImmersiveInGameDisplayAd inGameStageAd;

	private Action LoadActoin;

	private AdLoader adLoaderLoading;

	private AdLoader loader;

	public bool loadAd { get; private set; }

	public bool isInit { get; private set; }

	public void Init()
	{
	}

	private void HandleImmersiveInGameDisplayAdLoaded(object sender, ImmersiveInGameDisplayAdEventArgs args)
	{
	}

	public void Load3D(GameObject rootObj, float scale, Action callBack)
	{
	}

	public void Destroy3D()
	{
	}

	public void SetADByCanvas(GameObject rootObj)
	{
	}

	public void LoadAD()
	{
	}

	public void DestroyAD()
	{
	}

	public void OnADPaid(AdValue adValue)
	{
	}

	public void OnADPaid3D(AdValue adValue)
	{
	}

	private void Check_m_Rev(int addRev)
	{
	}
}
