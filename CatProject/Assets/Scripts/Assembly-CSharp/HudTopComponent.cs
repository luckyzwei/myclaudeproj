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
	}

	public void Binding()
	{
	}

	public void SetSeasonal()
	{
	}

	private void SetShop()
	{
	}

	public Transform GetTrans(Config.CurrencyID currency)
	{
		return null;
	}

	public Transform GetLevelTrans()
	{
		return null;
	}

	public void SetTempLevelText(int value)
	{
	}

	public void ShowPowerEffect(int region)
	{
	}

	public void HidePowerEffect(int region, bool direct = false)
	{
	}

	private void SetPowerEffectText(int region)
	{
	}

	public void ShowMoneyEffect(int region)
	{
	}

	public void HideMoneyEffect(int region)
	{
	}

	private void SetMoneyEffectText(int region)
	{
	}

	private void OnDestroy()
	{
	}

	public void Unbinding()
	{
	}

	private void OnClickCashShop()
	{
	}

	private void OnClickLevelInfo()
	{
	}

	private void OnClickMoney()
	{
	}

	private void OnClickGotoPower()
	{
	}
}
