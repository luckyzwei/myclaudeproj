using System;
using Balancy.Models.SmartObjects;
using KWLocalisation.Localisation;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DailyRewardCell : MonoBehaviour
{
	protected const string DAY_X_KEY = "DailyReward.DayX";

	private const string ANIM_HIGHLIGHTED = "Highlighted";

	private const string ANIM_LOCKED = "Locked";

	private const string ANIM_REWARD = "Reward";

	private const string ANIM_CLAIMED = "Claimed";

	private const string ANIM_CLAIMEDHIGHLIGHTED = "ClaimedHighlighted";

	private const string ANIM_ANIM_DAILYREWARD_REVEALED = "Anim-DailyReward-Revealed";

	[SerializeField]
	private TextWrapper m_dayText;

	[SerializeField]
	private Button m_button;

	[Header("Hidden/Revealed")]
	[SerializeField]
	private GameObject m_hiddenPanel;

	[SerializeField]
	protected GameObject m_visibleRewardPanel;

	[Header("Reward")]
	[SerializeField]
	private RewardWidget m_rewardWidget;

	[SerializeField]
	private float m_rewardCallbackDelay;

	private AnimatorHelper m_animatorHelper;

	private int m_dayIndex;

	private bool m_isClaimed;

	private Action m_onRewarded;

	private void Awake()
	{
	}

	public void TryReward(Action onRevealed)
	{
	}

	public virtual void Configure(int dayIndex, Reward dailyReward, UnityAction buttonPressedAction = null)
	{
	}

	private void SetHiddenStatus()
	{
	}

	public bool HasBeenClaimed()
	{
		return false;
	}

	public void SetClaimed()
	{
	}

	protected virtual bool IsHidden()
	{
		return false;
	}

	private bool IsActiveDay()
	{
		return false;
	}

	public void Reward()
	{
	}

	private void SendRewardVisualsFinsihed()
	{
	}

	private void Reveal()
	{
	}
}
