using UnityEngine;
using UnityEngine.UI;

[EffectPath("Effect/IconText", false, true)]
public class IconTextEffect : Effect
{
	[SerializeField]
	private Animator ani;

	[SerializeField]
	private Text text;

	[SerializeField]
	private Image Icon;

	private CurrencyIconConvert CurrencyIconConvert;

	public void SetIcon(Config.AtlasType atlasType, string iconKey)
	{
	}

	public void SetText(string _text, bool playAni = true)
	{
	}

	public void Reset()
	{
	}
}
