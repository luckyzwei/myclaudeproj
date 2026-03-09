using System.Collections.Generic;
using UnityEngine;

namespace KWCore.Debugging
{
	public class DebuggerSettingsScriptable : ScriptableObject
	{
		public const string SCRIPTABLE_PATH = "Assets/Resources/DebuggerSettings";

		public const string SCRIPTABLE_FILENAME = "DebuggerSettings.asset";

		public const string SCRIPTABLE_FULL_PATH = "Assets/Resources/DebuggerSettings/DebuggerSettings.asset";

		public const string SCRIPTABLE_RESOURCES_PATH = "DebuggerSettings/DebuggerSettings";

		private const bool DEFAULT_SYSTEM_VALUE = true;

		[SerializeField]
		private List<DebuggerSetting> m_debuggerSettings;

		[SerializeField]
		private bool m_debugConsoleEnabled;

		public List<DebuggerSetting> DebuggerSettings => null;

		public bool DebugConsoleEnabled => false;

		public DebuggerSettingsScriptable()
		{
		}

		public DebuggerSettingsScriptable(List<DebuggerSetting> settings)
		{
		}

		public void SetAllEnabled(bool value)
		{
		}
	}
}
