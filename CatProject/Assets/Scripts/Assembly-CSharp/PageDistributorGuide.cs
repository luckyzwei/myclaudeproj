using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PageSeasonalDockGuide", false, false)]
public class PageDistributorGuide : UIBase
{
	[SerializeField]
	private List<Image> DistributorImgList;

	[SerializeField]
	private List<Image> MainProductIconImgList;

	public void Init(int seasonInfoIdx)
	{
		SetDistributorImgList(seasonInfoIdx);
		SetMainProductImgList(seasonInfoIdx);
	}

	private void SetDistributorImgList(int themeIdx)
	{
		// Resource loading for distributor images - keep empty
	}

	private void SetMainProductImgList(int themeIdx)
	{
		// Resource loading for main product images - keep empty
	}
}
