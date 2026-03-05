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
		if (UpgradeBtn != null)
			UpgradeBtn.OnPressed = OnClickUpgrade;
	}

	public void UpdateLv(string lv, float value)
	{
		if (facilityLv != null)
			facilityLv.text = lv;
		if (productSlider != null)
			productSlider.value = Mathf.Clamp01(value);
	}

	public void SetUpgradeBtn(bool value)
	{
		if (UpgradeBtn != null)
			UpgradeBtn.gameObject.SetActive(value);
	}

	public void SetUpgradeValue(string value)
	{
		if (productUpgradeValue != null)
			productUpgradeValue.text = value;
	}

	private void OnClickUpgrade()
	{
		clickAction?.Invoke();
	}
}
