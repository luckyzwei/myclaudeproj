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
				return null;
			}
			set
			{
			}
		}

		public ScreenTransitionData GetTransitionTo(Screen screen)
		{
			return null;
		}

		public List<SpecificTransition> GetSpecificTransitions()
		{
			return null;
		}
	}
}
