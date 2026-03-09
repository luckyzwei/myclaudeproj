using System;
using UnityEngine;

namespace KWGameplay
{
	public static class ComponentExt
	{
		public static void StripComponents(this Component c, params Type[] toKeep)
		{
		}

		public static GameObject AddChildGameObject(this Component c, string name)
		{
			return null;
		}

		public static T AddChildGameObject<T>(this Component c, string name) where T : Component
		{
			return null;
		}

		public static T DuplicateGameObject<T>(this Component source, Transform newParent, bool keepPrefabConnection = false) where T : Component
		{
			return null;
		}

		public static Component DuplicateGameObject(this Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
}
