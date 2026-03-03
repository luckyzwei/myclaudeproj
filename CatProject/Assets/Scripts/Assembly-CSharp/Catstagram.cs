using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class Catstagram : MonoBehaviour
{
	private enum E_CatstagramType
	{
		MAIN = 0,
		EVENT = 1
	}

	[SerializeField]
	private GameObject DetailRoot;

	[SerializeField]
	private GameObject MainRoot;

	[SerializeField]
	private GameObject EventRoot;

	[SerializeField]
	private GameObject MainDetailRoot;

	[SerializeField]
	private GameObject EventDetailRoot;

	[SerializeField]
	private Button MainBtn;

	[SerializeField]
	private Button EventBtn;

	[Header("Common")]
	[SerializeField]
	private Image CeoImg;

	[SerializeField]
	private Text CeoName;

	[SerializeField]
	private Text ListCountText;

	[SerializeField]
	private Text PointText;

	[SerializeField]
	private Button BackBtn;

	[Header("List")]
	[SerializeField]
	private RecycleScrollRect ListScroll;

	[SerializeField]
	private GameObject ListItem;

	[SerializeField]
	private GameObject NoCatstaObj;

	[Header("Detail")]
	[SerializeField]
	private Image CatstaBg;

	[SerializeField]
	private Image CatstaTargetImg;

	[SerializeField]
	private Image CatstaCeoImg;

	[SerializeField]
	private Button LikeBtn;

	[SerializeField]
	private Button CommentBtn;

	[SerializeField]
	private GameObject HeartRoot;

	[SerializeField]
	private GameObject HeartOnObj;

	[SerializeField]
	private GameObject HeartFx;

	[SerializeField]
	private Text TagText;

	[SerializeField]
	private Text LikeText;

	[Header("Event")]
	[SerializeField]
	private ScrollRect EventListScroll;

	[SerializeField]
	private GameObject EventListItem;

	[Space(5f)]
	[SerializeField]
	private GameObject EventConditionRoot;

	[SerializeField]
	private Image EventDetailImg;

	[SerializeField]
	private Slider EventConditionProgress;

	[SerializeField]
	private Text EventConditionDesc;

	[SerializeField]
	private Text EventConditionCount;

	private E_CatstagramType CurCatstagramType;

	private int SelectCatsta;

	private const int DEFAULTEVENTLIKE = 10;

	public Action GotoMainAction;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void SetCommon()
	{
	}

	private void SetCommonCount()
	{
	}

	private void SetCatstagram()
	{
	}

	private void SetEventCatstagram()
	{
	}

	private bool CanReceiveReward(CatstagramInfoData info)
	{
		return false;
	}

	private void SetDetailPopup()
	{
	}

	private void SetEventDetailPopup()
	{
	}

	private void CloseDetailPopup()
	{
	}

	private void OnClickItem(int order)
	{
	}

	private void OnClickBack()
	{
	}

	private void OnClickHeart()
	{
	}

	private void SetHeart()
	{
	}

	private void SetEventHeart()
	{
	}

	private void OnClickComment()
	{
	}

	private void OnClickMain()
	{
	}

	private void OnClickEvent()
	{
	}
}
