namespace KWGameCore.Bank
{
	public class LocalBank : BaseBank
	{
		private const string OLD_SIMPLE_BANK_KEY = "simple_bank_money";

		public override void InitialiseBank(IDelegate del)
		{
		}

		public override void AddMoney(long money, string context = "none", string rewardType = "collect", string currencyID = null)
		{
		}

		public override void OverrideMoney(long money, string currencyId = null)
		{
		}

		public override bool Purchase(long cost, string description = null, string currencyID = null)
		{
			return false;
		}

		public override long FetchCurrentMoney(string currencyID = null)
		{
			return 0L;
		}

		private void MigrateOldBankKeyDataToNewKey()
		{
		}
	}
}
