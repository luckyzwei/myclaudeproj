using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class UserConsentFormsAdapter : UserConsentForms
	{
		public override GDPR GDPR { get; set; }
	}
}
