namespace UnitTesting.TestCases.EditMode
{
	public class UTAudioInterface
	{
		[UnitTest(TestRunEnvironment.EDIT_MODE, "Audio", "Bootstrap GameObject has AudioInterface component", null, null)]
		public static void UTAudioInterfaceCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Audio", "AudioInterface has AudioMixer reference", null, null)]
		public static void UTAudioMixerRefCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Audio", "AudioInterface has AllSnapshot reference", null, null)]
		public static void UTAllSnapshotRefCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Audio", "AudioInterface has NoneSnapshot reference", null, null)]
		public static void UTNoneSnapshotRefCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Audio", "AudioInterface has MusicSnapshot reference", null, null)]
		public static void UTMusicSnapshotRefCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Audio", "AudioInterface has SFXSnapshot reference", null, null)]
		public static void UTSfxSnapshotRefCheck(UnitTestCallback callback)
		{
		}

		[UnitTest(TestRunEnvironment.EDIT_MODE, "Audio", "AudioInterface has AudioSoundList reference ", null, null)]
		public static void UTAudioSoundListRefCheck(UnitTestCallback callback)
		{
		}
	}
}
