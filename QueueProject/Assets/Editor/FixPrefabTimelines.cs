using UnityEngine;
using UnityEditor;
using UnityEngine.Playables;

/// <summary>
/// One-time fix: reassign PlayableAsset references in FTUE prefabs.
/// The prefab was imported when .playable files were broken, so cached references are NULL.
/// This script re-resolves them and saves the prefab.
/// </summary>
public class FixPrefabTimelines
{
	[MenuItem("Tools/Fix FTUE Prefab Timeline References")]
	public static void Fix()
	{
		string[] prefabPaths = new[]
		{
			"Assets/Resources/prefabs/popups/Popup-FTUE-SchemeA.prefab",
			"Assets/Resources/prefabs/popups/Popup-FTUE-SchemeB.prefab",
			"Assets/Resources/prefabs/popups/Popup-FTUE-SchemeC.prefab",
			"Assets/Resources/prefabs/popups/Popup-FTUE-Expert.prefab",
		};

		// Also fix tutorial popups
		string[] tutorialPrefabs = new[]
		{
			"Assets/Resources/prefabs/popups/PopUp-Tutorial-SchemeA.prefab",
			"Assets/Resources/prefabs/popups/PopUp-Tutorial-SchemeB.prefab",
			"Assets/Resources/prefabs/popups/PopUp-Tutorial-SchemeC.prefab",
			"Assets/Resources/prefabs/popups/PopUp-Tutorial-Expert.prefab",
		};

		int totalFixed = 0;

		foreach (var path in prefabPaths)
			totalFixed += FixPrefab(path);

		foreach (var path in tutorialPrefabs)
			totalFixed += FixPrefab(path);

		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();

		Debug.Log($"[FixPrefabTimelines] Done! Fixed {totalFixed} PlayableDirector references total.");
	}

	private static int FixPrefab(string prefabPath)
	{
		var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
		if (prefab == null)
		{
			Debug.Log($"[FixPrefabTimelines] Prefab not found: {prefabPath}");
			return 0;
		}

		// Open prefab for editing
		var prefabRoot = PrefabUtility.LoadPrefabContents(prefabPath);
		if (prefabRoot == null)
		{
			Debug.LogError($"[FixPrefabTimelines] Cannot load prefab contents: {prefabPath}");
			return 0;
		}

		var directors = prefabRoot.GetComponentsInChildren<PlayableDirector>(true);
		int fixedCount = 0;
		bool changed = false;

		Debug.Log($"[FixPrefabTimelines] Checking '{prefab.name}' - {directors.Length} PlayableDirectors");

		foreach (var dir in directors)
		{
			if (dir.playableAsset != null)
			{
				Debug.Log($"  OK: {dir.gameObject.name} -> {dir.playableAsset.name}");
				continue;
			}

			// playableAsset is NULL - try to find it by name
			string objName = dir.gameObject.name;
			PlayableAsset found = FindPlayableByName(objName);

			if (found != null)
			{
				dir.playableAsset = found;
				fixedCount++;
				changed = true;
				Debug.Log($"  FIXED: {objName} -> {found.name} ({found.GetType().Name})");
			}
			else
			{
				Debug.LogWarning($"  NOT FOUND: {objName} - no matching .playable file");
			}
		}

		if (changed)
		{
			PrefabUtility.SaveAsPrefabAsset(prefabRoot, prefabPath);
			Debug.Log($"  Saved prefab: {prefabPath} ({fixedCount} fixed)");
		}

		PrefabUtility.UnloadPrefabContents(prefabRoot);
		return fixedCount;
	}

	private static PlayableAsset FindPlayableByName(string gameObjectName)
	{
		// Search for .playable files matching the GameObject name
		string[] searchPaths = new[] { "Assets/MonoBehaviour" };
		string[] guids = AssetDatabase.FindAssets($"t:PlayableAsset {gameObjectName}", searchPaths);

		foreach (var guid in guids)
		{
			string path = AssetDatabase.GUIDToAssetPath(guid);
			var asset = AssetDatabase.LoadAssetAtPath<PlayableAsset>(path);
			if (asset != null && asset.name == gameObjectName)
				return asset;
		}

		// Try broader search
		guids = AssetDatabase.FindAssets($"t:PlayableAsset", searchPaths);
		foreach (var guid in guids)
		{
			string path = AssetDatabase.GUIDToAssetPath(guid);
			var asset = AssetDatabase.LoadAssetAtPath<PlayableAsset>(path);
			if (asset != null && asset.name == gameObjectName)
				return asset;
		}

		return null;
	}
}
