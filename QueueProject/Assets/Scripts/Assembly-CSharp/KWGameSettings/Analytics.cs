using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class Analytics
	{
		public abstract int CountToSend { get; set; }

		public abstract string ApiEndPoint { get; set; }

		public abstract bool DebugMode { get; set; }

		public abstract bool EnableEventsBlacklist { get; set; }

		public abstract string[] BlackListedEvents { get; set; }
	}
}
