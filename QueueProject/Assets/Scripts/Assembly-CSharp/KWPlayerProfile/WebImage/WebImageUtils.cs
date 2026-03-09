using UnityEngine;

namespace KWPlayerProfile.WebImage
{
	public static class WebImageUtils
	{
		public const string RESOURCE_IDENTIFIER = "Resources";

		public const string SPLIT_SYMBOL = "://";

		public static Sprite CreateSprite(Texture2D texture, float rectPosX = 0f, float rectPosy = 0f, float pivotX = 0.5f, float pivotY = 0.5f)
		{
			return null;
		}

		public static bool IsAvailableInResource(string url, out string path)
		{
			path = null;
			return false;
		}
	}
}
