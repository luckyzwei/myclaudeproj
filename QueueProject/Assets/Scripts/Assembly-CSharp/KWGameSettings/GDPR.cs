using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class GDPR
	{
		public abstract string[] EuCountries { get; set; }

		public abstract string PrivacyPolicyLink { get; set; }

		public abstract string TermsAndConditionsLink { get; set; }
	}
}
