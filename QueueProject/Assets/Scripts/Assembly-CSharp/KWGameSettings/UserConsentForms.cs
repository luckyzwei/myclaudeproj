using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class UserConsentForms
	{
		public abstract GDPR GDPR { get; set; }
	}
}
