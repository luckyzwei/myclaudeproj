using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupOfficeOpen", false, false)]
public class PopupOfficeOpen : UIBase
{
	[SerializeField]
	private Text Title;

	[SerializeField]
	private Image RoomImg;

	[SerializeField]
	private Text RoomName;

	[SerializeField]
	private Text RoomDesc;

	[SerializeField]
	private Text NeedPowerText;

	[SerializeField]
	private Text NeedTimeText;

	[SerializeField]
	private Text NeedPriceText;

	[SerializeField]
	private Button OpenBtn;

	[SerializeField]
	private Button GotoPowerRoomBtn;

	[SerializeField]
	private Image NeedPowerImg;

	private int FactoryIdx;

	private int OfficeIdx;

	private BigInteger NeedMoney;

	private int NeedPower;

	protected override void Awake()
	{
	}

	public void Set(int office)
	{
	}

	public void SetFactory(int factory)
	{
	}

	private void OnClickOpen()
	{
	}

	private void OnClickGotoPowerRoom()
	{
	}
}
