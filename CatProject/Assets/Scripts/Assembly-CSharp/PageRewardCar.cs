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
	}

	public void ShowCarPurchase(int carIdx)
	{
	}

	private void OnClickEquipCar()
	{
	}

	public override void Hide()
	{
	}
}
