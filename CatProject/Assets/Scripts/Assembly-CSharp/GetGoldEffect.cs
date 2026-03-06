using UnityEngine;

[EffectPath("Effect/GetGold", true, false)]
public class GetGoldEffect : Effect
{
	public override void Play(Vector3 worldPos, Transform followTrans)
	{
		base.Play(worldPos, followTrans);
	}
}
