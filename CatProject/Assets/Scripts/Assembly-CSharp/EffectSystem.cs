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
	}

	public void MultiPlay<T>(Vector3 worldPos, Action<T> OnLoad = null, Transform followTrans = null) where T : Effect
	{
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
	}

	public void ReturnMultiEffect(Effect target)
	{
	}

	public void Stop<T>() where T : Effect
	{
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
