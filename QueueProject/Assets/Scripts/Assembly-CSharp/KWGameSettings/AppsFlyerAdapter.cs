using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AppsFlyerAdapter : AppsFlyer
	{
		[SerializeField]
		private AppsFlyerCustomEventsAdapter[] customEvents;

		[SerializeField]
		private int systemDisableAfterHours;

		[SerializeField]
		private int attributionWindow;

		[SerializeField]
		private bool sendRevenueData;

		[SerializeField]
		private int idleThresholdSeconds;

		public override AppsFlyerCustomEvents[] CustomEvents
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int SystemDisableAfterHours
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override bool SendRevenueData
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override int IdleThresholdSeconds
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
