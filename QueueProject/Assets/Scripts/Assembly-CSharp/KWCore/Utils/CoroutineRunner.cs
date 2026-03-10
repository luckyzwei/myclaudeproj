using System.Collections;
using UnityEngine;

namespace KWCore
{
	public class CoroutineRunner : MonoBehaviour
	{
		private static CoroutineRunner s_instance;

		private static CoroutineRunner GetInstance()
		{
			if (s_instance == null)
			{
				var go = new GameObject("[CoroutineRunner]");
				Object.DontDestroyOnLoad(go);
				s_instance = go.AddComponent<CoroutineRunner>();
			}
			return s_instance;
		}

		public static Coroutine Run(IEnumerator routine)
		{
			return GetInstance().StartCoroutine(routine);
		}

		public static void Stop(Coroutine coroutine)
		{
			if (coroutine != null && s_instance != null)
				s_instance.StopCoroutine(coroutine);
		}
	}
}
