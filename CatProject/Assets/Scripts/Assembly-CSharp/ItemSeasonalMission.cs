using System;
using System.Numerics;
using SeasonalDef;
using Treeplla;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemSeasonalMission : MonoBehaviour
{
	[SerializeField]
	private GameObject MissionProgressStateObj;

	[SerializeField]
	private GameObject MissionCompleteStateObj;

	[SerializeField]
	private Image MissionMainIcon;

	[SerializeField]
	private Image MissionSubIcon;

	[SerializeField]
	private Text MissionDescText;

	[SerializeField]
	private Slider MissionProgressSlider;

	[SerializeField]
	private ProgressText MissionProgressText;

	[SerializeField]
	private Image MissionRewardIcon;

	[SerializeField]
	private Text MissionRewardValueText;

	[SerializeField]
	private Button ShortCutButton;

	[SerializeField]
	private Button RewardClaimButton;

	[SerializeField]
	private GameObject BuffRoot;

	[SerializeField]
	private Text BuffPrice;

	public UnityAction<int> OnClickedRewardClaimBtn;

	public UnityAction<int> OnClickedShortCutBtn;

	private WeakReference<SeasonalMissionData> MissionData;

	private int buffAddRewardCoin;

	private IDisposable Disposable;

	public int MissionSlotIdx { get; private set; }

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetMissionInfo(int slotIdx, SeasonalMissionData missionData)
	{
	}

	private void SetDescriptionText(string descStr)
	{
	}

	private void SetMissionIcon(string mainIconKey, string subIconKey)
	{
	}

	private void SetButtonLayout(bool bUseShortcut, bool bReadyToComplete)
	{
	}

	private void SetRewardInfo(E_CurrencyType rewardType, BigInteger rewardCount)
	{
	}

	private void SetMissionProgressInfo(BigInteger curValue, BigInteger needValue, bool bCurrencyMission)
	{
	}

	private void OnClickedShortCutButton()
	{
	}

	private void OnClickedRewardClaimButton()
	{
	}

	private void OnChangeMissionValue(BigInteger value)
	{
	}

	private string MakeMissionDescText(SeasonalMissionData missionData, MissionTypeData missionTypeTable)
	{
		return null;
	}
}
