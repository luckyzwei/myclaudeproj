using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		Disposables = new CompositeDisposable();
		if (NaviBtn != null) NaviBtn.onClick.AddListener(OnClickNavi);
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnClickReward);
	}

	public void Set(int slot)
	{
		Slot = slot;
		MissionSlotType = E_MissionSlotType.Normal;
		// Set mission data from MissionSystem for this slot
		if (CompleteObj != null) CompleteObj.SetActive(false);
		if (ProcessObj != null) ProcessObj.SetActive(true);
		if (EnableRewardObj != null) EnableRewardObj.SetActive(false);
	}

	public void SetSubMission(int slotIdx)
	{
		Slot = slotIdx;
		MissionSlotType = E_MissionSlotType.SubMission;
		if (CompleteObj != null) CompleteObj.SetActive(false);
		if (ProcessObj != null) ProcessObj.SetActive(true);
		if (EnableRewardObj != null) EnableRewardObj.SetActive(false);
	}

	public void SetFactoryMission(int slotIdx)
	{
		Slot = slotIdx;
		MissionSlotType = E_MissionSlotType.FactoryMission;
		if (CompleteObj != null) CompleteObj.SetActive(false);
		if (ProcessObj != null) ProcessObj.SetActive(true);
		if (EnableRewardObj != null) EnableRewardObj.SetActive(false);
	}

	private void SetRewardBtnText(bool rewardDouble)
	{
		if (RewardBtnText == null) return;
		RewardBtnText.text = rewardDouble ? "x2" : "";
	}

	private void OnClickNavi()
	{
		NaviCb?.Invoke(Slot);
	}

	private void GetNormalReward()
	{
		// Get reward for normal mission slot
		GetRewardCb?.Invoke(0, 0, BigInteger.Zero, false);
	}

	private void GetThirdSlotReward()
	{
		// Third slot reward (money safe)
		AddSafeCb?.Invoke(BigInteger.Zero);
		MoneySafeRefreshCb?.Invoke();
	}

	private void GetSubMissionReward()
	{
		GetRewardCb?.Invoke(0, 0, BigInteger.Zero, false);
	}

	private void GetFactoryMissionReward()
	{
		GetRewardCb?.Invoke(0, 0, BigInteger.Zero, false);
	}

	private void OnClickReward()
	{
		switch (MissionSlotType)
		{
			case E_MissionSlotType.Normal:
				GetNormalReward();
				break;
			case E_MissionSlotType.SubMission:
				GetSubMissionReward();
				break;
			case E_MissionSlotType.FactoryMission:
				GetFactoryMissionReward();
				break;
		}
	}

	public void Reset()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
		Slot = 0;
		if (CompleteObj != null) CompleteObj.SetActive(false);
		if (ProcessObj != null) ProcessObj.SetActive(false);
		if (EnableRewardObj != null) EnableRewardObj.SetActive(false);
	}
}
