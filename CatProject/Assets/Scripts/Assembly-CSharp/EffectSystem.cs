using System;
using System.Collections.Generic;
using UnityEngine;

public class EffectSystem
{
	private Dictionary<Type, Effect> EffectDic;

	private Dictionary<Type, List<Effect>> MultiEffectDic;

	private Action ForceCollect;

	public void Play<T>(Vector3 worldPos, Action<T> OnLoad = null, Transform followTrans = null) where T : Effect
	{
		if (EffectDic == null) EffectDic = new Dictionary<Type, Effect>();

		Type key = typeof(T);
		if (EffectDic.TryGetValue(key, out Effect existing))
		{
			existing.Play(worldPos, followTrans);
			OnLoad?.Invoke(existing as T);
			return;
		}

		// Would instantiate from prefab pool
		OnLoad?.Invoke(null);
	}

	public void MultiPlay<T>(Vector3 worldPos, Action<T> OnLoad = null, Transform followTrans = null) where T : Effect
	{
		if (MultiEffectDic == null) MultiEffectDic = new Dictionary<Type, List<Effect>>();

		Type key = typeof(T);
		// Would instantiate a new effect instance from pool for multi-play
		OnLoad?.Invoke(null);
	}

	public void Clear()
	{
		if (EffectDic == null) EffectDic = new Dictionary<Type, Effect>();
		if (MultiEffectDic == null) MultiEffectDic = new Dictionary<Type, List<Effect>>();
		EffectDic.Clear();
		MultiEffectDic.Clear();
	}

	public void ReturnMultiEffect<T>(T target) where T : Effect
	{
		ReturnMultiEffect((Effect)target);
	}

	public void ReturnMultiEffect(Effect target)
	{
		if (target == null) return;
		if (MultiEffectDic == null) return;

		Type key = target.GetType();
		if (MultiEffectDic.TryGetValue(key, out var list))
		{
			list.Remove(target);
		}
		// Would return to pool
	}

	public void Stop<T>() where T : Effect
	{
		if (EffectDic == null) return;

		Type key = typeof(T);
		if (EffectDic.TryGetValue(key, out Effect effect))
		{
			if (effect != null && effect.gameObject != null)
			{
				effect.gameObject.SetActive(false);
			}
		}
	}

	public T Get<T>() where T : Effect
	{
		if (EffectDic == null) return null;
		Effect e;
		if (EffectDic.TryGetValue(typeof(T), out e))
			return e as T;
		return null;
	}
}
