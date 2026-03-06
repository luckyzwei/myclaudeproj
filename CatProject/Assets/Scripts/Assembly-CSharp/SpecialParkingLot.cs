using UnityEngine;

public class SpecialParkingLot : MonoBehaviour
{
	[SerializeField]
	private GameObject LockObj;

	private InGameTouchInfoUI TouchInfoUI;

	private GameObject CarObj;

	public GameObject GetLockObj { get { return LockObj; } }

	public int Idx { get; private set; }

	public ClickCallback ClickCallback { get; private set; }

	public void Init(int idx)
	{
		Idx = idx;
		LoadCar();
	}

	private void LoadCar()
	{
		// TODO
	}

	private void OnClick()
	{
		ClickCallback?.TutorialClick();
	}

	private void OnDestroy()
	{
		if (CarObj != null) Object.Destroy(CarObj);
	}
}
