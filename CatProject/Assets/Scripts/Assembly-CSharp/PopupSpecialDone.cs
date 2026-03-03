using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupSpecialDone", false, false)]
public class PopupSpecialDone : UIBase
{
	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private ItemArticle RewardArticle;

	[SerializeField]
	private Button ClaimRewardBtn;

	private IDisposable TimeDisposable;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	private void OnClickClaimRewardBtn()
	{
	}
}
