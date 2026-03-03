using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public class JTokenEqualityComparer : IEqualityComparer<JToken>
	{
		public bool Equals(JToken x, JToken y)
		{
			return false;
		}

		public int GetHashCode(JToken obj)
		{
			return 0;
		}
	}
}
