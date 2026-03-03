using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAdsSupplyGem", false, false)]
public class PopupAdsSupplyGem : UIBase
{
	[SerializeField]
	private Text RewardText;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private Text ViewCount;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	private bool isShowAds;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClickReward()
	{
	}

	private void GetReward()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void Hide()
	{
	}
}
