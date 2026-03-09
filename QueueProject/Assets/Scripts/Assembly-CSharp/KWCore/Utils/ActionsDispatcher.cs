using System;
using System.Collections.Generic;
using UnityEngine;

namespace KWCore.Utils
{
	public class ActionsDispatcher : MonoBehaviour
	{
		private static ActionsDispatcher s_instance;

		private bool m_queued;

		private List<Action> m_backlog;

		private List<Action> m_actions;

		private static int s_mainThreadId;

		public static ActionsDispatcher Instance => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Initialize()
		{
		}

		private void Update()
		{
		}

		private void SwapBacklog()
		{
		}

		private void ExecuteActions()
		{
		}

		private void ClearActions()
		{
		}

		public void RunAsync(Action action)
		{
		}

		public void RunAsync(Action<object> action, object state)
		{
		}

		public void RunOnMainThread(Action action)
		{
		}
	}
}
