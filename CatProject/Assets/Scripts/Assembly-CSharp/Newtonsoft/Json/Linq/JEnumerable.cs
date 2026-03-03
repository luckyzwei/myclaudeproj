using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable where T : JToken
	{
		public static readonly JEnumerable<T> Empty;

		private IEnumerable<T> _enumerable;

		public IJEnumerable<JToken> this[object key] => null;

		public JEnumerable(IEnumerable<T> enumerable)
		{
			_enumerable = null;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
