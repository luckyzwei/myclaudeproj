using System.Collections.Generic;
using Crosstales.BWF.Data;

namespace Crosstales.BWF.Filter
{
	public abstract class BaseFilter : IFilter
	{
		public bool DisableOrdering;

		protected readonly Dictionary<string, Source> _sources;

		protected readonly List<string> _getAllResult;

		public virtual List<Source> Sources => null;

		public abstract bool isReady { get; }

		public BaseFilter(bool disableOrdering)
		{
		}

		public abstract bool Contains(string text, params string[] sourceNames);

		public abstract List<string> GetAll(string text, params string[] sourceNames);

		public abstract string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames);

		public virtual string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		public virtual string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", params string[] sourceNames)
		{
			return null;
		}

		protected static void logFilterNotReady()
		{
		}

		protected static void logResourceNotFound(string res)
		{
		}

		protected static void logContains()
		{
		}

		protected static void logGetAll()
		{
		}

		protected static void logReplaceAll()
		{
		}
	}
}
