using System.Collections.Generic;
using System.Text.RegularExpressions;
using Crosstales.BWF.Model;

namespace Crosstales.BWF.Provider
{
	public abstract class BadWordProvider : BaseProvider
	{
		protected readonly List<BadWords> _badwords;

		private Dictionary<string, Regex> _exactBadwordsRegex;

		private Dictionary<string, List<Regex>> _debugExactBadwordsRegex;

		private Dictionary<string, List<string>> _simpleBadwords;

		private const string EXACT_REGEX_START = "(?<![\\w\\d])";

		private const string EXACT_REGEX_END = "s?(?![\\w\\d])";

		public Dictionary<string, Regex> ExactBadwordsRegex
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Dictionary<string, List<string>> SimpleBadwords
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
