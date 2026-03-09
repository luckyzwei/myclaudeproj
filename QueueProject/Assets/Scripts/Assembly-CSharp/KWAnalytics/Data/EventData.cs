using System;
using System.Collections.Generic;

namespace KWAnalytics.Data
{
	[Serializable]
	public class EventData
	{
		public string name;

		public string description;

		public List<ParameterData> parameters;
	}
}
