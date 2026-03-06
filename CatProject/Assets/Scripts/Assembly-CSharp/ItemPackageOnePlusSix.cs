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
		if (freeBtn != null) freeBtn.onClick.AddListener(OnClickFree);
		if (iapBtn != null) iapBtn.onClick.AddListener(OnClickIap);
		if (adsBtn != null) adsBtn.onClick.AddListener(OnClickAds);
	}

	public void Set(OnePlusSixInfoData _td, int _curStep, bool isInit = true)
	{
		td = _td;
		if (td == null) return;
		InitIAP();
	}

	private bool CheckCompanyContract()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return false;
		return false;
	}

	private void InitIAP()
	{
		if (iapBtn != null) iapBtn.gameObject.SetActive(false);
		if (iapBtnText != null) iapBtnText.text = "";
	}

	private void OnClickFree()
	{
		onRewardStart?.Invoke();
	}

	private void OnClickIap()
	{
		onRewardStart?.Invoke();
	}

	private void OnClickAds()
	{
		onRewardStart?.Invoke();
	}

	public void ShowUnlockFx()
	{
		if (unlockAni != null) unlockAni.SetTrigger("Play");
	}
}
