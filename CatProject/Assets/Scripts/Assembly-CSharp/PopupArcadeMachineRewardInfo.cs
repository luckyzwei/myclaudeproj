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
		base.Awake();
		ItemArcadeMachineRewardInfoList = new List<ItemArcadeMachineRewardInfo>();
		if (PrevLevelInfoBtn != null) PrevLevelInfoBtn.onClick.AddListener(OnClickedPrevLevelInfoButton);
		if (NextLevelInfoBtn != null) NextLevelInfoBtn.onClick.AddListener(OnClickedNextLevelInfoButton);
	}

	public void Init(int seasonalThemeIdx, int initRewardLevel)
	{
		ShowRewardLevel = initRewardLevel;
		RewardLevelInfo = (0, 0);

		UpdateRewardLevel(ShowRewardLevel);
		Show();
	}

	private void SetOrAddArcadeRouletteProbabilityList(int rouletteLevel)
	{
		if (RewardInfoScrollPanelObj == null || ItemRewardInfoPrefab == null) return;
		// Populate reward probability list for given roulette level
	}

	private void OnClickedPrevLevelInfoButton()
	{
		if (ShowRewardLevel <= RewardLevelInfo.MinRewardLevel) return;
		ShowRewardLevel--;
		UpdateRewardLevel(ShowRewardLevel);
	}

	private void OnClickedNextLevelInfoButton()
	{
		if (ShowRewardLevel >= RewardLevelInfo.MaxRewardLevel) return;
		ShowRewardLevel++;
		UpdateRewardLevel(ShowRewardLevel);
	}

	private void UpdateRewardLevel(int level)
	{
		ShowRewardLevel = level;
		UpdateLevelObjects(level);
		UpdateButtonVisibility();
		SetOrAddArcadeRouletteProbabilityList(level);
		if (RandomSkillBookNoticeObj != null) RandomSkillBookNoticeObj.SetActive(false);
	}

	private void UpdateLevelObjects(int level)
	{
		if (LevelObjList == null) return;
		for (int i = 0; i < LevelObjList.Count; i++)
		{
			if (LevelObjList[i] != null)
				LevelObjList[i].SetActive(i == level);
		}
	}

	private void UpdateButtonVisibility()
	{
		if (PrevLevelInfoBtn != null) PrevLevelInfoBtn.gameObject.SetActive(ShowRewardLevel > RewardLevelInfo.MinRewardLevel);
		if (NextLevelInfoBtn != null) NextLevelInfoBtn.gameObject.SetActive(ShowRewardLevel < RewardLevelInfo.MaxRewardLevel);
	}
}
