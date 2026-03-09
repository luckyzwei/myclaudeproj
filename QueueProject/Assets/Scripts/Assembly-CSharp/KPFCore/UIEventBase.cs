using System;
using System.Collections.Generic;

namespace KPFCore
{
	public abstract class UIEventBase<T> : IDisposable, IUIEvent where T : IUIEvent
	{
		public virtual string EventName => null;

		public Dictionary<string, object> Parameters { get; protected set; }

		public void Invoke()
		{
		}

		public TU GetParameter<TU>(string key)
		{
			return default(TU);
		}

		public void Dispose()
		{
		}
	}
}
