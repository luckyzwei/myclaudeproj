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
	}

	public void Reset()
	{
	}
}
