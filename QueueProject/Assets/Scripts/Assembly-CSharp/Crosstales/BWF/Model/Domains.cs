using System;
using System.Collections.Generic;
using Crosstales.BWF.Data;

namespace Crosstales.BWF.Model
{
	[Serializable]
	public class Domains
	{
		public Source Source;

		public List<string> DomainList;

		public Domains(Source source, IEnumerable<string> domainList)
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
