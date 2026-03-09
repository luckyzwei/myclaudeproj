using System.Collections.Generic;
using Balancy.Models;
using Balancy.Models.SmartObjects;

namespace KWGameCore.Bank
{
	public class BalancyBank : BaseBank
	{
		private Dictionary<string, string> m_currencies;

		public override void InitialiseBank(IDelegate del)
		{
		}

		private bool IsValidId(string currencyId)
		{
			return false;
		}

		private KwaleeItem GetCurrencyModel(string currencyId)
		{
			return null;
		}

		private void UpdateCurrencies(Item item, int count, int slotindex)
		{
		}

		private void BalancyBootstrapEventsOnProfileWasReset()
		{
		}

		private void OnSdkLoaded()
		{
		}

		public void RegisterCustomCurrencies(List<KwaleeItem> currencies)
		{
		}

		public override void AddMoney(long money, string context = "none", string rewardType = "collect", string currencyID = null)
		{
		}

		public void AddMoney(long money, KwaleeItem currency, string context = "none", string rewardType = "collect")
		{
		}

		public override void OverrideMoney(long money, string currencyID = null)
		{
		}

		public void OverrideMoney(long money, KwaleeItem currency)
		{
		}

		public override bool Purchase(long cost, string description = null, string currencyID = null)
		{
			return false;
		}

		public bool Purchase(long cost, KwaleeItem currency, string description = null)
		{
			return false;
		}

		public override long FetchCurrentMoney(string currencyID = null)
		{
			return 0L;
		}

		public long FetchCurrentMoney(KwaleeItem currency)
		{
			return 0L;
		}

		public override bool CanAfford(long cost, string currencyID = null)
		{
			return false;
		}

		public bool CanAfford(long cost, KwaleeItem currency)
		{
			return false;
		}
	}
}
