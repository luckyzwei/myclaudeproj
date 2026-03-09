namespace UnitTesting.TestCases.EditMode
{
	public class UTCoreUIInterface
	{
		[UnitTest(TestRunEnvironment.EDIT_MODE, "Core", "Bootstrap GameObject has CoreUIInterface component", null, null)]
		public static void UTCoreUIInterfaceCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Core", "CoreUIInterface has InfoPopUp Prefab reference", null, null)]
		public static void UTInfoPopUpPrefabRefCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Core", "CoreUIInterface has ForceConnectionPopUp Prefab reference", null, null)]
		public static void UTForceConnectionPopUpPrefabRefCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Core", "CoreUIInterface has KwaleeCanvas reference", null, null)]
		public static void UTKwaleeCanvasRefCheck(UnitTestCallback callback)
		{
		}
	}
}
