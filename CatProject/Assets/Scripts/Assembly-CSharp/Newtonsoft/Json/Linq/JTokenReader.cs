using System;

namespace Newtonsoft.Json.Linq
{
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		private readonly JToken _root;

		private JToken _parent;

		private JToken _current;

		private bool IsEndElement => false;

		int IJsonLineInfo.LineNumber => 0;

		int IJsonLineInfo.LinePosition => 0;

		public JTokenReader(JToken token)
		{
		}

		public override byte[] ReadAsBytes()
		{
			return null;
		}

		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		public override bool Read()
		{
			return false;
		}

		private bool ReadOver(JToken t)
		{
			return false;
		}

		private bool ReadToEnd()
		{
			return false;
		}

		private JsonToken? GetEndToken(JContainer c)
		{
			return null;
		}

		private bool ReadInto(JContainer c)
		{
			return false;
		}

		private bool SetEnd(JContainer c)
		{
			return false;
		}

		private void SetToken(JToken token)
		{
		}

		private string SafeToString(object value)
		{
			return null;
		}

		bool IJsonLineInfo.HasLineInfo()
		{
			return false;
		}
	}
}
