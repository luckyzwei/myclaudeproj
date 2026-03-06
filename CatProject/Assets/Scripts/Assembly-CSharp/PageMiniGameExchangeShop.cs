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
		EventIdx = eventIdx;
		Disposables = new CompositeDisposable();
		SetHUDTopInfo();
		SetExchangeItemList(eventIdx);
		SetRemainTimeText();
	}

	private void SetHUDTopInfo()
	{
		// Update display
	}

	private void SetExchangeItemList(int eventIdx)
	{
		if (ItemExchangeRoot == null || ItemExchangeRefAsset == null) return;
	}

	private void SetRemainTimeText()
	{
		if (RemainTimeText != null) RemainTimeText.text = "";
	}
}
