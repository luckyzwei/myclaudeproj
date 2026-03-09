namespace KWGameSettings.Balancy
{
	public class AdsAppOpenAdapter : AdsAppOpen
	{
		public override OpenAdLocation[] Locations { get; set; }

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
