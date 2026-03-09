namespace KWGameSettings.Balancy
{
	public class XPromoAdapter : XPromo
	{
		public override string PrivacyURL { get; set; }

		public override int GraphicsMemorySize { get; set; }

		public override string SystemVersion { get; set; }

		public override string AppstoreWebsiteUserAgent { get; set; }

		public override bool EnableLowEndDeviceSupportTest { get; set; }
	}
}
