using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupParkinglotNeedHouse", false, false)]
public class PopupParkinglotNeedHouse : UIBase
{
	[SerializeField]
	private Image HouseImg;

	[SerializeField]
	private Text HouseDesc;

	[SerializeField]
	private Button GotoBtn;

	private int HouseIdx;

	protected override void Awake()
	{
		base.Awake();
		if (GotoBtn != null) GotoBtn.onClick.AddListener(OnClickGotoBtn);
	}

	public void SetHouse(int houseId)
	{
		HouseIdx = houseId;
	}

	private void OnClickGotoBtn()
	{
		Hide();
	}
}
