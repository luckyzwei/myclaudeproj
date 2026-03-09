using System;
using System.Runtime.CompilerServices;

namespace KWGDPR.GDPR
{
	public class GDPREvents
	{
		public static event Action<bool> GDPRCanTrackEvent
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

		public static event Action<bool> DelayedGDPRCanTrackEvent
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

		public static void SendGDPRCanTrackEvent(bool canTrack)
		{
		}

		public static void SendDelayedGDPRCanTrackEvent(bool canTrack)
		{
		}
	}
}
