using Balancy.Models.SmartObjects;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DailyRewardCellLastDay : DailyRewardCell
{
	[SerializeField]
	private Image m_specialIcon;

	public override void Configure(int dayIndex, Reward dailyReward, UnityAction buttonPressedAction)
	{
	}

	protected override bool IsHidden()
	{
		return false;
	}
}
