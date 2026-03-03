using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
	{
		private readonly List<BsonToken> _children;

		public override BsonType Type => default(BsonType);

		public void Add(BsonToken token)
		{
		}

		public IEnumerator<BsonToken> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
