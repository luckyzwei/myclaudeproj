using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class XPromoAdapter : XPromo
	{
		[SerializeField]
		private string privacyURL;

		[SerializeField]
		private int graphicsMemorySize;

		[SerializeField]
		private string systemVersion;

		[SerializeField]
		private string appstoreWebsiteUserAgent;

		[SerializeField]
		private bool enableLowEndDeviceSupportTest;

		public override string PrivacyURL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int GraphicsMemorySize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override string SystemVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AppstoreWebsiteUserAgent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool EnableLowEndDeviceSupportTest
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
