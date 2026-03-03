using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IList, ICollection
	{
		private class JTokenReferenceEqualityComparer : IEqualityComparer<JToken>
		{
			public static readonly JTokenReferenceEqualityComparer Instance;

			public bool Equals(JToken x, JToken y)
			{
				return false;
			}

			public int GetHashCode(JToken obj)
			{
				return 0;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDescendants_003Ed__16 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JToken _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public JContainer _003C_003E4__this;

			private IEnumerator<JToken> _003C_003E7__wrap1;

			private JToken _003Co_003E5__3;

			private IEnumerator<JToken> _003C_003E7__wrap3;

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
			public _003CDescendants_003Ed__16(int _003C_003E1__state)
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

		private object _syncRoot;

		private bool _busy;

		protected abstract IList<JToken> ChildrenTokens { get; }

		public override bool HasValues => false;

		public override JToken First => null;

		public override JToken Last => null;

		JToken IList<JToken>.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool ICollection<JToken>.IsReadOnly => false;

		bool IList.IsFixedSize => false;

		bool IList.IsReadOnly => false;

		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		internal JContainer()
		{
		}

		internal JContainer(JContainer other)
		{
		}

		internal void CheckReentrancy()
		{
		}

		internal bool ContentsEqual(JContainer container)
		{
			return false;
		}

		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		public override IEnumerable<T> Values<T>()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDescendants_003Ed__16))]
		public IEnumerable<JToken> Descendants()
		{
			return null;
		}

		internal bool IsMultiContent(object content)
		{
			return false;
		}

		internal JToken EnsureParentToken(JToken item)
		{
			return null;
		}

		internal int IndexOfItem(JToken item)
		{
			return 0;
		}

		internal virtual void InsertItem(int index, JToken item)
		{
		}

		internal virtual void RemoveItemAt(int index)
		{
		}

		internal virtual bool RemoveItem(JToken item)
		{
			return false;
		}

		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		internal virtual void SetItem(int index, JToken item)
		{
		}

		internal virtual void ClearItems()
		{
		}

		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		internal virtual bool ContainsItem(JToken item)
		{
			return false;
		}

		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			return false;
		}

		internal virtual void ValidateToken(JToken o, JToken existing)
		{
		}

		public virtual void Add(object content)
		{
		}

		public void AddFirst(object content)
		{
		}

		internal void AddInternal(int index, object content)
		{
		}

		internal JToken CreateFromContent(object content)
		{
			return null;
		}

		public JsonWriter CreateWriter()
		{
			return null;
		}

		public void ReplaceAll(object content)
		{
		}

		public void RemoveAll()
		{
		}

		internal void ReadTokenFrom(JsonReader r)
		{
		}

		internal void ReadContentFrom(JsonReader r)
		{
		}

		internal int ContentsHashCode()
		{
			return 0;
		}

		int IList<JToken>.IndexOf(JToken item)
		{
			return 0;
		}

		void IList<JToken>.Insert(int index, JToken item)
		{
		}

		void IList<JToken>.RemoveAt(int index)
		{
		}

		void ICollection<JToken>.Add(JToken item)
		{
		}

		void ICollection<JToken>.Clear()
		{
		}

		bool ICollection<JToken>.Contains(JToken item)
		{
			return false;
		}

		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
		}

		bool ICollection<JToken>.Remove(JToken item)
		{
			return false;
		}

		private JToken EnsureValue(object value)
		{
			return null;
		}

		int IList.Add(object value)
		{
			return 0;
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		int IList.IndexOf(object value)
		{
			return 0;
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}
	}
}
