using UnityEngine;

public static class GameObjectExtensions
{
	public static T GetComponentInSelfOrFirstParent<T>(this GameObject go) where T : Component
	{
		return null;
	}
}
