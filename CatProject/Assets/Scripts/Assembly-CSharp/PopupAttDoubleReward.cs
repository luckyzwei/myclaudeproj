using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAttDoubleReward", false, false)]
public class PopupAttDoubleReward : UIBase
{
	[SerializeField]
	private Text NormalReward;

	[SerializeField]
	private Button NormalRewardBtn;

	[SerializeField]
	private Text DoubleReward;

	[SerializeField]
	private Button DoubleRewardBtn;

	private Action<int> GetAtt;

	protected override void Awake()
	{
	}

	public void Show(int rewardCount, Action<int> attAction)
	{
	}

	private void OnClickReward()
	{
	}

	private void OnClickDoubleReward()
	{
	}
}
