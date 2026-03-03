using System;
using System.Numerics;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemMission : MonoBehaviour
{
	public enum E_MissionSlotType
	{
		Normal = 0,
		SubMission = 1,
		FactoryMission = 2
	}

	[SerializeField]
	private Text Desc;

	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardCnt;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private Button NaviBtn;

	[SerializeField]
	private ProgressText ProgressText;

	[SerializeField]
	private Slider Progress;

	[SerializeField]
	private Text RewardBtnText;

	[SerializeField]
	private GameObject CompleteObj;

	[SerializeField]
	private GameObject ProcessObj;

	[SerializeField]
	private GameObject EnableRewardObj;

	private int Slot;

	private E_MissionSlotType MissionSlotType;

	public Action<int> NaviCb;

	public Action<BigInteger> AddSafeCb;

	public Action<int, int, BigInteger, bool> GetRewardCb;

	public Action MoneySafeRefreshCb;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	public void Set(int slot)
	{
	}

	public void SetSubMission(int slotIdx)
	{
	}

	public void SetFactoryMission(int slotIdx)
	{
	}

	private void SetRewardBtnText(bool rewardDouble)
	{
	}

	private void OnClickNavi()
	{
	}

	private void GetNormalReward()
	{
	}

	private void GetThirdSlotReward()
	{
	}

	private void GetSubMissionReward()
	{
	}

	private void GetFactoryMissionReward()
	{
	}

	private void OnClickReward()
	{
	}

	public void Reset()
	{
	}
}
