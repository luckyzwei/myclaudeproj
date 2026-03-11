using UnityEngine;
using UnityEditor;
using UnityEngine.Playables;
using System.IO;

public class TimelineReimporter
{
	[MenuItem("Tools/Reimport All Playable Files")]
	public static void ReimportAllPlayables()
	{
		// Find all .playable files
		string[] playableFiles = Directory.GetFiles(
			Path.Combine(Application.dataPath, "MonoBehaviour"),
			"*.playable",
			SearchOption.TopDirectoryOnly
		);

		foreach (string fullPath in playableFiles)
		{
			string relativePath = "Assets" + fullPath.Substring(Application.dataPath.Length).Replace('\\', '/');
			Debug.Log($"[TimelineReimporter] Reimporting: {relativePath}");
			AssetDatabase.ImportAsset(relativePath, ImportAssetOptions.ForceUpdate);

			var asset = AssetDatabase.LoadAssetAtPath<PlayableAsset>(relativePath);
			if (asset != null)
				Debug.Log($"  -> OK: {asset.name} ({asset.GetType().Name})");
			else
				Debug.LogWarning($"  -> FAILED to load as PlayableAsset!");
		}

		// Also reimport FTUE prefabs that reference the .playable files
		string[] prefabPaths = new[]
		{
			"Assets/Resources/prefabs/popups/Popup-FTUE-SchemeA.prefab",
			"Assets/Resources/prefabs/popups/Popup-FTUE-SchemeB.prefab",
			"Assets/Resources/prefabs/popups/Popup-FTUE-SchemeC.prefab",
			"Assets/Resources/prefabs/popups/Popup-FTUE-Expert.prefab",
		};

		foreach (var prefabPath in prefabPaths)
		{
			if (File.Exists(Path.Combine(Application.dataPath, "..", prefabPath)))
			{
				Debug.Log($"[TimelineReimporter] Reimporting prefab: {prefabPath}");
				AssetDatabase.ImportAsset(prefabPath, ImportAssetOptions.ForceUpdate);
			}
		}

		AssetDatabase.Refresh();
		Debug.Log($"[TimelineReimporter] Done. Reimported {playableFiles.Length} .playable files + prefabs.");
	}

	[MenuItem("Tools/Check Timeline Asset Status")]
	public static void CheckTimelineStatus()
	{
		string[] playableFiles = Directory.GetFiles(
			Path.Combine(Application.dataPath, "MonoBehaviour"),
			"*.playable",
			SearchOption.TopDirectoryOnly
		);

		int total = 0, ok = 0, failed = 0;

		foreach (string fullPath in playableFiles)
		{
			string relativePath = "Assets" + fullPath.Substring(Application.dataPath.Length).Replace('\\', '/');
			var asset = AssetDatabase.LoadAssetAtPath<PlayableAsset>(relativePath);
			total++;

			if (asset != null)
			{
				ok++;
			}
			else
			{
				failed++;
				var obj = AssetDatabase.LoadAssetAtPath<Object>(relativePath);
				if (obj != null)
					Debug.LogWarning($"WRONG TYPE: {relativePath} -> loaded as {obj.GetType().Name}");
				else
					Debug.LogError($"FAILED: {relativePath} -> could not load at all");
			}
		}

		Debug.Log($"[TimelineReimporter] Status: {ok}/{total} OK, {failed} failed");

		// Also check FTUE prefab PlayableDirectors
		CheckPrefabPlayableDirectors("Assets/Resources/prefabs/popups/Popup-FTUE-SchemeA.prefab");
	}

	private static void CheckPrefabPlayableDirectors(string prefabPath)
	{
		var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
		if (prefab == null)
		{
			Debug.LogError($"[TimelineReimporter] Cannot load prefab: {prefabPath}");
			return;
		}

		var directors = prefab.GetComponentsInChildren<PlayableDirector>(true);
		Debug.Log($"[TimelineReimporter] Prefab '{prefab.name}' has {directors.Length} PlayableDirectors:");

		foreach (var dir in directors)
		{
			var pa = dir.playableAsset;
			if (pa != null)
				Debug.Log($"  {dir.gameObject.name}: playableAsset='{pa.name}' ({pa.GetType().Name})");
			else
				Debug.LogWarning($"  {dir.gameObject.name}: playableAsset=NULL!");
		}
	}
}
