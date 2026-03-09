using System;
using System.Runtime.CompilerServices;

namespace KPFCore
{
	public static class UIEvents
	{
		public static event Action<IUIEvent> UIEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void SendUIEvent(IUIEvent evt)
		{
		}
	}
}
