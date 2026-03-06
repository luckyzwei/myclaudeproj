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
		base.Awake();
		if (CloseBtn != null) CloseBtn.onClick.AddListener(Hide);
	}

	public void SetRegion(int regionIdx)
	{
		if (RegionDesc != null) RegionDesc.text = "";
		// Load region image resource
	}
}
