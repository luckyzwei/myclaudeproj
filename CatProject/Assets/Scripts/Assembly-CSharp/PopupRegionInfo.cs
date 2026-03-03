using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRegionInfo", false, false)]
public class PopupRegionInfo : UIBase
{
	[Header("PopupRegionInfo")]
	[SerializeField]
	private Button CloseBtn;

	[SerializeField]
	private Image RegionImg;

	[SerializeField]
	private Text RegionDesc;

	private readonly string ReadyImg;

	protected override void Awake()
	{
	}

	public void SetRegion(int regionIdx)
	{
	}
}
