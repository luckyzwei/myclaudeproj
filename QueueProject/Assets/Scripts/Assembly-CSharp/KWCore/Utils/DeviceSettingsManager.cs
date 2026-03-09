using UnityEngine;

namespace KWCore.Utils
{
	public class DeviceSettingsManager : MonoBehaviour
	{
		private DeviceSettings m_settings;

		public DeviceSettings Settings => null;

		public void Initialise()
		{
		}

		public void SendLocationRequest()
		{
		}

		public void _OnProductLocaleFetched(string countryCode)
		{
		}

		public void _OnIDFAReceived(string status)
		{
		}

		public void _OnAdvertisingIDReceived(string result)
		{
		}

		public void OnReceivedStoreCountryCode(string countryCode)
		{
		}
	}
}
