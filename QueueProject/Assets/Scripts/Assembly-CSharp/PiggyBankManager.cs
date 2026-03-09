using System;
using Balancy.Models.SmartObjects;
using KWCore.Utils;

public class PiggyBankManager : Singleton<PiggyBankManager>
{
	public const string NOTIFICATION_WIDGET_ID = "PiggyBank";

	private PiggyBankWidget m_activeWidgetOnScreen;

	protected override void Init()
	{
	}

	public void RegisterActiveWidget(PiggyBankWidget piggyBankWidget)
	{
	}

	public long GetStoredCurrencyAmount()
	{
		return 0L;
	}

	public bool IsAtMaxCapacity()
	{
		return false;
	}

	public int GetMaxCapacity()
	{
		return 0;
	}

	private long GetPiggyBankCurrencyAmountToAward(bool wasRV)
	{
		return 0L;
	}

	private ItemWithAmount GetPiggyRewardItemWithAmount(bool forRV = false)
	{
		return null;
	}

	public Reward CreateReward(bool rv)
	{
		return null;
	}

	public void StorePiggyBankCurrency(ref Reward reward)
	{
	}

	public bool IsPiggyBankActive()
	{
		return false;
	}

	public int UnlockLevel()
	{
		return 0;
	}

	public PopUpPiggyBank OpenPiggyBankPopUp()
	{
		return null;
	}

	public void AwardPiggyBankCurrencyAndReset(string rewardPopUpName, Action currencyGivenCallback)
	{
	}

	public void AddPiggyAsRewardForWidget(ref RewardWidget rewardWidget)
	{
	}

	public void PiggyIapPurchased()
	{
	}
}
