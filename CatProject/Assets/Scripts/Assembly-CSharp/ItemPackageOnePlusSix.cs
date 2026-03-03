using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemPackageOnePlusSix : MonoBehaviour
{
	[SerializeField]
	private List<ItemArticle> itemList;

	[SerializeField]
	private Button freeBtn;

	[SerializeField]
	private Button iapBtn;

	[SerializeField]
	private Text iapBtnText;

	[SerializeField]
	private Button adsBtn;

	[SerializeField]
	private Animator unlockAni;

	[SerializeField]
	private GameObject RewardedRoot;

	private OnePlusSixInfoData td;

	private bool HasExpReward;

	private bool IsLocked;

	public Action onRewardStart;

	public Action onOpenNextReward;

	private void Awake()
	{
	}

	public void Set(OnePlusSixInfoData _td, int _curStep, bool isInit = true)
	{
	}

	private bool CheckCompanyContract()
	{
		return false;
	}

	private void InitIAP()
	{
	}

	private void OnClickFree()
	{
	}

	private void OnClickIap()
	{
	}

	private void OnClickAds()
	{
	}

	public void ShowUnlockFx()
	{
	}
}
