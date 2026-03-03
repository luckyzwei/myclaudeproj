using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection
	{
		private readonly IList _list;

		private readonly ICollection<T> _genericCollection;

		private object _syncRoot;

		public virtual int Count => 0;

		public virtual bool IsReadOnly => false;

		bool IList.IsFixedSize => false;

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

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public object UnderlyingCollection => null;

		public CollectionWrapper(IList list)
		{
		}

		public CollectionWrapper(ICollection<T> list)
		{
		}

		public virtual void Add(T item)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual bool Contains(T item)
		{
			return false;
		}

		public virtual void CopyTo(T[] array, int arrayIndex)
		{
		}

		public virtual bool Remove(T item)
		{
			return false;
		}

		public virtual IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public bool IsGenericCollection()
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		int IList.Add(object value)
		{
			return 0;
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		int IList.IndexOf(object value)
		{
			return 0;
		}

		void IList.RemoveAt(int index)
		{
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void ICollection.CopyTo(Array array, int arrayIndex)
		{
		}

		private static void VerifyValueType(object value)
		{
		}

		private static bool IsCompatibleObject(object value)
		{
			return false;
		}
	}
}
