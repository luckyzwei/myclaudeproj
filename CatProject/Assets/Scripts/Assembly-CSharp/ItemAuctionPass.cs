using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemAuctionPass : MonoBehaviour
{
	[SerializeField]
	private ItemPassReward NormalObj;

	[SerializeField]
	private ItemPassReward PremiumObj;

	[SerializeField]
	private Text NeedScore;

	[SerializeField]
	private GameObject PremiumLock;

	[SerializeField]
	private Animator PremiumLockAni;

	[SerializeField]
	private Button GetNormalBtn;

	[SerializeField]
	private Button GetPremiumBtn;

	private int Event;

	public Action OnClickPurchaseBtn;

	public int Order { get; private set; }

	public int WinPoint { get; private set; }

	private void Awake()
	{
		if (GetNormalBtn != null) GetNormalBtn.onClick.AddListener(() => OnClickGet(false));
		if (GetPremiumBtn != null) GetPremiumBtn.onClick.AddListener(() => OnClickGet(true));
	}

	public void Set(int _event, int _order)
	{
		Event = _event;
		Order = _order;
		UpdateStatus();
	}

	public void UpdateAuctionPass(bool ani = false)
	{
		UpdateStatus();
	}

	public void UpdateStatus()
	{
	}

	private void OnClickGet(bool isPremium)
	{
		if (isPremium && PremiumLock != null && PremiumLock.activeSelf)
		{
			OnClickPurchaseBtn?.Invoke();
			return;
		}
	}

	private void GetReward(int rewardType, int rewardIdx, int rewardRegion, int rewardValue, bool isPremium)
	{
	}
}
