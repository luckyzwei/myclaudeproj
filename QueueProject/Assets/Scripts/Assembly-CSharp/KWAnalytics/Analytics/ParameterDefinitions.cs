using System;
using System.Collections.Generic;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class ParameterDefinitions
	{
		public List<ParameterDefinition> parameters;

		private Dictionary<string, ParameterDefinition> m_parameterDictionary;

		public void InitialiseParametersConfigDictionary()
		{
		}

		public bool TryGetParameterDefinition(string field, out ParameterDefinition parameterDefinition)
		{
			parameterDefinition = null;
			return false;
		}
	}
}
