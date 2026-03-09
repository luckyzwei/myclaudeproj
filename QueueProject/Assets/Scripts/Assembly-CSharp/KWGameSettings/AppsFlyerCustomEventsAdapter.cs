using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AppsFlyerCustomEventsAdapter : AppsFlyerCustomEvents
	{
		[SerializeField]
		private string eventName;

		[SerializeField]
		private bool enabled;

		[SerializeField]
		private int[] eventValues;

		public override string EventName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override int[] EventValues
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
