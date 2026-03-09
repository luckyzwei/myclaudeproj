using System;
using UnityEngine;

namespace KWCore.Debugging
{
	[Serializable]
	public class DebuggerSetting
	{
		[SerializeField]
		private SharedSystems.Systems m_debugSystem;

		[SerializeField]
		private bool m_isEnabled;

		public SharedSystems.Systems DebugSystem
		{
			get
			{
				return default(SharedSystems.Systems);
			}
			set
			{
			}
		}

		public bool IsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string SystemName => null;

		public DebuggerSetting(SharedSystems.Systems debugSystem, bool isEnabled)
		{
		}

		public DebuggerSetting Clone()
		{
			return null;
		}
	}
}
