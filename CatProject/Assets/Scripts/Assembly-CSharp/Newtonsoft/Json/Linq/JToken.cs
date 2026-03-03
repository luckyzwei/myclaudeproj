using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable
	{
		[CompilerGenerated]
		private sealed class _003CAfterSelf_003Ed__30 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JToken _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public JToken _003C_003E4__this;

			private JToken _003Co_003E5__2;

			JToken IEnumerator<JToken>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CAfterSelf_003Ed__30(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CAncestors_003Ed__29 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JToken _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public JToken _003C_003E4__this;

			private JToken _003Cparent_003E5__2;

			JToken IEnumerator<JToken>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CAncestors_003Ed__29(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CBeforeSelf_003Ed__31 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JToken _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public JToken _003C_003E4__this;

			private JToken _003Co_003E5__2;

			JToken IEnumerator<JToken>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CBeforeSelf_003Ed__31(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private JContainer _parent;

		private JToken _previous;

		private JToken _next;

		private static JTokenEqualityComparer _equalityComparer;

		private int? _lineNumber;

		private int? _linePosition;

		public static JTokenEqualityComparer EqualityComparer => null;

		public JContainer Parent
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public JToken Root => null;

		public abstract JTokenType Type { get; }

		public abstract bool HasValues { get; }

		public JToken Next
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public JToken Previous
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public virtual JToken this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JToken First => null;

		public virtual JToken Last => null;

		IJEnumerable<JToken> IJEnumerable<JToken>.this[object key] => null;

		int IJsonLineInfo.LineNumber => 0;

		int IJsonLineInfo.LinePosition => 0;

		internal abstract JToken CloneToken();

		internal abstract bool DeepEquals(JToken node);

		public static bool DeepEquals(JToken t1, JToken t2)
		{
			return false;
		}

		internal JToken()
		{
		}

		public void AddAfterSelf(object content)
		{
		}

		public void AddBeforeSelf(object content)
		{
		}

		[IteratorStateMachine(typeof(_003CAncestors_003Ed__29))]
		public IEnumerable<JToken> Ancestors()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAfterSelf_003Ed__30))]
		public IEnumerable<JToken> AfterSelf()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CBeforeSelf_003Ed__31))]
		public IEnumerable<JToken> BeforeSelf()
		{
			return null;
		}

		public virtual T Value<T>(object key)
		{
			return default(T);
		}

		public virtual JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		public JEnumerable<T> Children<T>() where T : JToken
		{
			return default(JEnumerable<T>);
		}

		public virtual IEnumerable<T> Values<T>()
		{
			return null;
		}

		public void Remove()
		{
		}

		public void Replace(JToken value)
		{
		}

		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		public override string ToString()
		{
			return null;
		}

		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		private static JValue EnsureValue(JToken value)
		{
			return null;
		}

		private static string GetType(JToken token)
		{
			return null;
		}

		private static bool IsNullable(JToken o)
		{
			return false;
		}

		private static bool ValidateFloat(JToken o, bool nullable)
		{
			return false;
		}

		private static bool ValidateInteger(JToken o, bool nullable)
		{
			return false;
		}

		private static bool ValidateDate(JToken o, bool nullable)
		{
			return false;
		}

		private static bool ValidateBoolean(JToken o, bool nullable)
		{
			return false;
		}

		private static bool ValidateString(JToken o)
		{
			return false;
		}

		private static bool ValidateBytes(JToken o)
		{
			return false;
		}

		public static explicit operator bool(JToken value)
		{
			return false;
		}

		public static explicit operator DateTimeOffset(JToken value)
		{
			return default(DateTimeOffset);
		}

		public static explicit operator bool?(JToken value)
		{
			return null;
		}

		public static explicit operator long(JToken value)
		{
			return 0L;
		}

		public static explicit operator DateTime?(JToken value)
		{
			return null;
		}

		public static explicit operator DateTimeOffset?(JToken value)
		{
			return null;
		}

		public static explicit operator decimal?(JToken value)
		{
			return null;
		}

		public static explicit operator double?(JToken value)
		{
			return null;
		}

		public static explicit operator int(JToken value)
		{
			return 0;
		}

		public static explicit operator short(JToken value)
		{
			return 0;
		}

		public static explicit operator ushort(JToken value)
		{
			return 0;
		}

		public static explicit operator int?(JToken value)
		{
			return null;
		}

		public static explicit operator short?(JToken value)
		{
			return null;
		}

		public static explicit operator ushort?(JToken value)
		{
			return null;
		}

		public static explicit operator DateTime(JToken value)
		{
			return default(DateTime);
		}

		public static explicit operator long?(JToken value)
		{
			return null;
		}

		public static explicit operator float?(JToken value)
		{
			return null;
		}

		public static explicit operator decimal(JToken value)
		{
			return default(decimal);
		}

		public static explicit operator uint?(JToken value)
		{
			return null;
		}

		public static explicit operator ulong?(JToken value)
		{
			return null;
		}

		public static explicit operator double(JToken value)
		{
			return 0.0;
		}

		public static explicit operator float(JToken value)
		{
			return 0f;
		}

		public static explicit operator string(JToken value)
		{
			return null;
		}

		public static explicit operator uint(JToken value)
		{
			return 0u;
		}

		public static explicit operator ulong(JToken value)
		{
			return 0uL;
		}

		public static explicit operator byte[](JToken value)
		{
			return null;
		}

		public static implicit operator JToken(bool value)
		{
			return null;
		}

		public static implicit operator JToken(DateTimeOffset value)
		{
			return null;
		}

		public static implicit operator JToken(bool? value)
		{
			return null;
		}

		public static implicit operator JToken(long value)
		{
			return null;
		}

		public static implicit operator JToken(DateTime? value)
		{
			return null;
		}

		public static implicit operator JToken(DateTimeOffset? value)
		{
			return null;
		}

		public static implicit operator JToken(decimal? value)
		{
			return null;
		}

		public static implicit operator JToken(double? value)
		{
			return null;
		}

		public static implicit operator JToken(short value)
		{
			return null;
		}

		public static implicit operator JToken(ushort value)
		{
			return null;
		}

		public static implicit operator JToken(int value)
		{
			return null;
		}

		public static implicit operator JToken(int? value)
		{
			return null;
		}

		public static implicit operator JToken(DateTime value)
		{
			return null;
		}

		public static implicit operator JToken(long? value)
		{
			return null;
		}

		public static implicit operator JToken(float? value)
		{
			return null;
		}

		public static implicit operator JToken(decimal value)
		{
			return null;
		}

		public static implicit operator JToken(short? value)
		{
			return null;
		}

		public static implicit operator JToken(ushort? value)
		{
			return null;
		}

		public static implicit operator JToken(uint? value)
		{
			return null;
		}

		public static implicit operator JToken(ulong? value)
		{
			return null;
		}

		public static implicit operator JToken(double value)
		{
			return null;
		}

		public static implicit operator JToken(float value)
		{
			return null;
		}

		public static implicit operator JToken(string value)
		{
			return null;
		}

		public static implicit operator JToken(uint value)
		{
			return null;
		}

		public static implicit operator JToken(ulong value)
		{
			return null;
		}

		public static implicit operator JToken(byte[] value)
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return null;
		}

		internal abstract int GetDeepHashCode();

		public JsonReader CreateReader()
		{
			return null;
		}

		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		public static JToken FromObject(object o)
		{
			return null;
		}

		public static JToken FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		public T ToObject<T>()
		{
			return default(T);
		}

		public T ToObject<T>(JsonSerializer jsonSerializer)
		{
			return default(T);
		}

		public static JToken ReadFrom(JsonReader reader)
		{
			return null;
		}

		public static JToken Parse(string json)
		{
			return null;
		}

		public static JToken Load(JsonReader reader)
		{
			return null;
		}

		internal void SetLineInfo(IJsonLineInfo lineInfo)
		{
		}

		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		bool IJsonLineInfo.HasLineInfo()
		{
			return false;
		}

		public JToken SelectToken(string path)
		{
			return null;
		}

		public JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			return null;
		}

		object ICloneable.Clone()
		{
			return null;
		}

		public JToken DeepClone()
		{
			return null;
		}
	}
}
