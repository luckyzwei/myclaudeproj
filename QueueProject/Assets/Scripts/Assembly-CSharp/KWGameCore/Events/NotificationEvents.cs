using System;
using System.Runtime.CompilerServices;

namespace KWGameCore.Events
{
	public class NotificationEvents
	{
		public static event Action<string> ApnsTokenReceived
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

		public static void SendApnsTokenReceivedEvent(string token)
		{
		}
	}
}
