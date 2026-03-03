using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	internal class JPath
	{
		private readonly string _expression;

		private int _currentIndex;

		public List<object> Parts { get; private set; }

		public JPath(string expression)
		{
		}

		private void ParseMain()
		{
		}

		private void ParseIndexer(char indexerOpenChar)
		{
		}

		internal JToken Evaluate(JToken root, bool errorWhenNoMatch)
		{
			return null;
		}
	}
}
