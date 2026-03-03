using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollectionCarList : MonoBehaviour
{
	[SerializeField]
	private Image CarIcon;

	[SerializeField]
	private GameObject OwnObj;

	[SerializeField]
	private Button Btn;

	private int CarIdx;

	private bool IsOwn;

	private Action PurchaseAction;

	private void Awake()
	{
	}

	public void SetCar(int carIdx, Action purchaseCb)
	{
	}

	private void UpdateOwn()
	{
	}

	private void OnBtnClick()
	{
	}
}
