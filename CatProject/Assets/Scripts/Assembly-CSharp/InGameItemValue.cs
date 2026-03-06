using Coffee.UIExtensions;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/ItemValue", true)]
[FloatingDepth(2)]
public class InGameItemValue : InGameFloatingUI
{
	[SerializeField]
	private Text MoneyText;

	[SerializeField]
	private UIParticle particle;

	public void UpdateValue(string value, bool isCritical = false)
	{
		if (MoneyText != null) MoneyText.text = value;
		if (isCritical)
			ShowSpecialEff();
	}

	public void ShowSpecialEff()
	{
		if (particle != null) particle.gameObject.SetActive(true);
	}

	public override void Hide()
	{
		base.Hide();
		if (particle != null) particle.gameObject.SetActive(false);
	}
}
