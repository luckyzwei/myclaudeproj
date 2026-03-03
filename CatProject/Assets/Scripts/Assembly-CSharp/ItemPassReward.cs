using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class ItemPassReward : MonoBehaviour
{
	private enum E_PassType
	{
		None = 0,
		LevelPass = 1,
		AuctionPass = 2,
		BizAcqPass = 3,
		SeasonalPass = 4
	}

	[Header("ItemArticle Or Icon And Count")]
	[SerializeField]
	private ItemArticle RewardArticle;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Count;

	[SerializeField]
	private GameObject GetObj;

	[SerializeField]
	private Animator GetAnimator;

	[SerializeField]
	private GameObject EnableGetObj;

	[SerializeField]
	private GameObject AdsObj;

	[SerializeField]
	private Button GetBtn;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private Animator LockAnimator;

	[Header("ETC")]
	[SerializeField]
	private GameObject BgNormalObj;

	[SerializeField]
	private GameObject BgSpecialObj;

	private E_PassType PassType;

	private int EventIdx;

	private int GroupIdx;

	private int Order;

	private BigInteger NeedCondition;

	private bool bPremium;

	private bool bActivePremium;

	private Action<int, bool> OnClickGetBtnAction;

	public bool IsAdsReward { get; private set; }

	public bool IsClaimable { get; private set; }

	private void Awake()
	{
	}

	public void SetPassReward(int order, bool isPremium)
	{
	}

	public void UpdateStatus()
	{
	}

	public void SetAuctionPassReward(int _event, int _order, bool isPremium)
	{
	}

	public void UpdateAuctionStatus()
	{
	}

	public void SetBizAcqPassReward(int passIdx, bool isPremium, Action<int, bool> onClickGetBtnAction)
	{
	}

	public void UpdateBizAcqStatus(bool bPlayAni)
	{
	}

	public void SetSeasonalPassReward(int seasonInfoIdx, int rewardGroupIdx, int rewardTableIdx, bool isPremium, Action<int, bool> onClickGetBtnAction)
	{
	}

	public void UpdateSeasonalStatus(bool bPlayAni)
	{
	}

	public void SetSpecialReward(bool isSpecial)
	{
	}

	private void InitGetObj()
	{
	}

	private void UpdateGetState(bool isGet, bool bPlayAni)
	{
	}

	private void UpdateLockState(bool bPlayAni)
	{
	}

	private bool IsPremiumActive()
	{
		return false;
	}

	private void OnClickGetBtn()
	{
	}
}
