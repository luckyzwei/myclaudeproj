using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KWCore.Utils
{
	public class DeviceSettings
	{
		public delegate void AdvertisingIdCallback(string id, bool isTrackingAllowed);

		public class InstalledKeyboard
		{
			public string languageID;

			public string languageDisplayName;
		}

		public delegate void RecievedCountryCodeNetworkDelegate(string code);

		public delegate void RecievedCountryCodeDelegate(string code);

		private const string COUNTRY_CODE_URL = "https://server-live.kwalee.com/get_country";

		private string m_advertisingId;

		private bool m_isTrackingAllowed;

		private string m_countryCode;

		protected string m_storeCountryCode;

		protected static string[] s_supportedLanguages;

		public AdvertisingIdCallback advertisingIdCallback;

		protected List<InstalledKeyboard> m_keyboards;

		public static event RecievedCountryCodeNetworkDelegate RecievedCountryCodeNetwork
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event RecievedCountryCodeDelegate RecievedCountryCode
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<bool> IDFAReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void SendRecievedCountryCodeNetworkEvent(string code)
		{
		}

		public static void SendRecievedCountryCodeEvent(string code)
		{
		}

		public static void SendIDFAReceivedEvent(bool trackingEnabled)
		{
		}

		public virtual List<InstalledKeyboard> GetKeyboards()
		{
			return null;
		}

		protected string GetLanguageCodeFromUnitySystemLanguage()
		{
			return null;
		}

		public virtual void Initialise()
		{
		}

		public virtual void OnReceivedStoreCountryCode(string countryCode)
		{
		}

		public virtual bool RunAdvertisingIdPlugin(AdvertisingIdCallback callback)
		{
			return false;
		}

		public void SetAdvertisingInfo(string id, bool isTrackingAllowed)
		{
		}

		public void SendLocationRequest()
		{
		}

		protected void SendStoreCountryReceivedEvent(string countryCode)
		{
		}

		private void LocationRequestSuccess(string response)
		{
		}

		private void LocationRequestError(long errorCode, string error)
		{
		}

		public virtual string GetLanguageCode()
		{
			return null;
		}

		public string GetCountryCodeFromAppStore()
		{
			return null;
		}

		public virtual void RequestProductLocale(string productID)
		{
		}

		public virtual void RequestCountryCodeFromNetwork()
		{
		}

		public virtual void RequestStoragePermision(string title, string body, string okay)
		{
		}

		public virtual void RequestIDFA()
		{
		}

		public virtual void SetAdvertiserTrackingEnabled(bool trackingEnabled)
		{
		}

		public virtual bool IsHardIDFAAvailable()
		{
			return false;
		}

		public virtual bool IsSoftIDFAAvailable()
		{
			return false;
		}

		public virtual bool HasStoragePermission()
		{
			return false;
		}

		public virtual float OSVersionNumberAsFloat()
		{
			return 0f;
		}

		public virtual string ShortOSVersionNumber()
		{
			return null;
		}

		public virtual string GetMobileNetworkRegion()
		{
			return null;
		}

		public virtual void HandleIDFAResponseReceived(string status)
		{
		}

		public float GetPhysicalDiagonalScreenSizeInInches()
		{
			return 0f;
		}

		public virtual bool IsTablet()
		{
			return false;
		}
	}
}
