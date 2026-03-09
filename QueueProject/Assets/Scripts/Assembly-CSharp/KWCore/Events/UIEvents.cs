using System.Runtime.CompilerServices;

namespace KWCore.Events
{
	public class UIEvents
	{
		public delegate void BasicEvent();

		public delegate void BasicEvent1ArgInt(int x);

		public static event BasicEvent1ArgInt PopUpShown
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

		public static event BasicEvent1ArgInt PopUpClosed
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

		public static event BasicEvent SubscriptionOpened
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

		public static event BasicEvent SubscriptionClosed
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

		public static void SendPopUpShownEvent(int totalActivePopUps)
		{
		}

		public static void SendPopUpClosedEvent(int totalActivePopUps)
		{
		}

		public static void SendSubscriptionOpenedEvent()
		{
		}

		public static void SendSubscriptionClosedEvent()
		{
		}
	}
}
