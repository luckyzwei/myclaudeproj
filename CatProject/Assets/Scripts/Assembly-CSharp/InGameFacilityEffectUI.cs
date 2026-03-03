using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/InGameFacilityEffectUI", true)]
[FloatingDepth(4)]
public class InGameFacilityEffectUI : InGameFloatingUI
{
	[SerializeField]
	private Image AbilityIcon;

	[SerializeField]
	private Text AbilityValue;

	public void SetAbility(string icon, int value)
	{
	}
}
