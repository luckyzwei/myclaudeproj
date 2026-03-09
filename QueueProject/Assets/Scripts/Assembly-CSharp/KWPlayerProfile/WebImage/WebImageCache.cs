using System;
using System.Collections.Generic;
using UnityEngine;

namespace KWPlayerProfile.WebImage
{
	public static class WebImageCache
	{
		private class CacheEntry
		{
			public Texture2D Texture { get; }

			private DateTime TimeStamp { get; set; }

			public bool IsValid()
			{
				return false;
			}

			public CacheEntry(Texture2D texture, DateTime timeStamp)
			{
			}

			public void UpdateTimestamp()
			{
			}
		}

		private static readonly Dictionary<ulong, CacheEntry> CachedImages;

		public static bool TryGetCachedImage(ulong key, out Texture2D texture)
		{
			texture = null;
			return false;
		}

		public static void AddToCache(ulong key, Texture2D texture)
		{
		}

		public static void ClearCache()
		{
		}
	}
}
