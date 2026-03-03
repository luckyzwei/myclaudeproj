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
	}

	public void ShowSpecialEff()
	{
	}

	public override void Hide()
	{
	}
}
