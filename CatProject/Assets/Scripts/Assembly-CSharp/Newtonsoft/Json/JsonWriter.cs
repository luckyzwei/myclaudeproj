using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json
{
	public abstract class JsonWriter : IDisposable
	{
		private enum State
		{
			Start = 0,
			Property = 1,
			ObjectStart = 2,
			Object = 3,
			ArrayStart = 4,
			Array = 5,
			ConstructorStart = 6,
			Constructor = 7,
			Bytes = 8,
			Closed = 9,
			Error = 10
		}

		private static readonly State[][] stateArray;

		private int _top;

		private readonly List<JTokenType> _stack;

		private State _currentState;

		private Formatting _formatting;

		public bool CloseOutput { get; set; }

		protected internal int Top => 0;

		public WriteState WriteState => default(WriteState);

		public Formatting Formatting
		{
			get
			{
				return default(Formatting);
			}
			set
			{
			}
		}

		private void Push(JTokenType value)
		{
		}

		private JTokenType Pop()
		{
			return default(JTokenType);
		}

		private JTokenType Peek()
		{
			return default(JTokenType);
		}

		public abstract void Flush();

		public virtual void Close()
		{
		}

		public virtual void WriteStartObject()
		{
		}

		public virtual void WriteEndObject()
		{
		}

		public virtual void WriteStartArray()
		{
		}

		public virtual void WriteEndArray()
		{
		}

		public virtual void WriteStartConstructor(string name)
		{
		}

		public virtual void WriteEndConstructor()
		{
		}

		public virtual void WritePropertyName(string name)
		{
		}

		public virtual void WriteEnd()
		{
		}

		public void WriteToken(JsonReader reader)
		{
		}

		internal void WriteToken(JsonReader reader, int initialDepth)
		{
		}

		private void WriteConstructorDate(JsonReader reader)
		{
		}

		private bool IsEndToken(JsonToken token)
		{
			return false;
		}

		private bool IsStartToken(JsonToken token)
		{
			return false;
		}

		private void WriteEnd(JTokenType type)
		{
		}

		private void AutoCompleteAll()
		{
		}

		private JTokenType GetTypeForCloseToken(JsonToken token)
		{
			return default(JTokenType);
		}

		private JsonToken GetCloseTokenForType(JTokenType type)
		{
			return default(JsonToken);
		}

		private void AutoCompleteClose(JsonToken tokenBeingClosed)
		{
		}

		protected virtual void WriteEnd(JsonToken token)
		{
		}

		protected virtual void WriteIndent()
		{
		}

		protected virtual void WriteValueDelimiter()
		{
		}

		protected virtual void WriteIndentSpace()
		{
		}

		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
		}

		public virtual void WriteNull()
		{
		}

		public virtual void WriteUndefined()
		{
		}

		public virtual void WriteRaw(string json)
		{
		}

		public virtual void WriteRawValue(string json)
		{
		}

		public virtual void WriteValue(string value)
		{
		}

		public virtual void WriteValue(int value)
		{
		}

		public virtual void WriteValue(uint value)
		{
		}

		public virtual void WriteValue(long value)
		{
		}

		public virtual void WriteValue(ulong value)
		{
		}

		public virtual void WriteValue(float value)
		{
		}

		public virtual void WriteValue(double value)
		{
		}

		public virtual void WriteValue(bool value)
		{
		}

		public virtual void WriteValue(short value)
		{
		}

		public virtual void WriteValue(ushort value)
		{
		}

		public virtual void WriteValue(char value)
		{
		}

		public virtual void WriteValue(byte value)
		{
		}

		public virtual void WriteValue(sbyte value)
		{
		}

		public virtual void WriteValue(decimal value)
		{
		}

		public virtual void WriteValue(DateTime value)
		{
		}

		public virtual void WriteValue(DateTimeOffset value)
		{
		}

		public virtual void WriteValue(Guid value)
		{
		}

		public virtual void WriteValue(TimeSpan value)
		{
		}

		public virtual void WriteValue(int? value)
		{
		}

		public virtual void WriteValue(uint? value)
		{
		}

		public virtual void WriteValue(long? value)
		{
		}

		public virtual void WriteValue(ulong? value)
		{
		}

		public virtual void WriteValue(float? value)
		{
		}

		public virtual void WriteValue(double? value)
		{
		}

		public virtual void WriteValue(bool? value)
		{
		}

		public virtual void WriteValue(short? value)
		{
		}

		public virtual void WriteValue(ushort? value)
		{
		}

		public virtual void WriteValue(char? value)
		{
		}

		public virtual void WriteValue(byte? value)
		{
		}

		public virtual void WriteValue(sbyte? value)
		{
		}

		public virtual void WriteValue(decimal? value)
		{
		}

		public virtual void WriteValue(DateTime? value)
		{
		}

		public virtual void WriteValue(DateTimeOffset? value)
		{
		}

		public virtual void WriteValue(Guid? value)
		{
		}

		public virtual void WriteValue(TimeSpan? value)
		{
		}

		public virtual void WriteValue(byte[] value)
		{
		}

		public virtual void WriteValue(Uri value)
		{
		}

		public virtual void WriteValue(object value)
		{
		}

		public virtual void WriteComment(string text)
		{
		}

		public virtual void WriteWhitespace(string ws)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
