using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class FirebaseSettings
	{
		public abstract bool ValidatePurchases { get; set; }
	}
}
