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
	}

	protected override void OnOpenedBuilding()
	{
	}

	private void LoadRestaurantUI()
	{
	}
}
