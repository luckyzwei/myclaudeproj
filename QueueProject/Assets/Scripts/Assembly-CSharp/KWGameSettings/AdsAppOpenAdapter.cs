using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsAppOpenAdapter : AdsAppOpen
	{
		[SerializeField]
		private AdsAppOpenLocationAdapter[] locations;

		[SerializeField]
		private bool showOnFirstBoot;

		[SerializeField]
		private int showAfterXBoots;

		[SerializeField]
		private int showEveryXBoots;

		[SerializeField]
		private string adUnitAndroid;

		[SerializeField]
		private string adUnitIos;

		public override OpenAdLocation[] Locations
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool ShowOnFirstBoot
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override int ShowAfterXBoots
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int ShowEveryXBoots
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override string AdUnitAndroid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AdUnitIos
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
