using System;

namespace UnitTesting
{
	[AttributeUsage(AttributeTargets.Method)]
	public class UnitTestAttribute : Attribute
	{
		public string GroupName { get; }

		public string TestName { get; }

		public TestRunEnvironment TestRunEnvironment { get; }

		public Version MaxSDKSupportedVersion { get; }

		public Version MinSDKSupportedVersion { get; }

		public UnitTestAttribute(TestRunEnvironment testRunEnvironment, string groupName, string testName, string maxSDKSupportedVersion = null, string minSDKSupportedVersion = null)
		{
		}
	}
}
