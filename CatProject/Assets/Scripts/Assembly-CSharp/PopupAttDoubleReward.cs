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
		base.Awake();
		if (NormalRewardBtn != null) NormalRewardBtn.onClick.AddListener(OnClickReward);
		if (DoubleRewardBtn != null) DoubleRewardBtn.onClick.AddListener(OnClickDoubleReward);
	}

	public void Show(int rewardCount, Action<int> attAction)
	{
		GetAtt = attAction;
		if (NormalReward != null) NormalReward.text = rewardCount.ToString();
		if (DoubleReward != null) DoubleReward.text = (rewardCount * 2).ToString();
	}

	private void OnClickReward()
	{
		GetAtt?.Invoke(1);
		Hide();
	}

	private void OnClickDoubleReward()
	{
		GetAtt?.Invoke(2);
		Hide();
	}
}
