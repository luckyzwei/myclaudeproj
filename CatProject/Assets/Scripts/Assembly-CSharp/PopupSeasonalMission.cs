using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using SeasonalDef;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalMission", false, false)]
public class PopupSeasonalMission : UIBase
{
	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private GameObject ItemListObj;

	[SerializeField]
	private Transform GoodsEffectStartTr;

	[SerializeField]
	private Transform GoodsEffectEndTr;

	[SerializeField]
	private GameObject MissionBuffObj;

	[SerializeField]
	private Text MissionBuffRemainTimeText;

	private List<ItemSeasonalMission> ItemSeasonalMissionSlots;

	protected override void Awake()
	{
		base.Awake();
		ItemSeasonalMissionSlots = new List<ItemSeasonalMission>();
	}

	public void Init()
	{
		if (HUDTopInfo != null) HUDTopInfo.UpdateCurrencyInfos();
		SetMissionBuffInfo();
	}

	private void SetMissionBuffInfo()
	{
		if (MissionBuffObj != null) MissionBuffObj.SetActive(false);
	}

	private void OnClickedMissionRewardClaimBtn(int slotIdx)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.SeasonalSystem == null) return;
		var rewards = root.SeasonalSystem.ReqMissionClaimReward(slotIdx);
		if (rewards != null && rewards.Count > 0)
			ShowRewardEffect(rewards);
	}

	private void OnClickedMissionShortcutBtn(int missionIdx)
	{
		Hide();
	}

	private (E_BuildingType, int) FindShortcutBuildingInfo(SeasonalMissionData missionData)
	{
		return default((E_BuildingType, int));
	}

	private void ShowRewardEffect(Dictionary<int, BigInteger> rewards)
	{
	}
}
