using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class FeatureUnlockQueueSystem
{
	private static List<IQueueableEntity> s_queue;

	private static bool s_isFeatureUnlockShown;

	public static event GameplayEvents.BasicDelegate FeatureUnlockQueueIsFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void RegisterAction(Action<Action> action, int priority = 2147483647, int locationMask = 65535)
	{
	}

	public static void RegisterUnlockFeature(IQueueableEntity featureUnlockComponent)
	{
	}

	public static void UnRegisterUnlockFeature(IQueueableEntity featureUnlockComponent)
	{
	}

	public static void TriggerUnlockQueue(int locationBitMask)
	{
	}

	private static void TryProcessQueue(int locationBitMask)
	{
	}

	private static IQueueableEntity GetHighestPriority(int locationBitMask)
	{
		return null;
	}

	private static void OnFeatureUnlockComplete(int locationBitMask)
	{
	}
}
