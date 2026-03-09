using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AnalyticsAdapter : Analytics
	{
		[SerializeField]
		private int countToSend;

		[SerializeField]
		private string apiEndPoint;

		[SerializeField]
		private bool debugMode;

		[SerializeField]
		private bool enableEventsBlacklist;

		[SerializeField]
		private string[] blackListedEvents;

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
