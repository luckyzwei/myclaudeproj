using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Crosstales.BWF.Filter
{
	public class PunctuationFilter : BaseFilter
	{
		private int _characterNumber;

		public Regex RegularExpression { get; private set; }

		public int CharacterNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override bool isReady => false;

		public PunctuationFilter(int punctuationCharacterNumber = 3, bool disableOrdering = false)
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
