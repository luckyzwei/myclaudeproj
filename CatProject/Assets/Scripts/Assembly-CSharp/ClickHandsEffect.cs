using UnityEngine;

[EffectPath("Effect/ClickHands", true, false)]
public class ClickHandsEffect : Effect
{
	[SerializeField]
	private Vector3 paddingVec;

	public override void Play(Vector3 worldPos, Transform followTrans)
	{
	}
}
