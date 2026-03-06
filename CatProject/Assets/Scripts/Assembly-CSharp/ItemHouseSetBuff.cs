using UnityEngine;
using UnityEngine.UI;

public class ItemHouseSetBuff : MonoBehaviour
{
	[SerializeField]
	private GameObject SetBuffActiveObj;

	[SerializeField]
	private Text SetName;

	[SerializeField]
	private Text SetDesc;

	[SerializeField]
	private Image SetIcon;

	[SerializeField]
	private Transform SetBrandRoot;

	[SerializeField]
	private GameObject SetBrandObj;

	private int ZoneIdx;

	public void SetParkingSet(int zoneIdx)
	{
		// Update display
	}

	public void UpdateSetCarList()
	{
		// Update display
	}
}
