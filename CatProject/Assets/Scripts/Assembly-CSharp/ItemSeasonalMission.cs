using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		if (ShortCutButton != null) ShortCutButton.onClick.AddListener(OnClickedShortCutButton);
		if (RewardClaimButton != null) RewardClaimButton.onClick.AddListener(OnClickedRewardClaimButton);
	}

	private void OnDestroy()
	{
		if (Disposable != null) { Disposable.Dispose(); Disposable = null; }
	}

	public void SetMissionInfo(int slotIdx, SeasonalMissionData missionData)
	{
		MissionSlotIdx = slotIdx;
		if (missionData != null)
			MissionData = new WeakReference<SeasonalMissionData>(missionData);
	}

	private void SetDescriptionText(string descStr)
	{
		if (MissionDescText != null) MissionDescText.text = descStr;
	}

	private void SetMissionIcon(string mainIconKey, string subIconKey)
	{
		if (MissionMainIcon != null && !string.IsNullOrEmpty(mainIconKey))
		{
			Sprite sprite = Resources.Load<Sprite>(mainIconKey);
			if (sprite != null) MissionMainIcon.sprite = sprite;
		}
		if (MissionSubIcon != null)
		{
			MissionSubIcon.gameObject.SetActive(!string.IsNullOrEmpty(subIconKey));
			if (!string.IsNullOrEmpty(subIconKey))
			{
				Sprite sprite = Resources.Load<Sprite>(subIconKey);
				if (sprite != null) MissionSubIcon.sprite = sprite;
			}
		}
	}

	private void SetButtonLayout(bool bUseShortcut, bool bReadyToComplete)
	{
		if (ShortCutButton != null) ShortCutButton.gameObject.SetActive(bUseShortcut && !bReadyToComplete);
		if (RewardClaimButton != null) RewardClaimButton.gameObject.SetActive(bReadyToComplete);

		if (MissionProgressStateObj != null) MissionProgressStateObj.SetActive(!bReadyToComplete);
		if (MissionCompleteStateObj != null) MissionCompleteStateObj.SetActive(bReadyToComplete);
	}

	private void SetRewardInfo(E_CurrencyType rewardType, BigInteger rewardCount)
	{
		if (MissionRewardValueText != null)
			MissionRewardValueText.text = ProjectUtility.GetThousandCommaText(rewardCount);

		if (BuffRoot != null) BuffRoot.SetActive(buffAddRewardCoin > 0);
		if (BuffPrice != null && buffAddRewardCoin > 0)
			BuffPrice.text = "+" + buffAddRewardCoin.ToString();
	}

	private void SetMissionProgressInfo(BigInteger curValue, BigInteger needValue, bool bCurrencyMission)
	{
		if (MissionProgressSlider != null && needValue > BigInteger.Zero)
		{
			float progress = (float)((double)curValue / (double)needValue);
			MissionProgressSlider.value = Mathf.Clamp01(progress);
		}
		if (MissionProgressText != null)
			MissionProgressText.SetText(ProjectUtility.GetThousandCommaText(curValue) + "/" + ProjectUtility.GetThousandCommaText(needValue));
	}

	private void OnClickedShortCutButton()
	{
		OnClickedShortCutBtn?.Invoke(MissionSlotIdx);
	}

	private void OnClickedRewardClaimButton()
	{
		OnClickedRewardClaimBtn?.Invoke(MissionSlotIdx);
	}

	private void OnChangeMissionValue(BigInteger value)
	{
		// Update mission progress when value changes
	}

	private string MakeMissionDescText(SeasonalMissionData missionData, MissionTypeData missionTypeTable)
	{
		if (missionData == null) return string.Empty;
		return string.Empty;
	}
}
