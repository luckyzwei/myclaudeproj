using UnityEngine;
using UnityEngine.UI;

[EffectPath("Effect/MoneyEffectBubble", false, true)]
public class MoneyEffectBubble : Effect
{
	[SerializeField]
	private Animator ani;

	[SerializeField]
	private Text text;

	public void SetText(string _text, bool playAni = true)
	{
		if (text != null) text.text = _text;
		if (playAni && ani != null) ani.Play(0);
	}

	public void Reset()
	{
		if (text != null) text.text = "";
		if (ani != null) ani.Rebind();
	}
}
