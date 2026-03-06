using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		base.Awake();
		if (OpenBtn != null) OpenBtn.onClick.AddListener(OnClickOpen);
		if (GotoPowerRoomBtn != null) GotoPowerRoomBtn.onClick.AddListener(OnClickGotoPowerRoom);
	}

	public void Set(int office)
	{
		OfficeIdx = office;
	}

	public void SetFactory(int factory)
	{
		FactoryIdx = factory;
	}

	private void OnClickOpen()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		Hide();
	}

	private void OnClickGotoPowerRoom()
	{
		Hide();
	}
}
