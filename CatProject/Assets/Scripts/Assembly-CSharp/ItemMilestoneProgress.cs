using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		if (bEndSeasonTime) return;
		if (SeasonEndDateTime <= DateTime.MinValue) return;

		int remainSec = (int)(SeasonEndDateTime - DateTime.UtcNow).TotalSeconds;
		if (remainSec <= 0)
		{
			bEndSeasonTime = true;
			SetSeasonRemainTimeText(0);
			return;
		}
		SetSeasonRemainTimeText(remainSec);
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	public void Init()
	{
		Disposables = new CompositeDisposable();
		bEndSeasonTime = false;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateMilestoneStepInfo();
		UpdateMilestoneCurrencyInfo();
		SubscribeEvents();
	}

	private void SubscribeEvents()
	{
		// Subscribe to milestone currency change events
	}

	private void UpdateMilestoneCurrencyInfo()
	{
		// Update currency income display
		if (MilestoneCurrencyIncomeText != null)
			MilestoneCurrencyIncomeText.text = "0";
	}

	private void UpdateMilestoneStepInfo()
	{
		UpdateMilestoneStepProgressSlider();
	}

	private void SetSeasonMainIconImage(string iconKey)
	{
		if (SeasonMainIconImage == null || string.IsNullOrEmpty(iconKey)) return;
		Sprite sprite = Resources.Load<Sprite>(iconKey);
		if (sprite != null) SeasonMainIconImage.sprite = sprite;
	}

	private void SetSeasonRemainTimeText(int remainSec)
	{
		if (SeasonRemainTimeText != null)
			SeasonRemainTimeText.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
	}

	private void SetMilestoneProgressText(int curStep, int maxStep)
	{
		if (MilestoneProgressText != null)
			MilestoneProgressText.text = curStep + "/" + maxStep;
	}

	private void UpdateMilestoneStepProgressSlider()
	{
		if (MilestoneStepProgressSlider != null)
			MilestoneStepProgressSlider.value = 0f;
	}

	private void SetMilestoneCurrencyIconImage(string iconKey)
	{
		if (MilestoneCurrencyIconImage == null || string.IsNullOrEmpty(iconKey)) return;
		Sprite sprite = Resources.Load<Sprite>(iconKey);
		if (sprite != null) MilestoneCurrencyIconImage.sprite = sprite;
	}

	private void SetMilestoneStepRewardItem(SeasonalRewardData rewardTableData)
	{
		if (MilestoneStepRewardItem == null || rewardTableData == null) return;
		// Set reward item display from seasonal reward data
	}

	private void SetMilestoneCurrencyInfoText(BigInteger totalValue, BigInteger goalValue)
	{
		if (MilestoneCurrencyIncomeText != null)
			MilestoneCurrencyIncomeText.text = ProjectUtility.GetThousandCommaText(totalValue) + "/" + ProjectUtility.GetThousandCommaText(goalValue);
	}
}
