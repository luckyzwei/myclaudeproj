using System.Collections.Generic;
using UnityEngine;

public class FactoryOrder : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> Trucks;

	private List<Vector3> TruckOriginPos;

	private InGameOrderUI OrderUI;

	public void Init()
	{
		TruckOriginPos = new List<Vector3>();
		if (Trucks != null)
		{
			for (int i = 0; i < Trucks.Count; i++)
			{
				if (Trucks[i] != null)
					TruckOriginPos.Add(Trucks[i].transform.localPosition);
			}
		}
		LoadUI();
		SubscribeEnableOrder();
		SubscribeOrders();
	}

	private void LoadUI()
	{
		// Load order UI prefab
	}

	private void SubscribeEnableOrder()
	{
		// Subscribe to order enable events
	}

	private void SubscribeOrders()
	{
		// Subscribe to order state changes
	}

	private void SetTruck(int order)
	{
		if (Trucks == null || order < 0 || order >= Trucks.Count) return;
		if (Trucks[order] != null) Trucks[order].SetActive(true);
	}

	public void OnClick()
	{
		// Open factory order UI
	}
}
