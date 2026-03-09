using System;
using System.Collections;
using KWCore.CoreRequests;
using KWCore.SaveData;

namespace KWCore.Utils
{
	public class CurrencyUtils
	{
		private const string CURRENCY_RATES_URL_BACKUP = "https://latest.currency-api.pages.dev/v1/currencies/usd.json";

		private const string CURRENCY_RATES_URL = "https://server-live.kwalee.com/get_currency_rate?currency_code={0}";

		private Hashtable m_backupCurrencyRates;

		private SaveDataManager m_saveDataManager;

		private DateTime? m_lastFetchTime;

		private CoreRequestsHandler m_requestHandler;

		private float m_currencyMultiplier;

		public CurrencyUtils(CoreRequestsHandler requestsHandler, SaveDataManager saveDataManager)
		{
		}

		public float? ConvertToUSD(float localisedPrice, string currencyCode)
		{
			return null;
		}

		private CoreRequest GetBackupCurrencyRates()
		{
			return null;
		}

		private CoreRequest GetCurrencyRate(string currencyCode)
		{
			return null;
		}

		private void BackupEventSuccessCallback(string response)
		{
		}

		private void EventSuccessCallback(string response)
		{
		}

		private void OnIAPStoreInitialized(string currencyCode)
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}
	}
}
