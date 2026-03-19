using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary>
/// Fixes Image.sprite references that fail to deserialize in Unity 6 with old DLL format prefabs.
/// Attach to any GameObject or call FixAll() on a root.
/// </summary>
public static class RuntimeSpriteFixup
{
	/// Fix sprites on an already-instantiated GameObject
	public static int FixAll(GameObject root)
	{
		if (root == null) return 0;
		int fixed_count = 0;

#if UNITY_EDITOR
		var images = root.GetComponentsInChildren<Image>(true);
		for (int i = 0; i < images.Length; i++)
		{
			if (images[i].sprite == null)
			{
				var so = new SerializedObject(images[i]);
				var spriteProp = so.FindProperty("m_Sprite");
				if (spriteProp != null && spriteProp.objectReferenceValue != null)
				{
					images[i].sprite = spriteProp.objectReferenceValue as Sprite;
					if (images[i].sprite != null)
						fixed_count++;
				}
			}
		}
#endif
		return fixed_count;
	}

	/// Fix sprites on a PREFAB (before instantiation), then instantiate
	public static GameObject FixAndInstantiate(GameObject prefab)
	{
		if (prefab == null) return null;

#if UNITY_EDITOR
		// Fix the prefab asset in-memory before instantiating
		var prefabImages = prefab.GetComponentsInChildren<Image>(true);
		int fixCount = 0;
		// Build a map of sprite refs from SerializedObject
		var spriteMap = new System.Collections.Generic.Dictionary<int, Sprite>();
		for (int i = 0; i < prefabImages.Length; i++)
		{
			if (prefabImages[i].sprite == null)
			{
				var so = new SerializedObject(prefabImages[i]);
				var sp = so.FindProperty("m_Sprite");
				if (sp != null && sp.objectReferenceValue is Sprite spr)
				{
					spriteMap[i] = spr;
				}
			}
		}

		// Instantiate
		var instance = Object.Instantiate(prefab);

		// Apply sprite map to instance
		var instanceImages = instance.GetComponentsInChildren<Image>(true);
		for (int i = 0; i < instanceImages.Length && i < prefabImages.Length; i++)
		{
			if (instanceImages[i].sprite == null && spriteMap.ContainsKey(i))
			{
				instanceImages[i].sprite = spriteMap[i];
				fixCount++;
			}
		}
		Debug.Log($"[SpriteFixup] Fixed {fixCount}/{instanceImages.Length} sprites via prefab SO map");
		return instance;
#else
		return Object.Instantiate(prefab);
#endif
	}
}
