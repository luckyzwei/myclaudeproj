namespace UnitTesting.TestCases.EditMode
{
	public class UTGameCore
	{
		[UnitTest(TestRunEnvironment.EDIT_MODE, "GameCore", "Bootstrap GameObject has GameCoreInterface Component", null, null)]
		public static void GameCoreInterfaceTest(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "GameCore", "LoadingScreen Prefab Has been Link", null, null)]
		public static void PrefabLinked(UnitTestCallback callback)
		{
		}
	}
}
