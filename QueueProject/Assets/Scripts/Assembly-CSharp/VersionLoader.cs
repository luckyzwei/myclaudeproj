using System.Runtime.InteropServices;

public class VersionLoader
{
	private const string TOOLS_CONFIGS_VERSION = "Tools/Configs/Version.txt";

	public static string Version => null;

	[PreserveSig]
	private static extern string GetVersionFromFile(string filePath);
}
