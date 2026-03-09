using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KWCore.Facebook
{
	public class FacebookEvents
	{
		public static event Action<string, Dictionary<string, object>> FacebookRegisteredEvent
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

		public static void SendFacebookRegisteredEvent(string eventName, Dictionary<string, object> parameters)
		{
		}
	}
}
