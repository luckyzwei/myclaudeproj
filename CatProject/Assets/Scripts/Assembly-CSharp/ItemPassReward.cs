using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		if (GetBtn != null) GetBtn.onClick.AddListener(OnClickGetBtn);
	}

	public void SetPassReward(int order, bool isPremium)
	{
		PassType = E_PassType.LevelPass;
		Order = order;
		bPremium = isPremium;
		InitGetObj();
	}

	public void UpdateStatus()
	{
		bool isGet = false; // Check from user data
		UpdateGetState(isGet, false);
		UpdateLockState(false);
	}

	public void SetAuctionPassReward(int _event, int _order, bool isPremium)
	{
		PassType = E_PassType.AuctionPass;
		EventIdx = _event;
		Order = _order;
		bPremium = isPremium;
		InitGetObj();
	}

	public void UpdateAuctionStatus()
	{
		bool isGet = false;
		UpdateGetState(isGet, false);
		UpdateLockState(false);
	}

	public void SetBizAcqPassReward(int passIdx, bool isPremium, Action<int, bool> onClickGetBtnAction)
	{
		PassType = E_PassType.BizAcqPass;
		Order = passIdx;
		bPremium = isPremium;
		OnClickGetBtnAction = onClickGetBtnAction;
		InitGetObj();
	}

	public void UpdateBizAcqStatus(bool bPlayAni)
	{
		bool isGet = false;
		UpdateGetState(isGet, bPlayAni);
		UpdateLockState(bPlayAni);
	}

	public void SetSeasonalPassReward(int seasonInfoIdx, int rewardGroupIdx, int rewardTableIdx, bool isPremium, Action<int, bool> onClickGetBtnAction)
	{
		PassType = E_PassType.SeasonalPass;
		EventIdx = seasonInfoIdx;
		GroupIdx = rewardGroupIdx;
		Order = rewardTableIdx;
		bPremium = isPremium;
		OnClickGetBtnAction = onClickGetBtnAction;
		InitGetObj();
	}

	public void UpdateSeasonalStatus(bool bPlayAni)
	{
		bool isGet = false;
		UpdateGetState(isGet, bPlayAni);
		UpdateLockState(bPlayAni);
	}

	public void SetSpecialReward(bool isSpecial)
	{
		if (BgNormalObj != null) BgNormalObj.SetActive(!isSpecial);
		if (BgSpecialObj != null) BgSpecialObj.SetActive(isSpecial);
	}

	private void InitGetObj()
	{
		if (GetObj != null) GetObj.SetActive(false);
		if (EnableGetObj != null) EnableGetObj.SetActive(false);
		if (LockObj != null) LockObj.SetActive(false);
		if (AdsObj != null) AdsObj.SetActive(false);
		IsClaimable = false;
		IsAdsReward = false;
	}

	private void UpdateGetState(bool isGet, bool bPlayAni)
	{
		if (GetObj != null) GetObj.SetActive(isGet);
		if (bPlayAni && isGet && GetAnimator != null)
			GetAnimator.SetTrigger("Play");

		bool canClaim = !isGet && IsPremiumActive();
		IsClaimable = canClaim;
		if (EnableGetObj != null) EnableGetObj.SetActive(canClaim);
	}

	private void UpdateLockState(bool bPlayAni)
	{
		bool isLocked = bPremium && !bActivePremium;
		if (LockObj != null) LockObj.SetActive(isLocked);
		if (bPlayAni && !isLocked && LockAnimator != null)
			LockAnimator.SetTrigger("Unlock");
	}

	private bool IsPremiumActive()
	{
		if (!bPremium) return true;
		return bActivePremium;
	}

	private void OnClickGetBtn()
	{
		if (OnClickGetBtnAction != null)
		{
			OnClickGetBtnAction.Invoke(Order, bPremium);
			return;
		}
	}
}
