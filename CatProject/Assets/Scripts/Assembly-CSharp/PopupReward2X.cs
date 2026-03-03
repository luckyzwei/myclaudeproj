using System;
using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupReward2X", false, false)]
public class PopupReward2X : UIBase
{
	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Text DescText;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Image RewardImg;

	[SerializeField]
	private Text RewardCnt;

	[SerializeField]
	private Image Icon2;

	[SerializeField]
	private Image RewardImg2;

	[SerializeField]
	private Text NextRewardCnt;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private Button DoubleRewardBtn;

	[SerializeField]
	private Text DoubleRewardBtnText;

	[SerializeField]
	private Text BonusText;

	[SerializeField]
	private RectTransform ArrowTrans;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	private Action<int> RewardCb;

	private Vector3 ArrowOriginPos;

	private TpMaxProp.AdRewardType AdType;

	private bool CustomOneTime;

	protected override void Awake()
	{
	}

	public void Set(TpMaxProp.AdRewardType adType, Config.RewardType rewardType, int rewardIdx, BigInteger rewardValue, bool isCustomOneTime, Action<int> GetCb)
	{
	}

	private void OnClickNormal()
	{
	}

	private void OnClickDouble()
	{
	}
}
