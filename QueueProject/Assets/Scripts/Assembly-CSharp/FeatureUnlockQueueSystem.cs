using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class FeatureUnlockQueueSystem
{
	private static List<IQueueableEntity> s_queue;

	private static bool s_isFeatureUnlockShown;

	private static GameplayEvents.BasicDelegate _FeatureUnlockQueueIsFinished;
	public static event GameplayEvents.BasicDelegate FeatureUnlockQueueIsFinished
	{
		[CompilerGenerated]
		add { _FeatureUnlockQueueIsFinished += value; }
		[CompilerGenerated]
		remove { _FeatureUnlockQueueIsFinished -= value; }
	}

	public static void RegisterAction(Action<Action> action, int priority = 2147483647, int locationMask = 65535)
	{
		// Feature unlock not needed for core gameplay
	}

	public static void RegisterUnlockFeature(IQueueableEntity featureUnlockComponent)
	{
		if (s_queue == null) s_queue = new List<IQueueableEntity>();
		if (featureUnlockComponent != null && !s_queue.Contains(featureUnlockComponent))
			s_queue.Add(featureUnlockComponent);
	}

	public static void UnRegisterUnlockFeature(IQueueableEntity featureUnlockComponent)
	{
		if (s_queue != null && featureUnlockComponent != null)
			s_queue.Remove(featureUnlockComponent);
	}

	public static void TriggerUnlockQueue(int locationBitMask)
	{
		TryProcessQueue(locationBitMask);
	}

	private static void TryProcessQueue(int locationBitMask)
	{
		if (s_isFeatureUnlockShown) return;

		var entity = GetHighestPriority(locationBitMask);
		if (entity != null)
		{
			s_isFeatureUnlockShown = true;
			entity.StartProcess(() => OnFeatureUnlockComplete(locationBitMask));
		}
		else
		{
			_FeatureUnlockQueueIsFinished?.Invoke();
		}
	}

	private static IQueueableEntity GetHighestPriority(int locationBitMask)
	{
		if (s_queue == null || s_queue.Count == 0) return null;

		IQueueableEntity best = null;
		int bestPriority = int.MaxValue;

		for (int i = 0; i < s_queue.Count; i++)
		{
			var entity = s_queue[i];
			if (entity == null) continue;
			if ((entity.GetUnlockLocationMask() & locationBitMask) == 0) continue;
			if (entity.GetPriority() < bestPriority)
			{
				bestPriority = entity.GetPriority();
				best = entity;
			}
		}

		if (best != null)
			s_queue.Remove(best);

		return best;
	}

	private static void OnFeatureUnlockComplete(int locationBitMask)
	{
		s_isFeatureUnlockShown = false;
		TryProcessQueue(locationBitMask);
	}
}
