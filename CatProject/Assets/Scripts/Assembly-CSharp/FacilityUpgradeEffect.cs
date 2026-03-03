using UnityEngine;

[EffectPath("Effect/FacilityUpgrade", false, false)]
public class FacilityUpgradeEffect : Effect
{
	[SerializeField]
	private ParticleSystemRenderer changeRenderer;

	public override void Play(Vector3 worldPos, Transform followTrans)
	{
	}
}
