using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupSeasonalRatio", false, false)]
public class PopupArcadeMachineRewardInfo : UIBase
{
	[SerializeField]
	private Button PrevLevelInfoBtn;

	[SerializeField]
	private Button NextLevelInfoBtn;

	[SerializeField]
	private GameObject RewardInfoScrollPanelObj;

	[SerializeField]
	private List<GameObject> LevelObjList;

	[SerializeField]
	private GameObject ItemRewardInfoPrefab;

	[SerializeField]
	private GameObject RandomSkillBookNoticeObj;

	private int ShowRewardLevel;

	private (int MinRewardLevel, int MaxRewardLevel) RewardLevelInfo;

	private List<ItemArcadeMachineRewardInfo> ItemArcadeMachineRewardInfoList;

	protected override void Awake()
	{
	}

	public void Init(int seasonalThemeIdx, int initRewardLevel)
	{
	}

	private void SetOrAddArcadeRouletteProbabilityList(int rouletteLevel)
	{
	}

	private void OnClickedPrevLevelInfoButton()
	{
	}

	private void OnClickedNextLevelInfoButton()
	{
	}

	private void UpdateRewardLevel(int level)
	{
	}

	private void UpdateLevelObjects(int level)
	{
	}

	private void UpdateButtonVisibility()
	{
	}
}
