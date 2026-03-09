using System.Collections.Generic;
using System.Text.RegularExpressions;
using Crosstales.BWF.Model.Enum;
using Crosstales.BWF.Provider;

namespace Crosstales.BWF.Filter
{
	public class BadWordFilter : BaseFilter
	{
		public string ReplaceCharacters;

		public ReplaceMode Mode;

		public bool RemoveSpaces;

		public int MaxTextLength;

		public string RemoveCharacters;

		public bool SimpleCheck;

		private readonly List<BadWordProvider> _tempBadWordProviderLTR;

		private readonly List<BadWordProvider> _tempBadWordProviderRTL;

		private readonly Dictionary<string, Regex> _exactBadwordsRegex;

		private readonly Dictionary<string, List<Regex>> _debugExactBadwordsRegex;

		private readonly Dictionary<string, List<string>> _simpleBadwords;

		private bool _ready;

		private bool _readyFirstTime;

		private List<BadWordProvider> _badWordProviderLTR;

		private List<BadWordProvider> _badWordProviderRTL;

		public List<BadWordProvider> BadWordProviderLTR
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<BadWordProvider> BadWordProviderRTL
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

		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters = "*", ReplaceMode mode = ReplaceMode.Default, bool simpleCheck = false, bool removeSpaces = false, bool disableOrdering = false, string removeCharacters = "")
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

		private string replaceCapture(string text, Capture capture, bool markOnly, string prefix, string postfix, int offset)
		{
			return null;
		}

		protected string replaceText(string input)
		{
			return null;
		}

		private static string replaceNonLettersOrDigits(string input)
		{
			return null;
		}

		private static string replaceSpacesBetweenLetters(string text, int maxTextLength = 4)
		{
			return null;
		}

		private static string removeChars(string input, string removeChars)
		{
			return null;
		}

		private static string replaceLeetToText(string input)
		{
			return null;
		}

		private static string replaceLeetAdvancedToText(string input)
		{
			return null;
		}
	}
}
