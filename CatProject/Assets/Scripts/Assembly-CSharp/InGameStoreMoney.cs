using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/InGame/StoreMoney", false, false)]
public class InGameStoreMoney : InGameFloatingUI
{
	[SerializeField]
	private Text StoreMoneyText;

	[SerializeField]
	private Button GetMoneyBtn;

	public Action clickAction;

	private void Awake()
	{
	}

	public void UpdateValue(string value)
	{
	}

	private void OnClickGetMoney()
	{
	}
}
