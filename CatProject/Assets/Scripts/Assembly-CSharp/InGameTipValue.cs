using Coffee.UIExtensions;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/TipValue", true)]
[FloatingDepth(2)]
public class InGameTipValue : InGameFloatingUI
{
	[SerializeField]
	private Text MoneyText;

	[SerializeField]
	private UIParticle particle;

	[SerializeField]
	private UIParticle particle_special;

	public void UpdateValue(string value, bool isCritical = false)
	{
		if (MoneyText != null) MoneyText.text = value;
		if (isCritical)
			ShowSpecialEff();
	}

	public void ShowSpecialEff()
	{
		if (particle_special != null) particle_special.gameObject.SetActive(true);
	}

	public override void Hide()
	{
		base.Hide();
		if (particle != null) particle.gameObject.SetActive(false);
		if (particle_special != null) particle_special.gameObject.SetActive(false);
	}
}
