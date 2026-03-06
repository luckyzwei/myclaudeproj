using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupMilestoneReward", false, false)]
public class PopupMilestoneRewardClaim : UIBase
{
	[SerializeField]
	private ItemMilestoneProgress MilestoneProgress;

	[SerializeField]
	private GameObject NextRewardObj;

	[SerializeField]
	private GameObject RewardClaimBoxListObj;

	[SerializeField]
	private GameObject RewardClaimBoxPrefab;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private GameObject ThemeBgParentsObj;

	private GameObject AddressableLoadBgObj;

	private bool bTryLoadAddressableObj;

	private int SeasonResourceIdx;

	private List<ItemMilestoneRewardClaimBox> RewardClaimBoxList;

	private IDisposable Disposable;

	protected override void Awake()
	{
		base.Awake();
		RewardClaimBoxList = new List<ItemMilestoneRewardClaimBox>();
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
	}

	private void OnDestroy()
	{
		if (Disposable != null) { Disposable.Dispose(); Disposable = null; }
	}

	public override void OnShowBefore()
	{
	}

	public void Init()
	{
		SetRewardSlots();
	}

	private void SetRewardSlots()
	{
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}
}
