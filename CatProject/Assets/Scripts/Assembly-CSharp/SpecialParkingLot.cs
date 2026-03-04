using UnityEngine;

public class SpecialParkingLot : MonoBehaviour
{
	[SerializeField]
	private GameObject LockObj;

	private InGameTouchInfoUI TouchInfoUI;

	private GameObject CarObj;

	public GameObject GetLockObj { get { return null; } }

	public int Idx { get; private set; }

	public ClickCallback ClickCallback { get; private set; }

	public void Init(int idx)
	{
	}

	private void LoadCar()
	{
	}

	private void OnClick()
	{
	}

	private void OnDestroy()
	{
	}
}
