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
		if (MainBtn != null) MainBtn.onClick.AddListener(OnClickMain);
		if (EventBtn != null) EventBtn.onClick.AddListener(OnClickEvent);
		if (BackBtn != null) BackBtn.onClick.AddListener(OnClickBack);
		if (LikeBtn != null) LikeBtn.onClick.AddListener(OnClickHeart);
		if (CommentBtn != null) CommentBtn.onClick.AddListener(OnClickComment);
	}

	public void Init()
	{
		CurCatstagramType = E_CatstagramType.MAIN;
		SelectCatsta = -1;
		SetCommon();
		SetCatstagram();
	}

	private void SetCommon()
	{
		SetCommonCount();
	}

	private void SetCommonCount()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		int mainCount = root.UserData.CatstaData != null ? root.UserData.CatstaData.Count : 0;
		if (ListCountText != null)
			ListCountText.text = mainCount.ToString();
	}

	private void SetCatstagram()
	{
		if (MainRoot != null) MainRoot.SetActive(true);
		if (EventRoot != null) EventRoot.SetActive(false);
		if (DetailRoot != null) DetailRoot.SetActive(false);
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		bool hasCatsta = root.UserData.CatstaData != null && root.UserData.CatstaData.Count > 0;
		if (NoCatstaObj != null) NoCatstaObj.SetActive(!hasCatsta);
	}

	private void SetEventCatstagram()
	{
		if (MainRoot != null) MainRoot.SetActive(false);
		if (EventRoot != null) EventRoot.SetActive(true);
		if (DetailRoot != null) DetailRoot.SetActive(false);
	}

	private bool CanReceiveReward(CatstagramInfoData info)
	{
		if (info == null) return false;
		return info.LikeRewardType > 0 && info.LikeRewardValue > 0;
	}

	private void SetDetailPopup()
	{
		if (DetailRoot != null) DetailRoot.SetActive(true);
		if (MainDetailRoot != null) MainDetailRoot.SetActive(true);
		if (EventDetailRoot != null) EventDetailRoot.SetActive(false);
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.CatstaData == null) return;
		if (SelectCatsta < 0 || SelectCatsta >= root.UserData.CatstaData.Count) return;
		var data = root.UserData.CatstaData[SelectCatsta];
		if (data == null) return;
		SetHeart();
	}

	private void SetEventDetailPopup()
	{
		if (DetailRoot != null) DetailRoot.SetActive(true);
		if (MainDetailRoot != null) MainDetailRoot.SetActive(false);
		if (EventDetailRoot != null) EventDetailRoot.SetActive(true);
		SetEventHeart();
	}

	private void CloseDetailPopup()
	{
		if (DetailRoot != null) DetailRoot.SetActive(false);
		SelectCatsta = -1;
	}

	private void OnClickItem(int order)
	{
		SelectCatsta = order;
		if (CurCatstagramType == E_CatstagramType.MAIN)
			SetDetailPopup();
		else
			SetEventDetailPopup();
	}

	private void OnClickBack()
	{
		if (DetailRoot != null && DetailRoot.activeSelf)
		{
			CloseDetailPopup();
			return;
		}
		GotoMainAction?.Invoke();
	}

	private void OnClickHeart()
	{
		if (CurCatstagramType == E_CatstagramType.MAIN)
		{
			var root = Singleton<GameRoot>.Instance;
			if (root == null || root.UserData == null || root.UserData.CatstaData == null) return;
			if (SelectCatsta < 0 || SelectCatsta >= root.UserData.CatstaData.Count) return;
			var data = root.UserData.CatstaData[SelectCatsta];
			if (data == null || data.Like) return;
			data.Like = true;
			SetHeart();
		}
		else
		{
			var root = Singleton<GameRoot>.Instance;
			if (root == null || root.UserData == null || root.UserData.CatstaEventData == null) return;
			if (SelectCatsta < 0 || SelectCatsta >= root.UserData.CatstaEventData.Count) return;
			var data = root.UserData.CatstaEventData[SelectCatsta];
			if (data == null || data.Like) return;
			data.Like = true;
			SetEventHeart();
		}
	}

	private void SetHeart()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.CatstaData == null) return;
		if (SelectCatsta < 0 || SelectCatsta >= root.UserData.CatstaData.Count) return;
		var data = root.UserData.CatstaData[SelectCatsta];
		bool liked = data != null && data.Like;
		if (HeartOnObj != null) HeartOnObj.SetActive(liked);
		if (HeartFx != null) HeartFx.SetActive(liked);
	}

	private void SetEventHeart()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.CatstaEventData == null) return;
		if (SelectCatsta < 0 || SelectCatsta >= root.UserData.CatstaEventData.Count) return;
		var data = root.UserData.CatstaEventData[SelectCatsta];
		bool liked = data != null && data.Like;
		if (HeartOnObj != null) HeartOnObj.SetActive(liked);
		if (HeartFx != null) HeartFx.SetActive(liked);
	}

	private void OnClickComment()
	{
		// Open comment popup for current catsta
	}

	private void OnClickMain()
	{
		CurCatstagramType = E_CatstagramType.MAIN;
		CloseDetailPopup();
		SetCatstagram();
	}

	private void OnClickEvent()
	{
		CurCatstagramType = E_CatstagramType.EVENT;
		CloseDetailPopup();
		SetEventCatstagram();
	}
}
