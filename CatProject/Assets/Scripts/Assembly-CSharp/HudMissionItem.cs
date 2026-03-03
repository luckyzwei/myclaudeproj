using System.Numerics;
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
	}

	public void Init(HUDTotal hudTotal)
	{
	}

	public void SetCheatToggle()
	{
	}

	private void OnEndTutorialEvent()
	{
	}

	private void SetClearedMissionData()
	{
	}

	private void GetMissionReward(int rewardType, int rewardIdx, BigInteger rewardCnt, bool isDoubleReward)
	{
	}

	private void GetMoneySafe(BigInteger money)
	{
	}

	private void GotoNavi(int slot)
	{
	}
}
