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
		Disposables = new CompositeDisposable();
		if (RewardClaimBtn != null) RewardClaimBtn.onClick.AddListener(OnClickedRewardClaimBtn);
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	public void SetRewardClaimSlot(int rewardIdx, string iconKey, int rewardCount, E_MilestoneRewardSlotState state)
	{
		RewardIdx = rewardIdx;
		if (RewardCountText != null) RewardCountText.text = rewardCount.ToString();
		SetRewardSlotState(state);
	}

	private void SetMilestoneStepText(int stepCount)
	{
		if (MilestoneStepText != null) MilestoneStepText.text = stepCount.ToString();
	}

	private void SetRewardSlotState(E_MilestoneRewardSlotState state)
	{
		if (RewardCanClaimObj != null) RewardCanClaimObj.SetActive(state == E_MilestoneRewardSlotState.CanClaim);
		if (RewardClaimedObj != null) RewardClaimedObj.SetActive(state == E_MilestoneRewardSlotState.Claimed);
	}

	private void OnClickedRewardClaimBtn()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;
		root.SeasonalSystem.ReqMilestoneRewardClaim(RewardIdx, false);
	}
}
