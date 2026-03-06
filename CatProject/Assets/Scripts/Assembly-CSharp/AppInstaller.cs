public static class AppInstaller
{
	public static bool IsAppInstalled(string packageId)
	{
		return CheckAndroidAppInstalled(packageId);
	}

	private static bool CheckAndroidAppInstalled(string packageId)
	{
		if (string.IsNullOrEmpty(packageId)) return false;
		return false;
	}
}
