using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemMiniGameRewardProgressSlot : MonoBehaviour
{
	public enum E_RewardProgressSlotType
	{
		Normal = 0,
		Rewardable = 1,
		Rewarded = 2
	}

	[SerializeField]
	private Image BoxIcon;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Button ClaimBtn;

	[Header("State Objects")]
	[SerializeField]
	private GameObject NormalObj;

	[SerializeField]
	private GameObject RewardableObj;

	[SerializeField]
	private GameObject RewardedObj;

	private int EventIdx;

	private int RewardOrder;

	private E_RewardProgressSlotType CurType;

	private Action OnClaimCallback;

	public List<IRewardItemData> RewardItemDataList { get; private set; }

	public void Awake()
	{
		RewardItemDataList = new List<IRewardItemData>();
		if (InfoBtn != null)
			InfoBtn.onClick.AddListener(OnClickInfoBtn);
		if (ClaimBtn != null)
			ClaimBtn.onClick.AddListener(OnClickClaimBtn);
	}

	public void SetData(MiniGameDiggingInfoData rewardTable, E_RewardProgressSlotType type, Action onClaimCallback)
	{
		OnClaimCallback = onClaimCallback;
		CurType = type;
		UpdateUI();
	}

	public void UpdateSlot(E_RewardProgressSlotType type)
	{
		CurType = type;
		UpdateUI();
	}

	private void UpdateUI()
	{
		if (NormalObj != null) NormalObj.SetActive(CurType == E_RewardProgressSlotType.Normal);
		if (RewardableObj != null) RewardableObj.SetActive(CurType == E_RewardProgressSlotType.Rewardable);
		if (RewardedObj != null) RewardedObj.SetActive(CurType == E_RewardProgressSlotType.Rewarded);
		if (ClaimBtn != null) ClaimBtn.gameObject.SetActive(CurType == E_RewardProgressSlotType.Rewardable);
	}

	private void OnClickInfoBtn()
	{
		ShowRewardDetailPopup();
	}

	private void OnClickClaimBtn()
	{
		if (CurType != E_RewardProgressSlotType.Rewardable) return;
		ClaimReward();
	}

	private void ShowRewardDetailPopup()
	{
		// TODO
	}

	private void ClaimReward()
	{
		CurType = E_RewardProgressSlotType.Rewarded;
		UpdateUI();
		OnClaimCallback?.Invoke();
	}
}
