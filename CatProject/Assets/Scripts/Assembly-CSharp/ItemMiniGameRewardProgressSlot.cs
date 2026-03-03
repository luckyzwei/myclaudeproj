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
	}

	public void SetData(MiniGameDiggingInfoData rewardTable, E_RewardProgressSlotType type, Action onClaimCallback)
	{
	}

	public void UpdateSlot(E_RewardProgressSlotType type)
	{
	}

	private void UpdateUI()
	{
	}

	private void OnClickInfoBtn()
	{
	}

	private void OnClickClaimBtn()
	{
	}

	private void ShowRewardDetailPopup()
	{
	}

	private void ClaimReward()
	{
	}
}
