using UnityEngine;

public class AndroidVersion
{
	private static AndroidJavaClass versionInfo;

	public static string BASE_OS => null;

	public static string CODENAME => null;

	public static string INCREMENTAL => null;

	public static int PREVIEW_SDK_INT => 0;

	public static string RELEASE => null;

	public static string SDK => null;

	public static int SDK_INT => 0;

	public static string SECURITY_PATCH => null;

	public static string ALL_VERSION => null;

	static AndroidVersion()
	{
	}
}
