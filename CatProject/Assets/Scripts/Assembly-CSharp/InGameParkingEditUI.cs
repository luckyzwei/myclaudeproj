using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/OutGame/InGameParkingEditUI", true)]
[FloatingDepth(12)]
public class InGameParkingEditUI : InGameFloatingUI
{
	[SerializeField]
	private GameObject SelectObj;

	[SerializeField]
	private GameObject ConfirmObj;

	[SerializeField]
	private GameObject CancelObj;

	[SerializeField]
	private Button Btn;

	private InGameHouse InGameHouse;

	private int ParkingZone;

	private int ParkingSpace;

	private void Awake()
	{
	}

	public void Set(int zone, int space)
	{
	}

	public void UpdateStatus()
	{
	}

	private void OnClickBtn()
	{
	}
}
