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
		// Resource/atlas loading for icon - keep empty
	}

	public void SetText(string _text, bool playAni = true)
	{
		if (text != null) text.text = _text;
		if (playAni && ani != null) ani.SetTrigger("Play");
	}

	public void Reset()
	{
		if (text != null) text.text = "";
		if (Icon != null) Icon.sprite = null;
		if (ani != null) ani.Rebind();
	}
}
