using UnityEngine;

namespace KWCore.CrackedAppChecker
{
	public class KWCrackedApkCheckerNative
	{
		private AndroidJavaObject library;

		public void Initialize()
		{
		}

		public bool DoesPackageNameMatch()
		{
			return false;
		}

		private AndroidJavaObject GetCurrentActivity()
		{
			return null;
		}
	}
}
