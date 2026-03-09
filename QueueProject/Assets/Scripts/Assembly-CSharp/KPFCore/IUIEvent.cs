using System.Collections.Generic;

namespace KPFCore
{
	public interface IUIEvent
	{
		string EventName { get; }

		Dictionary<string, object> Parameters { get; }

		void Invoke();

		TU GetParameter<TU>(string key);
	}
}
