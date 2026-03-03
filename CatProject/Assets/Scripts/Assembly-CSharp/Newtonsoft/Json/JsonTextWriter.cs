using System;
using System.IO;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	public class JsonTextWriter : JsonWriter
	{
		private readonly TextWriter _writer;

		private Base64Encoder _base64Encoder;

		private char _indentChar;

		private int _indentation;

		private char _quoteChar;

		private bool _quoteName;

		private Base64Encoder Base64Encoder => null;

		public int Indentation
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public char QuoteChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		public char IndentChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		public bool QuoteName
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public JsonTextWriter(TextWriter textWriter)
		{
		}

		public override void Flush()
		{
		}

		public override void Close()
		{
		}

		public override void WriteStartObject()
		{
		}

		public override void WriteStartArray()
		{
		}

		public override void WriteStartConstructor(string name)
		{
		}

		protected override void WriteEnd(JsonToken token)
		{
		}

		public override void WritePropertyName(string name)
		{
		}

		protected override void WriteIndent()
		{
		}

		protected override void WriteValueDelimiter()
		{
		}

		protected override void WriteIndentSpace()
		{
		}

		private void WriteValueInternal(string value, JsonToken token)
		{
		}

		public override void WriteNull()
		{
		}

		public override void WriteUndefined()
		{
		}

		public override void WriteRaw(string json)
		{
		}

		public override void WriteValue(string value)
		{
		}

		public override void WriteValue(int value)
		{
		}

		public override void WriteValue(uint value)
		{
		}

		public override void WriteValue(long value)
		{
		}

		public override void WriteValue(ulong value)
		{
		}

		public override void WriteValue(float value)
		{
		}

		public override void WriteValue(double value)
		{
		}

		public override void WriteValue(bool value)
		{
		}

		public override void WriteValue(short value)
		{
		}

		public override void WriteValue(ushort value)
		{
		}

		public override void WriteValue(char value)
		{
		}

		public override void WriteValue(byte value)
		{
		}

		public override void WriteValue(sbyte value)
		{
		}

		public override void WriteValue(decimal value)
		{
		}

		public override void WriteValue(DateTime value)
		{
		}

		public override void WriteValue(byte[] value)
		{
		}

		public override void WriteValue(DateTimeOffset value)
		{
		}

		public override void WriteValue(Guid value)
		{
		}

		public override void WriteValue(TimeSpan value)
		{
		}

		public override void WriteValue(Uri value)
		{
		}

		public override void WriteComment(string text)
		{
		}

		public override void WriteWhitespace(string ws)
		{
		}
	}
}
