using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		public BidirectionalDictionary()
		{
		}

		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
		{
		}

		public void Add(TFirst first, TSecond second)
		{
		}

		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			second = default(TSecond);
			return false;
		}

		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			first = default(TFirst);
			return false;
		}
	}
}
