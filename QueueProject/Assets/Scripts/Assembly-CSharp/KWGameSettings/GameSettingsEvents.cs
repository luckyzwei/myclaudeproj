using System.Runtime.CompilerServices;

namespace KWGameSettings
{
	public class GameSettingsEvents
	{
		public delegate void BasicEvent();

		public static event BasicEvent GameSettingsUpdated
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

		public static void SendGameSettingsUpdatedEvent()
		{
		}
	}
}
