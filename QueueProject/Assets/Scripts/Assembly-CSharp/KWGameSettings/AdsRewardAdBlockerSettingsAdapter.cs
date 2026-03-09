using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsRewardAdBlockerSettingsAdapter : AdsRewardAdBlockerSettings
	{
		[SerializeField]
		private bool enabled;

		[SerializeField]
		private long duration;

		[SerializeField]
		private long overtimeToKill;

		[SerializeField]
		private long retryInterval;

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

		public override long Duration
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override long OvertimeToKill
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override long RetryInterval
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}
	}
}
