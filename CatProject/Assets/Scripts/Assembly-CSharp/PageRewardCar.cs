using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PageRewardCar", false, false)]
public class PageRewardCar : UIBase
{
	[Serializable]
	private class RewardObj
	{
		[SerializeField]
		public GameObject Root;

		[SerializeField]
		public Image Icon;

		[SerializeField]
		public Text Count;
	}

	[SerializeField]
	private Text Title;

	[SerializeField]
	private Image RewardImg;

	[SerializeField]
	private Text RewardName;

	[SerializeField]
	private List<RewardObj> Rewards;

	[SerializeField]
	private Button EquipBtn;

	[SerializeField]
	private GameObject EquipCompObj;

	private int CarIdx;

	protected override void Awake()
	{
		base.Awake();
		if (EquipBtn != null) EquipBtn.onClick.AddListener(OnClickEquipCar);
	}

	public void ShowCarPurchase(int carIdx)
	{
		CarIdx = carIdx;
		if (EquipBtn != null) EquipBtn.gameObject.SetActive(true);
		if (EquipCompObj != null) EquipCompObj.SetActive(false);
	}

	private void OnClickEquipCar()
	{
		if (EquipBtn != null) EquipBtn.gameObject.SetActive(false);
		if (EquipCompObj != null) EquipCompObj.SetActive(true);
	}

	public override void Hide()
	{
		base.Hide();
	}
}
