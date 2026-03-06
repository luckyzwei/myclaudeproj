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
		base.Awake();
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnClickReward);
	}

	protected override void OnEnable()
	{
		base.OnEnable();
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClickReward()
	{
		if (isShowAds) return;
		isShowAds = true;
		GetReward();
	}

	private void GetReward()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Give gem reward to player
		Hide();
	}

	public override void OnShowBefore()
	{
		isShowAds = false;
		if (oneTimeComponent != null) oneTimeComponent.gameObject.SetActive(false);
	}

	public override void Hide()
	{
		base.Hide();
	}
}
