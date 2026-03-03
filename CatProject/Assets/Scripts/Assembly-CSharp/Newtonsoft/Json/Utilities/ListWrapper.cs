using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal class ListWrapper<T> : CollectionWrapper<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedList, IList, ICollection
	{
		private readonly IList<T> _genericList;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public override int Count => 0;

		public override bool IsReadOnly => false;

		public object UnderlyingList => null;

		public ListWrapper(IList list)
			: base((IList)null)
		{
		}

		public ListWrapper(IList<T> list)
			: base((IList)null)
		{
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		public override void Add(T item)
		{
		}

		public override void Clear()
		{
		}

		public override bool Contains(T item)
		{
			return false;
		}

		public override void CopyTo(T[] array, int arrayIndex)
		{
		}

		public override bool Remove(T item)
		{
			return false;
		}

		public override IEnumerator<T> GetEnumerator()
		{
			return null;
		}
	}
}
