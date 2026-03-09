using System;
using System.Collections.Generic;
using UnityEngine;

namespace KWUserInterface
{
	public class ScreenTransitions : MonoBehaviour
	{
		[Serializable]
		public class SpecificTransition
		{
			public string screenTypeString;

			public ScreenTransitionData transition;
		}

		[SerializeField]
		private ScreenTransitionData m_genericTransition;

		[SerializeField]
		private List<SpecificTransition> m_specificTransitions;

		public ScreenTransitionData GenericTransition
		{
			get
			{
				return m_genericTransition;
			}
			set
			{
				m_genericTransition = value;
			}
		}

		public ScreenTransitionData GetTransitionTo(Screen screen)
		{
			if (screen != null && m_specificTransitions != null)
			{
				string screenName = screen.GetType().Name;
				for (int i = 0; i < m_specificTransitions.Count; i++)
				{
					if (m_specificTransitions[i].screenTypeString == screenName)
					{
						return m_specificTransitions[i].transition;
					}
				}
			}
			return m_genericTransition;
		}

		public List<SpecificTransition> GetSpecificTransitions()
		{
			return m_specificTransitions;
		}
	}
}
