using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
	{
		private readonly List<BsonProperty> _children;

		public override BsonType Type => default(BsonType);

		public void Add(string name, BsonToken token)
		{
		}

		public IEnumerator<BsonProperty> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
