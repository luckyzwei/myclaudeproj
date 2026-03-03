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
	}

	public void SetHouse(int houseId)
	{
	}

	private void OnClickGotoBtn()
	{
	}
}
