using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class PushNotificationsMessageAdapter : PushNotificationsMessage
	{
		[SerializeField]
		private long timeMS;

		[SerializeField]
		private string title;

		[SerializeField]
		private string message;

		[SerializeField]
		private string messageId;

		public override long TimeMS
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string Message
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string MessageId
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
