using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class SeasonalMissionNoticeBubble : MonoBehaviour
{
	[SerializeField]
	private Text MissionDescriptionText;

	[SerializeField]
	private Button RewardClaimBtn;

	[SerializeField]
	private Animator BubbleAnimator;

	[SerializeField]
	private Transform GoodsEffectStartTr;

	[SerializeField]
	private Transform GoodsEffectEndTr;

	private int ActiveMissionSlot;

	private int MissionIdx;

	private void Awake()
	{
	}

	private void UpdateBubble()
	{
	}

	private void OnMissionReadyToComplete(int slotIdx, SeasonalMissionData missionData)
	{
	}

	private void Reset()
	{
	}

	private void OnClickedMissionRewardClaimBtn()
	{
	}

	private void ShowRewardEffect(Dictionary<int, BigInteger> rewards)
	{
	}
}
