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
	}

	public void Set(int office)
	{
	}

	public void UpdateStatus(Room.RoomStatus status, bool onStrike = false, bool onNegotiation = false)
	{
	}

	private void OnClickBtn()
	{
	}

	private bool CheckOnStrike()
	{
		return false;
	}

	private bool CheckOnNegotiation()
	{
		return false;
	}
}
