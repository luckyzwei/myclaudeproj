using System.Collections.Generic;
using System.IO;

namespace KWCore.CoreRequests
{
	public class CoreRequestsCache
	{
		private static readonly string CACHE_DIR;

		private static readonly string CACHE_PATH;

		private readonly object m_cacheWriteLock;

		public List<CoreRequest> Read()
		{
			return null;
		}

		public void Write(List<CoreRequest> requests)
		{
		}

		private Stream GetCacheStream()
		{
			return null;
		}

		private void NukeCache()
		{
		}
	}
}
