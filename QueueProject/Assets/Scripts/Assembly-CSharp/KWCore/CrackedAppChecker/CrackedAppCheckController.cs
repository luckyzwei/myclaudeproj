namespace KWCore.CrackedAppChecker
{
	public class CrackedAppCheckController
	{
		private const string PLAY_STORE_INSTALLER_NAME = "com.android.vending";

		private const string APP_STORE_INSTALLER_NAME = "appstore.com.apple.AppStore";

		private KWCrackedApkCheckerNative m_crackedAppCheckerNative;

		private void InitialiseCrackedApkCheckerNative()
		{
		}

		public bool IsStoreBuild()
		{
			return false;
		}

		public bool IsCorrectBundleId()
		{
			return false;
		}
	}
}
