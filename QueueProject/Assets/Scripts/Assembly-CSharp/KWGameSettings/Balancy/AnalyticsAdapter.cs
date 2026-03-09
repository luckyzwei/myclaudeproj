using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AnalyticsAdapter : Analytics
	{
		public override int CountToSend
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override string ApiEndPoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool DebugMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool EnableEventsBlacklist
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string[] BlackListedEvents
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
