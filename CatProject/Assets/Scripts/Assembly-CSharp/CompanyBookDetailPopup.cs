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
		if (CloseBtn != null)
			CloseBtn.onClick.AddListener(OnClickClose);
		if (RentalFeeInfoBtn != null)
			RentalFeeInfoBtn.onClick.AddListener(OnClickRentalFeeInfo);
		if (InfoBubbleCloseBtn != null)
			InfoBubbleCloseBtn.onClick.AddListener(OnClickRentalFeeInfoClose);
		if (MaxRewardBtn != null)
			MaxRewardBtn.onClick.AddListener(OnClickMaxReward);
		if (LevelUpCashBtn != null)
			LevelUpCashBtn.onClick.AddListener(OnClickLevelUpCash);
		if (CompanyLevelUpBtn != null)
			CompanyLevelUpBtn.onClick.AddListener(OnClickCompanyLevelUp);

		Disposables = new CompositeDisposable();
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	private void OnDisable()
	{
		IsOpen = false;
		if (InfoBubble != null)
			InfoBubble.SetActive(false);
		if (FocusArrowObj != null)
			FocusArrowObj.SetActive(false);
	}

	public void Show(int company)
	{
		CompanyIdx = company;
		IsOpen = true;
		gameObject.SetActive(true);
		UpdateLevelUpCashInfo();
	}

	public void ShowLevelupFocusArrow(int needLevel)
	{
		GuideLevel = needLevel;
		if (FocusArrowObj != null)
			FocusArrowObj.SetActive(true);
	}

	private void UpdateLevelUpCashInfo()
	{
	}

	private void OnClickMaxReward()
	{
		GetMaxRewardCb?.Invoke();
	}

	private void OnClickClose()
	{
		IsOpen = false;
		gameObject.SetActive(false);
	}

	private void OnClickRentalFeeInfo()
	{
		if (InfoBubble != null)
			InfoBubble.SetActive(true);
	}

	private void OnClickRentalFeeInfoClose()
	{
		if (InfoBubble != null)
			InfoBubble.SetActive(false);
	}

	private void OnClickLevelUpCash()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickCompanyLevelUp()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
