using System;

namespace UnitTesting
{
	[Serializable]
	public class KwaleeUnitTestInfo
	{
		public string groupName;

		public string testName;

		public bool result;

		public string extraInfo;

		public string maxSupportVersion;

		public string minSupportVersion;
	}
}
