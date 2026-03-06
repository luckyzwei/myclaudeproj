using UnityEngine;

[EffectPath("Effect/Skill/Dice", false, false)]
public class DiceEffect : Effect
{
	[SerializeField]
	private SpriteAnimation ani;

	private void OnEnable()
	{
		// Play default animation
	}

	public void PlayAnimation(string key)
	{
		if (ani != null) ani.Play(key);
	}
}
