using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemPiggyLvReward : MonoBehaviour
{
	[SerializeField]
	private Text NeedLevel;

	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardName;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private GameObject NeedLevelRoot;

	[SerializeField]
	private GameObject ReceiveRoot;

	[SerializeField]
	private Slider LevelProgress;

	[SerializeField]
	private Text LevelProgressText;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private GameObject Reddot;

	public Action RewardCb;

	private int Level;

	private void Awake()
	{
	}

	public void Set(int level)
	{
	}

	public void UpdateStatus()
	{
	}

	private void OnClickGetReward()
	{
	}

	private void OnClickRewardInfo()
	{
	}
}
