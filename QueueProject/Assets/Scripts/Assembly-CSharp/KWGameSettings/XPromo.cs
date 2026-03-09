using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class XPromo
	{
		public abstract string PrivacyURL { get; set; }

		public abstract int GraphicsMemorySize { get; set; }

		public abstract string SystemVersion { get; set; }

		public abstract string AppstoreWebsiteUserAgent { get; set; }

		public abstract bool EnableLowEndDeviceSupportTest { get; set; }
	}
}
