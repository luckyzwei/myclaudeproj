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
	}

	public override void OnShowBefore()
	{
	}

	public void Set(int currencyID, int region, bool packageMode = false, int packageIdx = -1)
	{
	}

	private void SetOfferwall(int currencyID)
	{
	}

	private void OnClickMoreGem()
	{
	}

	public override void Hide()
	{
	}
}
