using System;
using System.Collections.Generic;
using Crosstales.BWF.Data;

namespace Crosstales.BWF.Model
{
	[Serializable]
	public class BadWords
	{
		public Source Source;

		public List<string> BadWordList;

		public BadWords(Source source, IEnumerable<string> badWordList)
		{
		}

		public override string ToString()
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
