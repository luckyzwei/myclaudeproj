using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class UserConsentFormsAdapter : UserConsentForms
	{
		[SerializeField]
		private GDPRAdapter gdpr;

		public override GDPR GDPR
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
