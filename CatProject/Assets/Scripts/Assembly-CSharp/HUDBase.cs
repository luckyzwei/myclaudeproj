using UnityEngine;
using UnityEngine.UI;

public class HUDBase : HUDAniBase
{
	public enum E_RefreshType
	{
		ShopSale = 0,
		SpecialDay = 1,
		Package = 2,
		MiniGame = 3
	}

	public enum E_HUDPosType
	{
		RentalFee = 0
	}

	[Header("[HUDBase]")]
	[SerializeField]
	private HudTopComponent CurrencyHud;

	[SerializeField]
	private Transform ShopT;

	private Vector3 ShopOriginP;

	[Header("Day")]
	[SerializeField]
	private Image TimeIcon;

	[SerializeField]
	private Text TimeText;

	protected override void Awake()
	{
	}

	public virtual void Refresh(E_RefreshType refreshType)
	{
	}

	public virtual Vector3 GetHUDPos(E_HUDPosType posType, int rewardType = 0, int rewardIdx = 0)
	{
		return default(Vector3);
	}

	protected void SetDayTime()
	{
	}

	protected void UpdateDayStatus(DaySystem.DayStatus status)
	{
	}

	protected void UpdateDayTime()
	{
	}

	public void StartPowerEffect(int region)
	{
	}

	public void EndPowerEffect(int region, bool direct = false)
	{
	}

	public void StartMoneyEffect(int region)
	{
	}

	public void EndMoneyEffect(int region)
	{
	}

	public Vector3 GetHUDWorldPos(Config.CurrencyID type)
	{
		return default(Vector3);
	}

	public Vector3 GetHUDShopPos()
	{
		return default(Vector3);
	}

	public Vector3 GetLevelPos()
	{
		return default(Vector3);
	}

	public void SetTempLevel(int value = -1)
	{
	}
}
