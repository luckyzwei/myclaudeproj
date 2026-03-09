using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class AppInstallSchema : OpenSchema
	{
		public void UpdateCountryCode()
		{
		}

		public void UpdateAppsFlyerID()
		{
		}

		protected override string GetUniqueKeyForJoin()
		{
			return null;
		}
	}
}
