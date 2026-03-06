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
		base.Awake();
		if (ClaimRewardBtn != null) ClaimRewardBtn.onClick.AddListener(OnClickClaimRewardBtn);
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
		if (TimeDisposable != null) { TimeDisposable.Dispose(); TimeDisposable = null; }
	}

	private void OnClickClaimRewardBtn()
	{
		Hide();
	}
}
