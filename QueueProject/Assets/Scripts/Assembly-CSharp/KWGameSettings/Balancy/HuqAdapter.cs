using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class HuqAdapter : Huq
	{
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

		public override string[] HuqCountries
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
