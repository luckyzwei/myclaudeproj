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
	}

	private void GetMissionReward(int rewardType, int rewardIdx, BigInteger rewardCnt, bool isDoubleReward)
	{
		BigInteger finalCnt = isDoubleReward ? rewardCnt * 2 : rewardCnt;
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root != null && root.UserData != null)
			root.UserData.SetReward(rewardType, rewardIdx, 0, finalCnt);
	}

	private void GetMoneySafe(BigInteger money)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root != null && root.UserData != null)
			root.UserData.SetReward(0, 0, 0, money);
	}

	private void GotoNavi(int slot)
	{
	}
}
