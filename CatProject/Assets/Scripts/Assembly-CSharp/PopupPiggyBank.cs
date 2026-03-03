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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnShowAfter()
	{
	}

	private void UpdateLevel()
	{
	}

	private void UpdateLevelReward()
	{
	}

	private void OnClickLevelInfo()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
