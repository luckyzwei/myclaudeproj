using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageStageOpen", false, false)]
public class PageStageOpen : UIBase
{
	[SerializeField]
	private Text StageOpenTitleText;

	[SerializeField]
	private Image StageBuildingIcon;

	[SerializeField]
	private Button ConfirmBtn;

	[SerializeField]
	private ScrollRect RewardListScrollRect;

	[SerializeField]
	private ScrollRect ContentsListScrollRect;

	[SerializeField]
	private ItemArticle RewardItemRef;

	[SerializeField]
	private ItemStageOpenContents StageOpenContentsRef;

	private List<ItemArticle> RewardItemList;

	private List<IRewardItemData> RewardItemDataList;

	protected override void Awake()
	{
		base.Awake();
		RewardItemList = new List<ItemArticle>();
		RewardItemDataList = new List<IRewardItemData>();
		if (ConfirmBtn != null) ConfirmBtn.onClick.AddListener(OnClickConfirm);
	}

	public override void OnShowBefore()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	public override void OnHideAfter()
	{
		if (RewardItemList != null) RewardItemList.Clear();
		if (RewardItemDataList != null) RewardItemDataList.Clear();
	}

	private void SetStageOpenTitle(int stageIdx)
	{
		if (StageOpenTitleText != null)
			StageOpenTitleText.text = "";
	}

	private void SetStageBuildingIcon(int stageIdx)
	{
	}

	private void SetRewardList(StageOpenInfoData openTable)
	{
		if (openTable == null || RewardItemRef == null) return;
		if (RewardItemList == null) RewardItemList = new List<ItemArticle>();
	}

	private void SetContentsList(int stageIdx, StageOpenInfoData openTable)
	{
		if (openTable == null || StageOpenContentsRef == null) return;
	}

	private void OnClickConfirm()
	{
		GetReward();
		Hide();
	}

	private void GetReward()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
