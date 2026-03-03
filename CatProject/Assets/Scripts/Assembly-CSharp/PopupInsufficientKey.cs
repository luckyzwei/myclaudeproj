using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupInsufficientKey", false, false)]
public class PopupInsufficientKey : UIBase
{
	[SerializeField]
	private ItemArticle keyArticle;

	[SerializeField]
	private Text needGemText;

	[SerializeField]
	private Button buyBtn;

	private int NeedItem;

	private int NeedItemCount;

	private int NeedCost;

	private Action LeakAction;

	protected override void Awake()
	{
	}

	public void Set(int itemIdx, int needCount, Action leakAction)
	{
	}

	private void OnClickBuy()
	{
	}
}
