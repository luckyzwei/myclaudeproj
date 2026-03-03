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
	}

	public void Init(int seasonalThemeIdx)
	{
	}

	private void SetSeasonRemainTimeText(int remainSec)
	{
	}
}
