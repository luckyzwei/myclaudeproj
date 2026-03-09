using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class GDPRAdapter : GDPR
	{
		[SerializeField]
		private string[] euCountries;

		[SerializeField]
		private string privacyPolicyLink;

		[SerializeField]
		private string termsAndConditionsLink;

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
