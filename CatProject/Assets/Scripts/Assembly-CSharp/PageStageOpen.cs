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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	private void SetStageOpenTitle(int stageIdx)
	{
	}

	private void SetStageBuildingIcon(int stageIdx)
	{
	}

	private void SetRewardList(StageOpenInfoData openTable)
	{
	}

	private void SetContentsList(int stageIdx, StageOpenInfoData openTable)
	{
	}

	private void OnClickConfirm()
	{
	}

	private void GetReward()
	{
	}
}
