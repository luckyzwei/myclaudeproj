using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class Links
	{
		public abstract string AppstoreIOSURL { get; set; }

		public abstract string AppstoreAndroidURL { get; set; }

		public abstract string PublishingLink { get; set; }

		public abstract string PublishingBannerURI { get; set; }
	}
}
