using UnityEngine;
using UnityEngine.SceneManagement;

namespace Crosstales.Common.Util
{
	public class SingletonHelper
	{
		private static bool isInitialized;

		public static bool isQuitting { get; set; }

		static SingletonHelper()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		private static void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private static void onQuitting()
		{
		}
	}
}
