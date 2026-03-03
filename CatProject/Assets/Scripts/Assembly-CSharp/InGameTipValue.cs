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
	}

	public void ShowSpecialEff()
	{
	}

	public override void Hide()
	{
	}
}
