using UnityEngine;

namespace KWCore.Native.Huq
{
	public class KWHuqAndroidNative : IKWAndroidNative
	{
		private const string HUQ_API_KEY = "49950e54-027b-40f0-890f-58534c3548e5";

		private AndroidJavaObject huqAndroidLibrary;

		public void Initialize()
		{
		}

		private AndroidJavaObject GetCurrentActivity()
		{
			return null;
		}
	}
}
