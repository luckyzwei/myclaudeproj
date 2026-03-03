using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json
{
	public abstract class JsonReader : IDisposable
	{
		protected enum State
		{
			Start = 0,
			Complete = 1,
			Property = 2,
			ObjectStart = 3,
			Object = 4,
			ArrayStart = 5,
			Array = 6,
			Closed = 7,
			PostValue = 8,
			ConstructorStart = 9,
			Constructor = 10,
			Error = 11,
			Finished = 12
		}

		private JsonToken _token;

		private object _value;

		private Type _valueType;

		private char _quoteChar;

		private State _currentState;

		private JTokenType _currentTypeContext;

		private int _top;

		private readonly List<JTokenType> _stack;

		protected State CurrentState => default(State);

		public bool CloseInput { get; set; }

		public virtual char QuoteChar
		{
			get
			{
				return '\0';
			}
			protected internal set
			{
			}
		}

		public virtual JsonToken TokenType => default(JsonToken);

		public virtual object Value => null;

		public virtual Type ValueType => null;

		public virtual int Depth => 0;

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

		public abstract bool Read();

		public abstract byte[] ReadAsBytes();

		public abstract decimal? ReadAsDecimal();

		public abstract DateTimeOffset? ReadAsDateTimeOffset();

		public void Skip()
		{
		}

		protected void SetToken(JsonToken newToken)
		{
		}

		protected virtual void SetToken(JsonToken newToken, object value)
		{
		}

		private void ValidateEnd(JsonToken endToken)
		{
		}

		protected void SetStateBasedOnCurrent()
		{
		}

		internal static bool IsPrimitiveToken(JsonToken token)
		{
			return false;
		}

		internal static bool IsStartToken(JsonToken token)
		{
			return false;
		}

		private JTokenType GetTypeForCloseToken(JsonToken token)
		{
			return default(JTokenType);
		}

		void IDisposable.Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public virtual void Close()
		{
		}
	}
}
