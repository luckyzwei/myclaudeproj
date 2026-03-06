using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupShopInsufficient", false, false)]
public class PopupShopInsufficient : UIBase
{
	[SerializeField]
	private HudTopComponent hudTop;

	[SerializeField]
	private List<IShopContents> contents;

	[Space(5f)]
	[SerializeField]
	private GameObject offerwallObj;

	[SerializeField]
	private Button offerwallBtn;

	[SerializeField]
	private GameObject gemSecondLayoutObj;

	public bool OnOfferwallReddot;

	private int tempRegion;

	protected override void Awake()
	{
		base.Awake();
		if (offerwallBtn != null) offerwallBtn.onClick.AddListener(OnClickMoreGem);
	}

	public override void OnShowBefore()
	{
		if (hudTop != null) hudTop.Binding();
	}

	public void Set(int currencyID, int region, bool packageMode = false, int packageIdx = -1)
	{
		tempRegion = region;
		if (contents != null)
		{
			for (int i = 0; i < contents.Count; i++)
			{
				if (contents[i] != null)
					contents[i].Init();
			}
		}
		SetOfferwall(currencyID);
	}

	private void SetOfferwall(int currencyID)
	{
		if (offerwallObj != null) offerwallObj.SetActive(false);
	}

	private void OnClickMoreGem()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public override void Hide()
	{
		if (hudTop != null) hudTop.Unbinding();
		base.Hide();
	}
}
