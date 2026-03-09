using Balancy.Data;
using Balancy.Models.KWSpinWheel;
using Balancy.Models.SmartObjects;
using KWCore.Utils;

public class SpinWheelManager : Singleton<SpinWheelManager>
{
	public const string NOTIFICATION_WIDGET_FREE_ID = "SpinWheelFree";

	public const string NOTIFICATION_WIDGET_RV_ID = "SpinWheelRv";

	public GeneralSpinWheelSettings GeneralSpinWheelSettings => null;

	public KWSpinWheelData SpinWheelData => null;

	public bool IsEnabled => false;

	public int UnlockLevel => 0;

	public bool isUnlocked => false;

	protected override void Init()
	{
	}

	public SpinWheelActivation GetCurrentActivation()
	{
		return null;
	}

	public long GetCoolDown()
	{
		return 0L;
	}

	public SpinWheelActivation GetActivation(int index)
	{
		return null;
	}

	public void TryResetStartingSpin()
	{
	}

	public void SpinComplete()
	{
	}

	public SpinType GetCurrentSpinType()
	{
		return default(SpinType);
	}

	public Price GetCurrentSpinPrice()
	{
		return null;
	}

	private long GetSecondsUntilNextSpin()
	{
		return 0L;
	}

	public void SaveRewardIndex(int index)
	{
	}

	public void TryGiveRewardFromCache()
	{
	}
}
