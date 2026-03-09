using System;
using System.Collections;
using System.Collections.Generic;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public abstract class BaseSchema
	{
		protected bool m_validateEvents;

		protected string m_eventName;

		private string m_eventJoinID;

		private Dictionary<string, object> m_dataDict;

		private Dictionary<string, object> m_dataDictRaw;

		public string EventName => null;

		public BaseSchema()
		{
		}

		public void SetDictValue<T>(object value) where T : AnalyticParameterTypes.BaseParameterType, new()
		{
		}

		protected U GetDictValue<T, U>() where T : AnalyticParameterTypes.BaseParameterType, new()
		{
			return default(U);
		}

		protected virtual void ApplySpecialParams()
		{
		}

		public Dictionary<string, object> GetDataDictionary()
		{
			return null;
		}

		public Dictionary<string, object> GetRawDataDictionary()
		{
			return null;
		}

		public Hashtable GetDataHastable()
		{
			return null;
		}

		public string GetDataDictionaryAsJson()
		{
			return null;
		}
	}
}
