using System;
using UnityEngine;

[EffectPath("Effect/Dust", true, false)]
public class DustEffect : Effect
{
	public Action OnEnd;

	private Vector2 StartPos;

	private Vector2 EndPos;

	private float timeDelta;

	private float duration;

	public void StartAni(Vector2 targetScreenPos)
	{
	}

	private void Update()
	{
	}
}
