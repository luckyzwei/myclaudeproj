using System.Collections.Generic;
using UnityEngine;

public class Restaurant : ConstructableBuildingBase
{
	[Header("Restaurant")]
	[SerializeField]
	protected GameObject TableTransParentsObj;

	[SerializeField]
	private Transform FoodUIAttachTransform;

	private InGameSeasonalRestaurantFoodUI RestaurantFoodUI;

	public List<BuildingFacilityInteractiveItem> InteractiveItemList { get; private set; }

	protected override void Awake()
	{
		base.Awake();
		InteractiveItemList = new System.Collections.Generic.List<BuildingFacilityInteractiveItem>();
	}

	protected override void OnOpenedBuilding()
	{
		if (TableTransParentsObj != null)
			TableTransParentsObj.SetActive(true);
		LoadRestaurantUI();
	}

	private void LoadRestaurantUI()
	{
		// TODO
	}
}
