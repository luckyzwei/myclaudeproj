using System.Collections.Generic;
using System.Text.RegularExpressions;
using Crosstales.BWF.Provider;

namespace Crosstales.BWF.Filter
{
	public class DomainFilter : BaseFilter
	{
		public string ReplaceCharacters;

		private List<DomainProvider> _domainProvider;

		private readonly List<DomainProvider> _tempDomainProvider;

		private readonly Dictionary<string, Regex> _domainsRegex;

		private readonly Dictionary<string, List<Regex>> _debugDomainsRegex;

		private bool _ready;

		private bool _readyFirstTime;

		public List<DomainProvider> DomainProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool isReady => false;

		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters = "*", bool disableOrdering = false)
			: base(disableOrdering: false)
		{
		}

		public override bool Contains(string text, params string[] sourceNames)
		{
			return false;
		}

		public override List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		public override string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}
	}
}
