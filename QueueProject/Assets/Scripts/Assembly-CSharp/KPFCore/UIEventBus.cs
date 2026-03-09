using System.Collections.Generic;

namespace KPFCore
{
	public static class UIEventBus
	{
		private static readonly List<IUIEvent> events;

		public static void Invoke<T>() where T : IUIEvent
		{
		}

		public static void Register<T>(T evt) where T : IUIEvent
		{
		}

		public static void Unregister<T>(T evt) where T : IUIEvent
		{
		}
	}
}
