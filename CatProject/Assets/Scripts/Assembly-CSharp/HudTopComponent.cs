using System.Numerics;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class HudTopComponent : MonoBehaviour
{
	[Header("Hud")]
	[SerializeField]
	private Text MoneyText;

	[SerializeField]
	private Text CashText;

	[SerializeField]
	private Text PowerText;

	[Header("Root")]
	[SerializeField]
	private int fixedRegion;

	[SerializeField]
	private GameObject MoneyRoot;

	[SerializeField]
	private GameObject CashRoot;

	[SerializeField]
	private GameObject PowerRoot;

	[Header("Btn")]
	[SerializeField]
	private Button CashBtn;

	[Header("Level")]
	[SerializeField]
	private Text LevelText;

	[SerializeField]
	private Button LevelBtn;

	[Header("Money")]
	[SerializeField]
	private Button MoneyBtn;

	[Header("Power")]
	[SerializeField]
	private Button PowerBtn;

	[Header("MoneyEffect")]
	[SerializeField]
	private GameObject MoneyEffectRoot;

	[SerializeField]
	private Image MoneyEffectIcon;

	[SerializeField]
	private Text MoneyEffectText;

	[Header("PowerEffect")]
	[SerializeField]
	private GameObject PowerEffectRoot;

	[SerializeField]
	private Image PowerEffectIcon;

	[SerializeField]
	private Text PowerEffectText;

	private CompositeDisposable disposables;

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (CashBtn != null) CashBtn.onClick.AddListener(OnClickCashShop);
		if (LevelBtn != null) LevelBtn.onClick.AddListener(OnClickLevelInfo);
		if (MoneyBtn != null) MoneyBtn.onClick.AddListener(OnClickMoney);
		if (PowerBtn != null) PowerBtn.onClick.AddListener(OnClickGotoPower);
	}

	public void Binding()
	{
		if (disposables != null) disposables.Clear();
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		// Bind money display
		if (MoneyText != null && root.UserData.HUDMoney != null)
		{
			root.UserData.HUDMoney
				.Subscribe(val => MoneyText.text = FormatBigNumber(val))
				.AddTo(disposables);
		}

		// Bind level display
		if (LevelText != null && root.UserData.Level != null)
		{
			root.UserData.Level
				.Subscribe(val => LevelText.text = "Lv." + val)
				.AddTo(disposables);
		}

		// Bind cash display
		if (CashText != null && root.UserData.HUDCash != null)
		{
			root.UserData.HUDCash
				.Subscribe(val => CashText.text = val.ToString())
				.AddTo(disposables);
		}
	}

	private static string FormatBigNumber(System.Numerics.BigInteger val)
	{
		if (val < 1000) return val.ToString();
		if (val < 1000000) return (val / 1000).ToString() + "K";
		if (val < 1000000000) return (val / 1000000).ToString() + "M";
		return (val / 1000000000).ToString() + "B";
	}

	public void SetSeasonal()
	{
		if (PowerRoot != null) PowerRoot.SetActive(false);
		if (LevelText != null) LevelText.gameObject.SetActive(false);
	}

	private void SetShop()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public Transform GetTrans(Config.CurrencyID currency)
	{
		switch (currency)
		{
			case Config.CurrencyID.Gold:
				return MoneyText != null ? MoneyText.transform : null;
			case Config.CurrencyID.Cash:
				return CashText != null ? CashText.transform : null;
			default:
				return PowerText != null ? PowerText.transform : null;
		}
	}

	public Transform GetLevelTrans()
	{
		return LevelText != null ? LevelText.transform : null;
	}

	public void SetTempLevelText(int value)
	{
		if (LevelText != null)
			LevelText.text = value.ToString();
	}

	public void ShowPowerEffect(int region)
	{
		if (PowerEffectRoot != null)
			PowerEffectRoot.SetActive(true);
		SetPowerEffectText(region);
	}

	public void HidePowerEffect(int region, bool direct = false)
	{
		if (PowerEffectRoot != null)
			PowerEffectRoot.SetActive(false);
	}

	private void SetPowerEffectText(int region)
	{
		if (PowerEffectText == null) return;
		PowerEffectText.text = "";
	}

	public void ShowMoneyEffect(int region)
	{
		if (MoneyEffectRoot != null)
			MoneyEffectRoot.SetActive(true);
		SetMoneyEffectText(region);
	}

	public void HideMoneyEffect(int region)
	{
		if (MoneyEffectRoot != null)
			MoneyEffectRoot.SetActive(false);
	}

	private void SetMoneyEffectText(int region)
	{
		if (MoneyEffectText == null) return;
		MoneyEffectText.text = "";
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}

	public void Unbinding()
	{
		if (disposables != null)
			disposables.Clear();
	}

	private void OnClickCashShop()
	{
		SetShop();
	}

	private void OnClickLevelInfo()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOfficeUpgrade>();
	}

	private void OnClickMoney()
	{
		SetShop();
	}

	private void OnClickGotoPower()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOfficeUpgrade>();
	}
}
