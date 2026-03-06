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
		if (Btn != null) Btn.onClick.AddListener(OnBtnClick);
	}

	public void SetCar(int carIdx, Action purchaseCb)
	{
		CarIdx = carIdx;
		PurchaseAction = purchaseCb;
		UpdateOwn();
	}

	private void UpdateOwn()
	{
		if (OwnObj != null) OwnObj.SetActive(IsOwn);
	}

	private void OnBtnClick()
	{
		if (!IsOwn)
			PurchaseAction?.Invoke();
	}
}
