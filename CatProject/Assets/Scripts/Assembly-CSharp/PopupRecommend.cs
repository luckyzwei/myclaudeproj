using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRecommend", false, false)]
public class PopupRecommend : UIBase
{
	[Header("PopupRecommend")]
	[SerializeField]
	private Button InviteBtn;

	[SerializeField]
	private Text InviteCntTxt;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private GameObject FreeGemObj;

	[Space(10f)]
	[SerializeField]
	private List<ItemRecommendReward> itemList;

	[SerializeField]
	private Transform layoutT;

	[SerializeField]
	private ItemRecommendReward itemPrefab;

	private DateTime reqTime;

	public bool IsPopup { get; set; }

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public new void Refresh()
	{
	}

	public void RefreshFreeGem()
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickInvite()
	{
	}
}
