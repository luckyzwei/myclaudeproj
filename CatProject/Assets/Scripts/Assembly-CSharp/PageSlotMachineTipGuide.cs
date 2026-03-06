using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PageSlotMachineTipGuide", false, false)]
public class PageSlotMachineTipGuide : UIBase
{
	[SerializeField]
	private Image DistributorImg;

	[SerializeField]
	private Image FirstWorkshopImg;

	public void Init(int seasonInfoIdx)
	{
		SetDistributorImg(seasonInfoIdx);
		SetFirstWorkShopImg(seasonInfoIdx);
	}

	private void SetDistributorImg(int themeIdx)
	{
		// Resource loading - keep empty
	}

	private void SetFirstWorkShopImg(int themeIdx)
	{
		// Resource loading - keep empty
	}
}
