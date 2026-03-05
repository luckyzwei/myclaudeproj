using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;

public class HudMissionItem : MonoBehaviour
{
	[SerializeField]
	private GameObject ClearedMissionRoot;

	[SerializeField]
	private Transform ClearedMissionRewardTrans;

	[SerializeField]
	private ItemMission ClearedMissionItem;

	private HUDTotal HUDTotal;

	private bool CheatToggle;

	private void Awake()
	{
		if (ClearedMissionRoot != null)
			ClearedMissionRoot.SetActive(false);
	}

	public void Init(HUDTotal hudTotal)
	{
		HUDTotal = hudTotal;
		CheatToggle = false;
		SetClearedMissionData();
	}

	public void SetCheatToggle()
	{
		CheatToggle = !CheatToggle;
	}

	private void OnEndTutorialEvent()
	{
		SetClearedMissionData();
	}

	private void SetClearedMissionData()
	{
		if (ClearedMissionRoot != null)
			ClearedMissionRoot.SetActive(false);
		// Populate cleared mission data from mission system
	}

	private void GetMissionReward(int rewardType, int rewardIdx, BigInteger rewardCnt, bool isDoubleReward)
	{
		// Claim mission reward and show effect
	}

	private void GetMoneySafe(BigInteger money)
	{
		// Collect money from safe
	}

	private void GotoNavi(int slot)
	{
		// Navigate to mission target
	}
}
