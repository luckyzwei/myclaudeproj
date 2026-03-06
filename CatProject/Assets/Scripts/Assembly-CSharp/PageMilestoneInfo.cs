using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PageMilestoneInfo", false, false)]
public class PageMilestoneInfo : UIBase
{
	[SerializeField]
	private List<Image> GuideImageList;

	[SerializeField]
	private Text GuideText;

	[SerializeField]
	private Text SeasonEndRemainTimeText;

	private DateTime SeasonEndDateTime;

	private bool bEndSeasonTime;

	private void Update()
	{
		if (bEndSeasonTime) return;
		int remainSec = (int)(SeasonEndDateTime - DateTime.UtcNow).TotalSeconds;
		if (remainSec <= 0)
		{
			remainSec = 0;
			bEndSeasonTime = true;
		}
		SetSeasonRemainTimeText(remainSec);
	}

	public void Init(int seasonalThemeIdx)
	{
		bEndSeasonTime = false;
		// Resource loading for guide images - keep minimal
		if (GuideText != null) GuideText.text = "";
	}

	private void SetSeasonRemainTimeText(int remainSec)
	{
		if (SeasonEndRemainTimeText != null)
			SeasonEndRemainTimeText.text = ProjectUtility.GetTimeStringFormattingShort(remainSec);
	}
}
