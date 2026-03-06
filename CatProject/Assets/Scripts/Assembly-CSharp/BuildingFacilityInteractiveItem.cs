using System.Collections.Generic;
using UnityEngine;

public class BuildingFacilityInteractiveItem : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> UseOnObjs;

	[SerializeField]
	private List<GameObject> UseOffObjs;

	private bool bOnItems;

	public void Awake()
	{
		// Initialize
	}

	public void SetOnOff(bool bOn)
	{
		// Update display
	}
}
