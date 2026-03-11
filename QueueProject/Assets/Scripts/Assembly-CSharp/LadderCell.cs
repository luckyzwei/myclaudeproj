using Balancy.Models;
using Balancy.Models.SmartObjects;
using UnityEngine;
using UnityEngine.UI;

public class LadderCell : MonoBehaviour
{
	public enum State
	{
		IDLE = 0,
		COLLECTABLE = 1,
		COLLECTED = 2
	}

	private const string ANIM_ANIM_SAGAMAPNODE_LEFT = "Anim-SagaMapNode-Left";

	private const string ANIM_ANIM_SAGAMAPNODE_RIGHT = "Anim-SagaMapNode-Right";

	[SerializeField]
	private RewardWidget[] m_rewardWidgets;

	[SerializeField]
	private Text m_numberText;

	[SerializeField]
	private string m_rewardPrefix;

	[SerializeField]
	private AnimatorHelper m_animator;

	[SerializeField]
	private Image m_progressBar;

	[Header("Mirror")]
	[SerializeField]
	private GameObject[] m_mirrorObjects;

	[SerializeField]
	private GameObject[] m_claimedOverlays;

	[Header("Tick")]
	[SerializeField]
	private Transform m_tickParent;

	[SerializeField]
	private GameObject m_tickGameObject;

	private LadderCell m_prevCell;

	private bool m_collectable;

	private bool m_collected;

	private Reward m_reward;

	private int m_rewardIndex;

	private bool m_isShowingTick;

	private const string AVAILABLE_ANIM = "Available";

	private const string NOT_AVAILABLE_ANIM = "NotAvailable";

	private const string COLLECTED_ANIM = "Collected";

	private const string ANIM_COLLECTED_NOANIM = "Collected-NoAnim";

	public int Number => 0;

	public void Config(State state, float progress, PrizeLadderRewardData prizeLadderRewardData, int index, bool isLeftAligned, LadderCell prevCell)
	{
	}

	public void SetProgress(float progress, bool playAnimation = true)
	{
	}

	public void SetNextCellProgress(float nextCellProgress)
	{
	}

	public void PlayAvailableAnimation()
	{
	}

	public void ShowRewardHasBeenTaken()
	{
	}

	public void OnButtonPressed()
	{
	}

	public void RewardClaimed(bool giveRewards)
	{
	}

	private void GiveRewards()
	{
	}
}
