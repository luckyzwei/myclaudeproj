using System;
using System.Collections.Generic;
using UnityEngine;

public class HudPackageComponent : MonoBehaviour
{
	[SerializeField]
	private Transform PackageRoot;

	[Tooltip("Keep Inactive")]
	[SerializeField]
	private GameObject PackageHUDObj;

	public void Refresh()
	{
	}

	public void RefreshSeasonal()
	{
	}

	public void RefreshBizAcquisition(Action onEndAction)
	{
	}

	private void SortPackageList(List<PackageData> packageList)
	{
	}

	private bool CheckGameShowType(int type)
	{
		return false;
	}

	private HudPackageItem FindSamePackageGroupItem(List<HudPackageItem> packageList, int packageGroup)
	{
		return null;
	}
}
