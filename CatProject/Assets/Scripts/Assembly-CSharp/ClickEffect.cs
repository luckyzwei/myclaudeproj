using UnityEngine;

[EffectPath("Effect/Click", true, false)]
public class ClickEffect : Effect
{
	[SerializeField]
	private ParticleSystemRenderer changeRenderer;

	public override void Play(Vector3 worldPos, Transform followTrans)
	{
	}
}
