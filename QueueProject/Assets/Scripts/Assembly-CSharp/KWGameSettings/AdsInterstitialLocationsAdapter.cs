using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsInterstitialLocationsAdapter : AdsInterstitialLocation
	{
		[SerializeField]
		private string location;

		[SerializeField]
		private bool canShow;

		[SerializeField]
		private long cooldown;

		[SerializeField]
		private int cooldownByLevel;

		[SerializeField]
		private float probability;

		[SerializeField]
		private bool enableAdBreakPopup;

		[SerializeField]
		private float[] impressionsThreshold;

		[SerializeField]
		private float[] noFillImpressionsThreshold;

		public override string Location
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool CanShow
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override long Cooldown
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override int CooldownByLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override float Probability
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override bool EnableAdBreakPopup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override float[] ImpressionsThreshold
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override float[] NoFillImpressionsThreshold
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
