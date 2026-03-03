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
	}

	public void Set(int _event, int _order)
	{
	}

	public void UpdateAuctionPass(bool ani = false)
	{
	}

	public void UpdateStatus()
	{
	}

	private void OnClickGet(bool isPremium)
	{
	}

	private void GetReward(int rewardType, int rewardIdx, int rewardRegion, int rewardValue, bool isPremium)
	{
	}
}
