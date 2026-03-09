namespace UnitTesting.TestCases.EditMode
{
	public class UTAdsInterface
	{
		[UnitTest(TestRunEnvironment.EDIT_MODE, "Ads", "Bootstrap GameObject has AdsInterface component", null, null)]
		public static void UTAdsInterfaceCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Ads", "AdsInterface has RewardAdBlocker Prefab reference", null, null)]
		public static void UTAdsInterfacePrefabRefCheck(UnitTestCallback callback)
		{
		}
	}
}
