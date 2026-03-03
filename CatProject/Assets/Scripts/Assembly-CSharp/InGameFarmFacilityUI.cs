using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatingDepth(1)]
[FloatUIPath("UI/InGame/FacilityUI", true)]
public class InGameFarmFacilityUI : InGameFloatingUI
{
	[SerializeField]
	private Slider productSlider;

	[SerializeField]
	private Text productUpgradeValue;

	[SerializeField]
	private Text facilityLv;

	[SerializeField]
	private ButtonPressed UpgradeBtn;

	public Action clickAction;

	private void Awake()
	{
	}

	public void UpdateLv(string lv, float value)
	{
	}

	public void SetUpgradeBtn(bool value)
	{
	}

	public void SetUpgradeValue(string value)
	{
	}

	private void OnClickUpgrade()
	{
	}
}
