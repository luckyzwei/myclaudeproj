using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/InGame/Progress", false, false)]
public class InGameFarmProgress : InGameFloatingUI
{
	[SerializeField]
	private Image progressImg;

	[SerializeField]
	private Image autoProgressImg;

	[SerializeField]
	private Image productImg;

	[SerializeField]
	private GameObject AutoObject;

	[SerializeField]
	private GameObject NonAutoObject;

	[SerializeField]
	private Text productPrice;

	[SerializeField]
	private Button FacilityUIBtn;

	[SerializeField]
	private GameObject LvUpObj;

	[SerializeField]
	private GameObject FullLvUpObj;

	public Action clickAction;

	private bool auto;

	private void Awake()
	{
	}

	public void UpdateValue(float value)
	{
	}

	public void SetProductImg(Sprite img)
	{
	}

	public void SetPrice(string value)
	{
	}

	public void SetAuto(bool value)
	{
	}

	public void SetLvUpEnable(int step)
	{
	}

	private void OnClickBtn()
	{
	}
}
