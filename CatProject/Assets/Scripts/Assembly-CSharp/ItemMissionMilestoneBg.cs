using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMissionMilestoneBg : MonoBehaviour
{
	[SerializeField]
	private Text RegionNameText;

	[SerializeField]
	private Image RegionPreviewImage;

	[SerializeField]
	private Text MilestoneDescText;

	[Header("Not Open")]
	[SerializeField]
	private GameObject NotOpenObj;

	[SerializeField]
	private Text NotOpenDescText;

	[Header("Milestone")]
	[SerializeField]
	private GameObject MilestoneObj;

	[SerializeField]
	private RecycleScrollRect MilestoneScroll;

	[SerializeField]
	private Button ClaimAllBtn;

	[SerializeField]
	private GameObject LastRewardObj;

	[SerializeField]
	private ItemMissionMilestone LastRewardItem;

	[Header("Clear")]
	[SerializeField]
	private GameObject ClearRegionObj;

	[SerializeField]
	private Text ClearRegionDescText;

	[SerializeField]
	private GameObject ClearMissionObj;

	private int RegionIdx;

	private List<int> MilestoneOrderList;

	private void Awake()
	{
		MilestoneOrderList = new List<int>();
		if (ClaimAllBtn != null) ClaimAllBtn.onClick.AddListener(OnClickedClaimAllBtn);
	}

	public void SetRegion(int regionIdx, bool bPlayAnim, Vector2? scrollPosition = null)
	{
		RegionIdx = regionIdx;
		InitMilestoneList(regionIdx, bPlayAnim, scrollPosition);
	}

	public Vector2 GetScrollPosition()
	{
		if (MilestoneScroll != null)
			return MilestoneScroll.normalizedPosition;
		return default(Vector2);
	}

	private void InitMilestoneList(int regionIdx, bool bPlayAnim, Vector2? scrollPosition = null)
	{
	}

	private void OnClickedClaimAllBtn()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.MissionSystem == null) return;
		root.MissionSystem.ReqClaimAllMilestoneReward(RegionIdx);
	}

	private void OnClaimedMilestoneReward(int orderIdx, bool isSuccess)
	{
	}

	private void OnChangeBuildingScroll(Vector2 value)
	{
	}
}
