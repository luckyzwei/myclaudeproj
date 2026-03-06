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
		if (Btn != null) Btn.onClick.AddListener(OnClickBtn);
	}

	public void Set(int zone, int space)
	{
		ParkingZone = zone;
		ParkingSpace = space;
		UpdateStatus();
	}

	public void UpdateStatus()
	{
		if (SelectObj != null) SelectObj.SetActive(false);
		if (ConfirmObj != null) ConfirmObj.SetActive(false);
		if (CancelObj != null) CancelObj.SetActive(false);
	}

	private void OnClickBtn()
	{
		// Handle click
	}
}
