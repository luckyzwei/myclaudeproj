using System.Collections.Generic;
using UnityEngine;

public class BuildingFacility : MonoBehaviour
{
	public enum E_WorkshopFacilityType
	{
		WorkerFacility = 0,
		SubFacility = 1
	}

	[SerializeField]
	private List<SpriteRenderer> FacilityResources;

	[SerializeField]
	private List<bool> FacilityResources_IsReverse;

	[SerializeField]
	public E_WorkshopFacilityType FacilityType;

	public void UpdateFacilityResources(int facilityIdx, int index)
	{
		// Update display
	}

	private void UpdateFacilityResources(List<string> resourceNames)
	{
		// Update display
	}
}
