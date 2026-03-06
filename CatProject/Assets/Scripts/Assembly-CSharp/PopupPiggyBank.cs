using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupPiggyBank", false, false)]
public class PopupPiggyBank : UIBase
{
	[SerializeField]
	private Text CashText;

	[SerializeField]
	private PiggyBankComponent piggyComp;

	[Header("LevelInfo")]
	[SerializeField]
	private Image NextPiggyImg;

	[SerializeField]
	private GameObject NextLevelRoot;

	[SerializeField]
	private Text NextLevelText;

	[SerializeField]
	private Text CurMaxFullCountText;

	[SerializeField]
	private Text NextMaxFullCountText;

	[SerializeField]
	private Button LevelInfoBtn;

	[Header("LevelReward")]
	[SerializeField]
	private Transform RewardRoot;

	[SerializeField]
	private List<ItemPiggyLvReward> RewardItems;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		if (LevelInfoBtn != null) LevelInfoBtn.onClick.AddListener(OnClickLevelInfo);
	}

	public override void OnShowBefore()
	{
		UpdateLevel();
		UpdateLevelReward();
	}

	public override void OnShowAfter()
	{
		if (piggyComp != null) piggyComp.Init(false);
	}

	private void UpdateLevel()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (NextLevelRoot != null) NextLevelRoot.SetActive(true);
	}

	private void UpdateLevelReward()
	{
		if (RewardItems == null) return;
		for (int i = 0; i < RewardItems.Count; i++)
		{
			if (RewardItems[i] != null)
				RewardItems[i].gameObject.SetActive(true);
		}
	}

	private void OnClickLevelInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
