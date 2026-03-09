using UnityEngine;

public static class TransformExtensions
{
	public static void DestroyAllChildren(this Transform transform)
	{
	}

	public static void DisableAllChildren(this Transform transform)
	{
	}

	public static void SetLayer(this GameObject go, int layerNumber, bool includeInactive = false, bool withChildren = false)
	{
	}

	public static void SetLayer(this GameObject go, string layerName, bool includeInactive = false, bool withChildren = false)
	{
	}

	public static Transform[] GetFirstLevelChildren(this Transform parent, bool includeInactive)
	{
		return null;
	}
}
