using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupBoxOpen", false, false)]
public class PopupBoxOpen : UIBase
{
	[Header("common")]
	[SerializeField]
	private Text Title;

	[SerializeField]
	private Text BoxName;

	[SerializeField]
	private Image BoxIcon;

	[SerializeField]
	private List<ItemArticle> rewardList;

	[SerializeField]
	private Text AdsRemainTime;

	[Header("buttons")]
	[SerializeField]
	private Button FreeBtn;

	[SerializeField]
	private GameObject FreeRedDot;

	[SerializeField]
	private Text FreeTimeText;

	[SerializeField]
	private Button AdsBtn;

	[SerializeField]
	private Image AdsBtnIcon;

	[SerializeField]
	private GameObject AdsRedDot;

	[SerializeField]
	private Text AdsTimeText;

	[SerializeField]
	private Button GemBtn;

	[SerializeField]
	private Text GemBtnText;

	[SerializeField]
	private Button KeyBtn;

	[SerializeField]
	private Text KeyBtnText;

	[SerializeField]
	private Text AdsCountText;

	[SerializeField]
	private GameObject KeyRedDot;

	[SerializeField]
	private Image KeyIcon;

	[SerializeField]
	private GameObject TicketObj;

	[SerializeField]
	private Button TicketBtn;

	[SerializeField]
	private Text CurTicketCountText;

	private int ShopIdx;

	private int BoxTableIdx;

	private CompositeDisposable adsDisposables;

	private CompositeDisposable freeDisposables;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
	}

	private void UpdateAdsBtn()
	{
	}

	public void Show(int shopBoxIdx)
	{
	}

	private void UpdateAdBoxTime(int remainTime)
	{
	}

	private void UpdateAdStat()
	{
	}

	public void OnClickTicket()
	{
	}

	private void OpenBox(int boxIdx, Action CompCb = null)
	{
	}

	private void OnClickBuyKey()
	{
	}

	private void OnClickBuyGem()
	{
	}

	private void OnClickFree()
	{
	}

	private void OnClickAds()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
