using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemPlayerLvPass : MonoBehaviour
{
	[SerializeField]
	private ItemPassReward NormalObj;

	[SerializeField]
	private ItemPassReward PremiumObj;

	[SerializeField]
	private Text NeedLevel;

	[SerializeField]
	private GameObject PremiumLock;

	[SerializeField]
	private Animator PremiumLockAni;

	[SerializeField]
	private Button GetNormalBtn;

	[SerializeField]
	private Button GetPremiumBtn;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	private int Group;

	public Action OnClickPurchaseBtn;

	public int Order { get; private set; }

	private void Awake()
	{
	}

	public void Set(int order)
	{
	}

	public void UpdateGemPass(bool ani = false)
	{
	}

	public void UpdateStatus()
	{
	}

	public void UpdateCondition()
	{
	}

	public bool IsClaimable(bool isPremium, out bool isAdsReward)
	{
		isAdsReward = default(bool);
		return false;
	}

	private void OnClickGet(bool isNormal)
	{
	}

	private void GetNormal(int gemValue)
	{
	}

	private void GetADNormal(int gemValue)
	{
	}

	private void GetPremium(int gemValue)
	{
	}
}
