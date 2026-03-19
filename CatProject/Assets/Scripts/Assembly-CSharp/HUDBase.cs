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
	protected HudTopComponent CurrencyHud;

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
		// Virtual base - override in subclass
	}

	public virtual Vector3 GetHUDPos(E_HUDPosType posType, int rewardType = 0, int rewardIdx = 0)
	{
		return default(Vector3);
	}

	protected void SetDayTime()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.DaySystem == null) return;
		UpdateDayStatus(root.DaySystem.CurTimeStatus.Value);
	}

	protected void UpdateDayStatus(DaySystem.DayStatus status)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.DaySystem == null) return;

		if (TimeText != null)
		{
			int hour = (int)root.DaySystem.DayTime;
			int min = (int)((root.DaySystem.DayTime - hour) * 60);
			TimeText.text = hour.ToString("D2") + ":" + min.ToString("D2");
		}
	}

	protected void UpdateDayTime()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.DaySystem == null) return;
		UpdateDayStatus(root.DaySystem.CurTimeStatus.Value);
	}

	public void StartPowerEffect(int region)
	{
		if (CurrencyHud != null)
			CurrencyHud.ShowPowerEffect(region);
	}

	public void EndPowerEffect(int region, bool direct = false)
	{
		if (CurrencyHud != null)
			CurrencyHud.HidePowerEffect(region, direct);
	}

	public void StartMoneyEffect(int region)
	{
		if (CurrencyHud != null)
			CurrencyHud.ShowMoneyEffect(region);
	}

	public void EndMoneyEffect(int region)
	{
		if (CurrencyHud != null)
			CurrencyHud.HideMoneyEffect(region);
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
			var trans = CurrencyHud.GetTrans(Config.CurrencyID.Gold);
			if (trans != null) return trans.position;
		}
		return default(Vector3);
	}

	public void SetTempLevel(int value = -1)
	{
		if (CurrencyHud != null && value >= 0)
			CurrencyHud.SetTempLevelText(value);
	}
}
