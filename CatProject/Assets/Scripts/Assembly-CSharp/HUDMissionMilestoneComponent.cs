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
		if (MilestonePageBtn != null) MilestonePageBtn.onClick.AddListener(OnClickMilestonePageBtn);
	}

	public void Init()
	{
		CurMissionGroupIdx = 0;
		SetMilestoneData();
	}

	private void SetMilestoneData()
	{
		if (MilestoneRoot != null) MilestoneRoot.SetActive(true);
		if (MilestoneProgressRoot != null) MilestoneProgressRoot.SetActive(true);
		if (MilestoneDoneRoot != null) MilestoneDoneRoot.SetActive(false);

		if (MilestoneStepList != null)
		{
			for (int i = 0; i < MilestoneStepList.Count; i++)
			{
				if (MilestoneStepList[i] != null)
					MilestoneStepList[i].gameObject.SetActive(true);
			}
		}
	}

	private void UpdateNewMilestoneGroup()
	{
		CurMissionGroupIdx++;
		SetMilestoneData();
	}

	private void OnClaimedMilestoneReward(int orderIdx)
	{
		SetMilestoneData();
	}

	private void OnClickMilestonePageBtn()
	{
	}
}
