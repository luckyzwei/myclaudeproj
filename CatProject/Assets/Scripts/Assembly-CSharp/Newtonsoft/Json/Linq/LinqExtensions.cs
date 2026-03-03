using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	public static class LinqExtensions
	{
		[CompilerGenerated]
		private sealed class _003CConvert_003Ed__12<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : JToken
		{
			private int _003C_003E1__state;

			private U _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> source;

			public IEnumerable<T> _003C_003E3__source;

			private IEnumerator<T> _003C_003E7__wrap1;

			U IEnumerator<U>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(U);
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
			public _003CConvert_003Ed__12(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<U> IEnumerable<U>.GetEnumerator()
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
		private sealed class _003CValues_003Ed__9<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : JToken
		{
			private int _003C_003E1__state;

			private U _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> source;

			public IEnumerable<T> _003C_003E3__source;

			private object key;

			public object _003C_003E3__key;

			private IEnumerator<T> _003C_003E7__wrap1;

			private IEnumerator<JToken> _003C_003E7__wrap2;

			U IEnumerator<U>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(U);
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
			public _003CValues_003Ed__9(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<U> IEnumerable<U>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static IJEnumerable<JToken> Ancestors<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		public static IJEnumerable<JToken> Descendants<T>(this IEnumerable<T> source) where T : JContainer
		{
			return null;
		}

		public static IJEnumerable<JProperty> Properties(this IEnumerable<JObject> source)
		{
			return null;
		}

		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source, object key)
		{
			return null;
		}

		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source)
		{
			return null;
		}

		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source, object key)
		{
			return null;
		}

		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source)
		{
			return null;
		}

		public static U Value<U>(this IEnumerable<JToken> value)
		{
			return default(U);
		}

		public static U Value<T, U>(this IEnumerable<T> value) where T : JToken
		{
			return default(U);
		}

		[IteratorStateMachine(typeof(_003CValues_003Ed__9<, >))]
		internal static IEnumerable<U> Values<T, U>(this IEnumerable<T> source, object key) where T : JToken
		{
			return null;
		}

		public static IJEnumerable<JToken> Children<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		public static IEnumerable<U> Children<T, U>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CConvert_003Ed__12<, >))]
		internal static IEnumerable<U> Convert<T, U>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}

		internal static U Convert<T, U>(this T token) where T : JToken
		{
			return default(U);
		}

		public static IJEnumerable<JToken> AsJEnumerable(this IEnumerable<JToken> source)
		{
			return null;
		}

		public static IJEnumerable<T> AsJEnumerable<T>(this IEnumerable<T> source) where T : JToken
		{
			return null;
		}
	}
}
