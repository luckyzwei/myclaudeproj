using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class GDPRAdapter : GDPR
	{
		public override string[] EuCountries
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string PrivacyPolicyLink
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string TermsAndConditionsLink
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
