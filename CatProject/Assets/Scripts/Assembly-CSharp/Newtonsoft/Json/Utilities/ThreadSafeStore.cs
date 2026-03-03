using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal class ThreadSafeStore<TKey, TValue>
	{
		private readonly object _lock;

		private Dictionary<TKey, TValue> _store;

		private readonly Func<TKey, TValue> _creator;

		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
		}

		public TValue Get(TKey key)
		{
			return default(TValue);
		}

		private TValue AddValue(TKey key)
		{
			return default(TValue);
		}
	}
}
