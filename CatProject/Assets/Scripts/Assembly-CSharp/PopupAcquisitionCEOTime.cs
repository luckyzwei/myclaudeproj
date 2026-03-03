using System.Collections.Generic;
using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAcquisitionCEOTime", false, false)]
public class PopupAcquisitionCEOTime : UIBase
{
	[SerializeField]
	private List<Image> RewardRevenueIconList;

	[SerializeField]
	private List<Text> RewardRevenuePerHourTextList;

	[SerializeField]
	private Text BizAcquisitionCountText;

	[SerializeField]
	private Text OneBizAcquisitionValueText;

	[SerializeField]
	private Text BizAcquisitionSellTimeText;

	public override void OnShowBefore()
	{
	}

	private void SetRewardRevenuePerHourText(Config.CurrencyID currencyId, BigInteger rewardPerHour)
	{
	}
}
