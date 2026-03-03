using UnityEngine;

[EffectPath("Effect/Skill/Dice", false, false)]
public class DiceEffect : Effect
{
	[SerializeField]
	private SpriteAnimation ani;

	private void OnEnable()
	{
	}

	public void PlayAnimation(string key)
	{
	}
}
