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
		base.Awake();
		disposables = new CompositeDisposable();
		if (AdsSkipBtn != null) AdsSkipBtn.onClick.AddListener(OnClickSkip);
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	public override void OnShowBefore()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		IsMainGame = root.UserData != null;
		if (IsMainGame)
			SetMainGameLayout();
		else
			SetSeasonalLayout();
	}

	private void SetMainGameLayout()
	{
		if (RevenueObj != null) RevenueObj.SetActive(true);
		SetRentalFeeText();
		SetRewardText(NightSkipRewardValue);
	}

	private void SetSeasonalLayout()
	{
		if (RevenueObj != null) RevenueObj.SetActive(false);
		SetRewardText(NightSkipRewardValue);
	}

	private void SetRewardText(BigInteger value)
	{
		if (RewardText != null)
			RewardText.text = ProjectUtility.GetThousandCommaText(value);
	}

	private void SetRentalFeeText()
	{
		if (RentalFee != null) RentalFee.text = "";
	}

	private void OnClickSkip()
	{
		SkipNight();
	}

	private void SkipNight()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		Hide();
	}
}
