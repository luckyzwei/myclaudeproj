using System;
using UnityEngine;
using UnityEngine.Events;

namespace KWGameCore
{
	public class EventPropagator : MonoBehaviour
	{
		[Serializable]
		public class StringEvent : UnityEvent<string>
		{
		}

		public StringEvent m_event;

		public void PropagateEvent(string eventName)
		{
		}
	}
}
