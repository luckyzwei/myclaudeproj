using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/RoomUI", true)]
[FloatingDepth(8)]
public class InGameRoomUI : InGameFloatingUI
{
	[SerializeField]
	private Button Btn;

	[SerializeField]
	private GameObject LevelUpObj;

	[SerializeField]
	private GameObject EndCompanyObj;

	[SerializeField]
	private GameObject NewCompanyObj;

	[SerializeField]
	private GameObject MaintenanceObj;

	[SerializeField]
	private GameObject RepairObj;

	[SerializeField]
	private GameObject WorkingObj;

	[SerializeField]
	private GameObject NewRoomObj;

	[SerializeField]
	public GameObject TutorialObj;

	[SerializeField]
	public GameObject MaxLevelObj;

	[SerializeField]
	private GameObject StrikeInfoObj;

	[SerializeField]
	private GameObject StrikeDoneObj;

	private int OfficeIdx;

	private bool OnStrike;

	private bool OnNegotiation;

	private Room.RoomStatus roomStatus;

	private void Awake()
	{
		if (Btn != null)
			Btn.onClick.AddListener(OnClickBtn);
	}

	public void Set(int office)
	{
		OfficeIdx = office;
	}

	public void UpdateStatus(Room.RoomStatus status, bool onStrike = false, bool onNegotiation = false)
	{
		roomStatus = status;
		OnStrike = onStrike;
		OnNegotiation = onNegotiation;
		if (LevelUpObj != null) LevelUpObj.SetActive(status == Room.RoomStatus.LvUp);
		if (EndCompanyObj != null) EndCompanyObj.SetActive(status == Room.RoomStatus.EndCompany);
		if (NewCompanyObj != null) NewCompanyObj.SetActive(status == Room.RoomStatus.NewCompany);
		if (MaintenanceObj != null) MaintenanceObj.SetActive(status == Room.RoomStatus.Maintenance);
		if (RepairObj != null) RepairObj.SetActive(status == Room.RoomStatus.Repair);
		if (WorkingObj != null) WorkingObj.SetActive(status == Room.RoomStatus.None);
		if (NewRoomObj != null) NewRoomObj.SetActive(status == Room.RoomStatus.NewRoom);
		if (MaxLevelObj != null) MaxLevelObj.SetActive(status == Room.RoomStatus.MaxLevel);
		if (StrikeInfoObj != null) StrikeInfoObj.SetActive(onStrike && !onNegotiation);
		if (StrikeDoneObj != null) StrikeDoneObj.SetActive(onStrike && onNegotiation);
	}

	private void OnClickBtn()
	{
		// Open office management popup
	}

	private bool CheckOnStrike()
	{
		return OnStrike;
	}

	private bool CheckOnNegotiation()
	{
		return OnNegotiation;
	}
}
