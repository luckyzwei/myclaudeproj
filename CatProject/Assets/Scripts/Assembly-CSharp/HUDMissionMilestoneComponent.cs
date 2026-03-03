using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDMissionMilestoneComponent : MonoBehaviour
{
	[SerializeField]
	private GameObject MilestoneRoot;

	[SerializeField]
	private GameObject MilestoneProgressRoot;

	[SerializeField]
	private GameObject MilestoneDoneRoot;

	[SerializeField]
	private Button MilestonePageBtn;

	[SerializeField]
	private List<HUDMissionMilestoneStep> MilestoneStepList;

	private int CurMissionGroupIdx;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void SetMilestoneData()
	{
	}

	private void UpdateNewMilestoneGroup()
	{
	}

	private void OnClaimedMilestoneReward(int orderIdx)
	{
	}

	private void OnClickMilestonePageBtn()
	{
	}
}
