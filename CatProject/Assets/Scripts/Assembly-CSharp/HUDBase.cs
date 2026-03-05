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
		base.Awake();
		if (ShopT != null)
			ShopOriginP = ShopT.position;
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
		// Initialize day time display
	}

	protected void UpdateDayStatus(DaySystem.DayStatus status)
	{
		// Update time icon based on day status (day/evening/night)
	}

	protected void UpdateDayTime()
	{
		// Update time text display
	}

	public void StartPowerEffect(int region)
	{
		if (CurrencyHud != null)
			CurrencyHud.ShowPowerEffect(region);
	}

	public void EndPowerEffect(int region, bool direct = false)
	{
		// End power effect on currency HUD
	}

	public void StartMoneyEffect(int region)
	{
		if (CurrencyHud != null)
			CurrencyHud.ShowMoneyEffect(region);
	}

	public void EndMoneyEffect(int region)
	{
		// End money effect on currency HUD
	}

	public Vector3 GetHUDWorldPos(Config.CurrencyID type)
	{
		if (CurrencyHud != null)
		{
			var trans = CurrencyHud.GetTrans(type);
			if (trans != null) return trans.position;
		}
		return default(Vector3);
	}

	public Vector3 GetHUDShopPos()
	{
		return ShopOriginP;
	}

	public Vector3 GetLevelPos()
	{
		if (CurrencyHud != null)
		{
			var trans = CurrencyHud.GetTrans(Config.CurrencyID.Level);
			if (trans != null) return trans.position;
		}
		return default(Vector3);
	}

	public void SetTempLevel(int value = -1)
	{
		// Temporarily override level display
	}
}
