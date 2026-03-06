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
		base.Awake();
		disposables = new CompositeDisposable();
		adsDisposables = new CompositeDisposable();
		freeDisposables = new CompositeDisposable();

		if (FreeBtn != null) FreeBtn.onClick.AddListener(OnClickFree);
		if (AdsBtn != null) AdsBtn.onClick.AddListener(OnClickAds);
		if (GemBtn != null) GemBtn.onClick.AddListener(OnClickBuyGem);
		if (KeyBtn != null) KeyBtn.onClick.AddListener(OnClickBuyKey);
		if (TicketBtn != null) TicketBtn.onClick.AddListener(OnClickTicket);
	}

	private void UpdateAdsBtn()
	{
		UpdateAdStat();
	}

	public void Show(int shopBoxIdx)
	{
		ShopIdx = shopBoxIdx;
		BoxTableIdx = shopBoxIdx;

		UpdateAdsBtn();
	}

	private void UpdateAdBoxTime(int remainTime)
	{
		if (AdsRemainTime != null)
			AdsRemainTime.text = ProjectUtility.GetTimeStringFormattingShort(remainTime);
	}

	private void UpdateAdStat()
	{
		if (AdsBtn != null) AdsBtn.interactable = true;
		if (AdsRedDot != null) AdsRedDot.SetActive(false);
		if (FreeRedDot != null) FreeRedDot.SetActive(false);
		if (KeyRedDot != null) KeyRedDot.SetActive(false);
	}

	public void OnClickTicket()
	{
		OpenBox(BoxTableIdx);
	}

	private void OpenBox(int boxIdx, Action CompCb = null)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		CompCb?.Invoke();
	}

	private void OnClickBuyKey()
	{
		OpenBox(BoxTableIdx);
	}

	private void OnClickBuyGem()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		OpenBox(BoxTableIdx);
	}

	private void OnClickFree()
	{
		OpenBox(BoxTableIdx);
	}

	private void OnClickAds()
	{
		// Handle click
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
		if (adsDisposables != null) { adsDisposables.Dispose(); adsDisposables = new CompositeDisposable(); }
		if (freeDisposables != null) { freeDisposables.Dispose(); freeDisposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
		if (adsDisposables != null) { adsDisposables.Dispose(); adsDisposables = null; }
		if (freeDisposables != null) { freeDisposables.Dispose(); freeDisposables = null; }
	}
}
