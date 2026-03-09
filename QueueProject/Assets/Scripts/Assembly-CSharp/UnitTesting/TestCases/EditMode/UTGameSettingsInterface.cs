namespace UnitTesting.TestCases.EditMode
{
	public class UTGameSettingsInterface
	{
		[UnitTest(TestRunEnvironment.EDIT_MODE, "GameSettings", "Bootstrap GameObject has GameSettingsInterface Component", null, null)]
		public static void UTGameSettingsInterfaceCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "GameSettings", "GameSettings has GameSetting Scriptable reference", null, null)]
		public static void UTGameSettingScriptableObjectRefCheck(UnitTestCallback callback)
		{
		}
	}
}
