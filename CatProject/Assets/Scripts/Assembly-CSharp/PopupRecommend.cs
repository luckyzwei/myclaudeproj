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
		base.Awake();
		if (InviteBtn != null) InviteBtn.onClick.AddListener(OnClickInvite);
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
	}

	public override void OnShowBefore()
	{
		Refresh();
	}

	public new void Refresh()
	{
		RefreshFreeGem();
		if (itemList != null)
		{
			for (int i = 0; i < itemList.Count; i++)
			{
				if (itemList[i] != null)
					itemList[i].gameObject.SetActive(true);
			}
		}
	}

	public void RefreshFreeGem()
	{
		if (FreeGemObj != null) FreeGemObj.SetActive(false);
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickInvite()
	{
		reqTime = DateTime.UtcNow;
		// Share invite link
	}
}
