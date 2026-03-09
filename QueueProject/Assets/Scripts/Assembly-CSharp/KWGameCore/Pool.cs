using System.Collections.Generic;
using UnityEngine;

namespace KWGameCore
{
	public class Pool<T> where T : Component
	{
		private Queue<T> m_elements;

		private HashSet<int> m_hashes;

		private T m_prefab;

		private bool m_dynamicSize;

		private Transform m_defaultParent;

		public Pool(bool dynamicSize, T prefab, int initialSize, Transform defaultParent)
		{
		}

		public void Clear()
		{
		}

		public T GetElement()
		{
			return null;
		}

		public T GetElement(Transform newParent, bool worldPositionStays = true)
		{
			return null;
		}

		public void ReturnElement(T component)
		{
		}
	}
}
