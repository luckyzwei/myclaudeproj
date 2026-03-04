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
	}

	public void Init()
	{
	}

	private void SetMissionBuffInfo()
	{
	}

	private void OnClickedMissionRewardClaimBtn(int slotIdx)
	{
	}

	private void OnClickedMissionShortcutBtn(int missionIdx)
	{
	}

	private (E_BuildingType, int) FindShortcutBuildingInfo(SeasonalMissionData missionData)
	{
		return default((E_BuildingType, int));
	}

	private void ShowRewardEffect(Dictionary<int, BigInteger> rewards)
	{
	}
}
