using System;
using System.Numerics;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemMilestoneProgress : MonoBehaviour
{
	[SerializeField]
	private Text SeasonRemainTimeText;

	[SerializeField]
	private Image SeasonMainIconImage;

	[SerializeField]
	private Text MilestoneProgressText;

	[SerializeField]
	private Slider MilestoneStepProgressSlider;

	[SerializeField]
	private Image MilestoneCurrencyIconImage;

	[SerializeField]
	private Text MilestoneCurrencyIncomeText;

	[SerializeField]
	private ItemArticle MilestoneStepRewardItem;

	private DateTime SeasonEndDateTime;

	private bool bEndSeasonTime;

	private int MilestoneCurrencyIdx;

	private CompositeDisposable Disposables;

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init()
	{
	}

	private void SubscribeEvents()
	{
	}

	private void UpdateMilestoneCurrencyInfo()
	{
	}

	private void UpdateMilestoneStepInfo()
	{
	}

	private void SetSeasonMainIconImage(string iconKey)
	{
	}

	private void SetSeasonRemainTimeText(int remainSec)
	{
	}

	private void SetMilestoneProgressText(int curStep, int maxStep)
	{
	}

	private void UpdateMilestoneStepProgressSlider()
	{
	}

	private void SetMilestoneCurrencyIconImage(string iconKey)
	{
	}

	private void SetMilestoneStepRewardItem(SeasonalRewardData rewardTableData)
	{
	}

	private void SetMilestoneCurrencyInfoText(BigInteger totalValue, BigInteger goalValue)
	{
	}
}
