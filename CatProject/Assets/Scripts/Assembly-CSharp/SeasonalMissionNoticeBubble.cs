using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		ActiveMissionSlot = -1;
		MissionIdx = -1;
		if (RewardClaimBtn != null)
			RewardClaimBtn.onClick.AddListener(OnClickedMissionRewardClaimBtn);
	}

	private void UpdateBubble()
	{
		if (ActiveMissionSlot < 0)
		{
			gameObject.SetActive(false);
			return;
		}
		gameObject.SetActive(true);
		if (BubbleAnimator != null)
			BubbleAnimator.SetTrigger("Show");
	}

	private void OnMissionReadyToComplete(int slotIdx, SeasonalMissionData missionData)
	{
		if (missionData == null) return;
		ActiveMissionSlot = slotIdx;
		MissionIdx = missionData.MissionIdx;
		if (MissionDescriptionText != null)
			MissionDescriptionText.text = "";
		UpdateBubble();
	}

	private void Reset()
	{
		ActiveMissionSlot = -1;
		MissionIdx = -1;
		gameObject.SetActive(false);
	}

	private void OnClickedMissionRewardClaimBtn()
	{
		if (ActiveMissionSlot < 0) return;
		Reset();
	}

	private void ShowRewardEffect(Dictionary<int, BigInteger> rewards)
	{
		if (rewards == null || GoodsEffectStartTr == null || GoodsEffectEndTr == null) return;
	}
}
