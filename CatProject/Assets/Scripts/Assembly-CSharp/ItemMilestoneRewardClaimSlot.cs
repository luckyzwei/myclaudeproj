using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemMilestoneRewardClaimSlot : MonoBehaviour
{
	public enum E_MilestoneRewardSlotState
	{
		None = 0,
		CanClaim = 1,
		Claimed = 2,
		UnAchieve = 3
	}

	[SerializeField]
	private Text MilestoneStepText;

	[SerializeField]
	private Text RewardCountText;

	[SerializeField]
	private Button RewardClaimBtn;

	[SerializeField]
	private GameObject RewardCanClaimObj;

	[SerializeField]
	private GameObject RewardClaimedObj;

	private int RewardIdx;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetRewardClaimSlot(int rewardIdx, string iconKey, int rewardCount, E_MilestoneRewardSlotState state)
	{
	}

	private void SetMilestoneStepText(int stepCount)
	{
	}

	private void SetRewardSlotState(E_MilestoneRewardSlotState state)
	{
	}

	private void OnClickedRewardClaimBtn()
	{
	}
}
