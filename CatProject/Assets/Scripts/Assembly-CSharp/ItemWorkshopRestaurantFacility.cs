using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemWorkshopRestaurantFacility : MonoBehaviour
{
	[SerializeField]
	private Image FoodIconImage;

	[SerializeField]
	private Text GoodMoodWorkerCountText;

	[SerializeField]
	private Text BadMoodWorkerCountText;

	[SerializeField]
	private Text DecProductionValueText;

	private IDisposable Disposable;

	public void Init()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateWorkersMood()
	{
	}
}
