using UnityEditor;
using System.IO;

/// <summary>
/// Disables Unity's API Updater which crashes on some AssetRipper-exported DLLs.
/// The MovedFromOptimizer NullReferenceException is a known Unity 6 bug with IL2CPP-exported assemblies.
/// </summary>
[InitializeOnLoad]
public static class DisableApiUpdater
{
	static DisableApiUpdater()
	{
		// Ensure the apiupdater skip file exists in project root
		// Unity checks for this file to skip API updating
		string projectRoot = Path.GetDirectoryName(UnityEngine.Application.dataPath);
		string skipFile = Path.Combine(projectRoot, ".apiupdater.skipupdater");
		if (!File.Exists(skipFile))
		{
			File.WriteAllText(skipFile, "Skip API updater - AssetRipper exported DLLs cause MovedFromOptimizer crash");
		}
	}
}
