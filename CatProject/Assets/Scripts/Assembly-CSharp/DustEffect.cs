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
		StartPos = transform.position;
		EndPos = targetScreenPos;
		timeDelta = 0f;
		duration = 0.5f;
	}

	private void Update()
	{
		if (duration <= 0f) return;
		timeDelta += Time.deltaTime;
		float t = Mathf.Clamp01(timeDelta / duration);
		transform.position = Vector2.Lerp(StartPos, EndPos, t);
		if (t >= 1f)
		{
			OnEnd?.Invoke();
			gameObject.SetActive(false);
		}
	}
}
