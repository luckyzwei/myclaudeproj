using System.Collections.Generic;

namespace KWGameCore.Bank
{
	public abstract class BaseBank
	{
		public interface IDelegate
		{
			string GetGameRewardCurrencyID();

			List<string> GetGameCurrenciesKanga();
		}

		protected const string EARNED_CONTEXT = "currency_earned";

		protected const string PURCHASE_CONTEXT = "purchase";

		protected const string OVERRIDE_CONTEXT = "override";

		private IDelegate m_bankDelegate;

		private Dictionary<string, long> m_moneyAtStartOfStage;

		private Dictionary<string, long> m_newBankValue;

		private string m_lastBankEventId;

		private int m_bankEventKey;

		private int m_totalBankEventMoney;

		public abstract void AddMoney(long money, string context = "none", string rewardType = "collect", string currencyID = null);

		public abstract void OverrideMoney(long money, string currencyId = null);

		public abstract bool Purchase(long cost, string description = null, string currencyID = null);

		public abstract long FetchCurrentMoney(string currencyID = null);

		public virtual void InitialiseBank(IDelegate del)
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual bool CanAfford(long cost, string currencyID = null)
		{
			return false;
		}

		public string GetGameRewardCurrencyID()
		{
			return null;
		}

		protected List<string> GetGameCurrenciesKanga()
		{
			return null;
		}

		protected void SendBankAnalyticsEvent(string eventType, int money, long total, string context = "", string rewardType = "")
		{
		}

		private void HandleBankValueChanged(long newValue, string currencyID, long diffAmount)
		{
		}

		private void SetStageStartingMoney()
		{
		}

		private void SetStageStartingMoney(string currencyID)
		{
		}

		private void TryAddMoneyEntry(string currencyID, Dictionary<string, long> moneyEntries)
		{
		}

		public long GetMoneyEarnedOnCurrentStage(string currencyID)
		{
			return 0L;
		}
	}
}
