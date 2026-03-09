using System.Collections.Generic;
using System.Text.RegularExpressions;
using Crosstales.BWF.Model;

namespace Crosstales.BWF.Provider
{
	public abstract class DomainProvider : BaseProvider
	{
		protected readonly List<Domains> _domains;

		private Dictionary<string, Regex> _domainsRegex;

		private Dictionary<string, List<Regex>> _debugDomainsRegex;

		private const string DOMAIN_REGEGX_START = "\\b{0,1}((ht|f)tp(s?)\\:\\/\\/)?[\\w\\-\\.\\@]*[\\.]";

		private const string DOMAIN_REGEGX_END = "(:\\d{1,5})?(\\/|\\b)";

		public Dictionary<string, Regex> DomainsRegex
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Dictionary<string, List<Regex>> DebugDomainsRegex
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		private void Start()
		{
		}

		public override void Load()
		{
		}

		protected override void init()
		{
		}
	}
}
