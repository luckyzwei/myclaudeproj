using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary>
/// Addressables replacement shim for AssetRipper-exported projects.
/// Resolves asset keys (paths/GUIDs) to actual project assets without Addressables catalogs.
/// </summary>
public static class AddressableShim
{
	private static Dictionary<string, Object> cache = new Dictionary<string, Object>();

	// Known character prefab paths
	private static readonly Dictionary<string, string> KnownPaths = new Dictionary<string, string>
	{
		// Employee character models (S1 set)
		{ "Character/Employee_0", "Assets/Arts/Prefabs/Ingame/Character/Character_Employee_S1/Character_Employee_S1_001.prefab" },
		{ "Character/Employee_1", "Assets/Arts/Prefabs/Ingame/Character/Character_Employee_S1/Character_Employee_S1_002.prefab" },
		{ "Character/Employee_2", "Assets/Arts/Prefabs/Ingame/Character/Character_Employee_S1/Character_Employee_S1_003.prefab" },
		{ "Character/Employee_3", "Assets/Arts/Prefabs/Ingame/Character/Character_Employee_S1/Character_Employee_S1_004.prefab" },
		{ "Character/Employee_4", "Assets/Arts/Prefabs/Ingame/Character/Character_Employee_S1/Character_Employee_S1_005.prefab" },
		{ "Character/Employee_5", "Assets/Arts/Prefabs/Ingame/Character/Character_Employee_S1/Character_Employee_S1_006.prefab" },
		{ "Character/Employee_6", "Assets/Arts/Prefabs/Ingame/Character/Character_Employee_S1/Character_Employee_S1_007.prefab" },
		{ "Character/Employee_7", "Assets/Arts/Prefabs/Ingame/Character/Character_Employee_S1/Character_Employee_S1_008.prefab" },
		// CEO costume models
		{ "Character/Ceo_0", "Assets/Arts/Prefabs/Ingame/Character/Character_Ceo_01.prefab" },
		{ "Character/Ceo_1", "Assets/Arts/Prefabs/Ingame/Character/Character_Ceo_02.prefab" },
		{ "Character/Ceo_2", "Assets/Arts/Prefabs/Ingame/Character/Character_Ceo_03.prefab" },
	};

	/// <summary>
	/// Load asset by key string (Addressables-compatible path or GUID).
	/// Falls back to searching project assets in Editor.
	/// </summary>
	public static T LoadAsset<T>(string key) where T : Object
	{
		if (string.IsNullOrEmpty(key)) return null;

		// Check cache
		if (cache.TryGetValue(key, out var cached) && cached != null)
			return cached as T;

		T result = null;

#if UNITY_EDITOR
		// Try known paths first
		if (KnownPaths.TryGetValue(key, out string knownPath))
		{
			result = AssetDatabase.LoadAssetAtPath<T>(knownPath);
			if (result != null)
			{
				cache[key] = result;
				return result;
			}
		}

		// Try as direct asset path
		result = AssetDatabase.LoadAssetAtPath<T>(key);
		if (result != null)
		{
			cache[key] = result;
			return result;
		}

		// Try with common prefab extensions
		if (!key.EndsWith(".prefab") && !key.EndsWith(".asset"))
		{
			result = AssetDatabase.LoadAssetAtPath<T>(key + ".prefab");
			if (result != null) { cache[key] = result; return result; }
		}

		// Try as GUID
		string guidPath = AssetDatabase.GUIDToAssetPath(key);
		if (!string.IsNullOrEmpty(guidPath))
		{
			result = AssetDatabase.LoadAssetAtPath<T>(guidPath);
			if (result != null) { cache[key] = result; return result; }
		}

		// Try searching in common locations
		string[] searchPaths = new[]
		{
			"Assets/Arts/Prefabs/Ingame/" + key + ".prefab",
			"Assets/Arts/Prefabs/Ingame/Character/" + key + ".prefab",
			"Assets/Arts/Prefabs/" + key + ".prefab",
			"Assets/Arts/Prefabs/HUD/" + key + ".prefab",
		};
		foreach (var path in searchPaths)
		{
			result = AssetDatabase.LoadAssetAtPath<T>(path);
			if (result != null) { cache[key] = result; return result; }
		}

		// Last resort: search by filename
		string filename = System.IO.Path.GetFileNameWithoutExtension(key);
		string[] guids = AssetDatabase.FindAssets(filename + " t:" + typeof(T).Name);
		if (guids.Length > 0)
		{
			string assetPath = AssetDatabase.GUIDToAssetPath(guids[0]);
			result = AssetDatabase.LoadAssetAtPath<T>(assetPath);
			if (result != null) { cache[key] = result; return result; }
		}
#endif

		// Try Resources.Load as final fallback
		result = Resources.Load<T>(key);
		if (result != null) { cache[key] = result; return result; }

		return null;
	}

	/// <summary>
	/// Load asset by AssetReference GUID. Used by the Addressables shim.
	/// </summary>
	public static T LoadByGuid<T>(string guid) where T : Object
	{
		if (string.IsNullOrEmpty(guid)) return null;

#if UNITY_EDITOR
		string path = AssetDatabase.GUIDToAssetPath(guid);
		if (!string.IsNullOrEmpty(path))
		{
			T asset = AssetDatabase.LoadAssetAtPath<T>(path);
			if (asset != null) return asset;
		}
#endif
		return null;
	}

	/// <summary>
	/// Instantiate a prefab by GUID (for AssetReference replacement).
	/// </summary>
	public static GameObject InstantiateByGuid(string guid, Transform parent = null)
	{
		GameObject prefab = LoadByGuid<GameObject>(guid);
		if (prefab != null)
		{
			return Object.Instantiate(prefab, parent);
		}
		return null;
	}

	public static void ClearCache()
	{
		cache.Clear();
	}
}
