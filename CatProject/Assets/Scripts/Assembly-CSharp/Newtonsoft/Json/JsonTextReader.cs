using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		private enum ReadType
		{
			Read = 0,
			ReadAsBytes = 1,
			ReadAsDecimal = 2,
			ReadAsDateTimeOffset = 3
		}

		private readonly TextReader _reader;

		private readonly StringBuffer _buffer;

		private char? _lastChar;

		private int _currentLinePosition;

		private int _currentLineNumber;

		private bool _end;

		private ReadType _readType;

		private CultureInfo _culture;

		private const int LineFeedValue = 10;

		private const int CarriageReturnValue = 13;

		public CultureInfo Culture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int LineNumber => 0;

		public int LinePosition => 0;

		public JsonTextReader(TextReader reader)
		{
		}

		private void ParseString(char quote)
		{
		}

		private void ReadStringIntoBuffer(char quote)
		{
		}

		private JsonReaderException CreateJsonReaderException(string format, params object[] args)
		{
			return null;
		}

		private TimeSpan ReadOffset(string offsetText)
		{
			return default(TimeSpan);
		}

		private void ParseDate(string text)
		{
		}

		private char MoveNext()
		{
			return '\0';
		}

		private bool HasNext()
		{
			return false;
		}

		private int PeekNext()
		{
			return 0;
		}

		public override bool Read()
		{
			return false;
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

		private bool ReadInternal()
		{
			return false;
		}

		private bool ParsePostValue(char currentChar)
		{
			return false;
		}

		private bool ParseObject(char currentChar)
		{
			return false;
		}

		private bool ParseProperty(char firstChar)
		{
			return false;
		}

		private bool ValidIdentifierChar(char value)
		{
			return false;
		}

		private char ParseUnquotedProperty(char firstChar)
		{
			return '\0';
		}

		private bool ParseValue(char currentChar)
		{
			return false;
		}

		private bool EatWhitespace(char initialChar, bool oneOrMore, out char finalChar)
		{
			finalChar = default(char);
			return false;
		}

		private void ParseConstructor()
		{
		}

		private void ParseNumber(char firstChar)
		{
		}

		private void ParseComment()
		{
		}

		private bool MatchValue(char firstChar, string value)
		{
			return false;
		}

		private bool MatchValue(char firstChar, string value, bool noTrailingNonSeperatorCharacters)
		{
			return false;
		}

		private bool IsSeperator(char c)
		{
			return false;
		}

		private void ParseTrue()
		{
		}

		private void ParseNull()
		{
		}

		private void ParseUndefined()
		{
		}

		private void ParseFalse()
		{
		}

		private void ParseNumberNegativeInfinity()
		{
		}

		private void ParseNumberPositiveInfinity()
		{
		}

		private void ParseNumberNaN()
		{
		}

		public override void Close()
		{
		}

		public bool HasLineInfo()
		{
			return false;
		}
	}
}
