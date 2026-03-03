using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class CompanyBookDetailPopup : MonoBehaviour
{
	[Serializable]
	private class ConditionObj
	{
		public GameObject Root;

		public GameObject Check;

		public Text Desc;
	}

	[SerializeField]
	private Button CloseBtn;

	[SerializeField]
	private ItemCompany ItemCompany;

	[SerializeField]
	private GameObject UnlockRoot;

	[SerializeField]
	private List<ConditionObj> ConditionRoot;

	[SerializeField]
	private Text TagText;

	[SerializeField]
	private Text RentalFee;

	[SerializeField]
	private Button RentalFeeInfoBtn;

	[SerializeField]
	private Slider ExpProgress;

	[SerializeField]
	private Text ExpProgressPer;

	[SerializeField]
	private GameObject MaxLevelObj;

	[SerializeField]
	private Button MaxRewardBtn;

	[SerializeField]
	private Image MaxRewardIcon;

	[SerializeField]
	private Text MaxRewardCount;

	[SerializeField]
	private GameObject InfoBubble;

	[SerializeField]
	private Button InfoBubbleCloseBtn;

	[SerializeField]
	private GameObject CompanyLevelUpObj;

	[SerializeField]
	private Button LevelUpCashBtn;

	[SerializeField]
	private Text LevelUpNeedCashText;

	[SerializeField]
	private Button CompanyLevelUpBtn;

	[SerializeField]
	private GameObject FocusArrowObj;

	private int CompanyIdx;

	private bool IsOpen;

	private int CompanyLevel;

	private int GuideLevel;

	public Action GetMaxRewardCb;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void Show(int company)
	{
	}

	public void ShowLevelupFocusArrow(int needLevel)
	{
	}

	private void UpdateLevelUpCashInfo()
	{
	}

	private void OnClickMaxReward()
	{
	}

	private void OnClickClose()
	{
	}

	private void OnClickRentalFeeInfo()
	{
	}

	private void OnClickRentalFeeInfoClose()
	{
	}

	private void OnClickLevelUpCash()
	{
	}

	private void OnClickCompanyLevelUp()
	{
	}
}
