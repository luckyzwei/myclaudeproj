using UnityEngine;
using UnityEngine.UI;

[EffectPath("Effect/ClickFacility", false, true)]
public class ClickFacilityEffect : Effect
{
	[SerializeField]
	private Animator ani;

	[SerializeField]
	private Text text;

	public void SetText(string _text)
	{
		// Update display
	}
}
