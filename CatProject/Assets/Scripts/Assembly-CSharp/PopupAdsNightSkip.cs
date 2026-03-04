using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAdsNightSkip", false, false)]
public class PopupAdsNightSkip : UIBase
{
	[SerializeField]
	private Button AdsSkipBtn;

	[SerializeField]
	private Text SkipDescText;

	[SerializeField]
	private Text RewardText;

	[SerializeField]
	private Text RentalFee;

	[SerializeField]
	private GameObject RevenueObj;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	private bool IsMainGame;

	private BigInteger NightSkipRewardValue;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public override void OnShowBefore()
	{
	}

	private void SetMainGameLayout()
	{
	}

	private void SetSeasonalLayout()
	{
	}

	private void SetRewardText(BigInteger value)
	{
	}

	private void SetRentalFeeText()
	{
	}

	private void OnClickSkip()
	{
	}

	private void SkipNight()
	{
	}
}
