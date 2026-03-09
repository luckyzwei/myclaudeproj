using System;
using System.Collections.Generic;
using UnityEngine;

public class AppsFlyerActionsDispatcher : MonoBehaviour
{
	private static AppsFlyerActionsDispatcher s_instance;

	private static bool s_queued;

	private static List<Action> s_backlog;

	private static List<Action> s_actions;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Initialize()
	{
	}

	private void Update()
	{
	}

	public static void RunAsync(Action action)
	{
	}

	public static void RunAsync(Action<object> action, object state)
	{
	}

	public static void RunOnMainThread(Action action)
	{
	}
}
