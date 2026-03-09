using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class FirebaseSettingsAdapter : FirebaseSettings
	{
		[SerializeField]
		private bool validatePurchases;

		public override bool ValidatePurchases
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
