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
		if (PackageRoot == null) return;
		// Clear existing and rebuild package list
	}

	public void RefreshSeasonal()
	{
		Refresh();
	}

	public void RefreshBizAcquisition(Action onEndAction)
	{
		Refresh();
		onEndAction?.Invoke();
	}

	private void SortPackageList(List<PackageData> packageList)
	{
		// Sort package list
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
