using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageMiniGameExchangeShop", false, false)]
public class PageMiniGameExchangeShop : UIBase
{
	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Transform ItemExchangeRoot;

	[SerializeField]
	private ItemMiniGameExchangeShop ItemExchangeRefAsset;

	private int EventIdx;

	private CompositeDisposable Disposables;

	public void Init(int eventIdx)
	{
	}

	private void SetHUDTopInfo()
	{
	}

	private void SetExchangeItemList(int eventIdx)
	{
	}

	private void SetRemainTimeText()
	{
	}
}
