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
		if (GetNormalBtn != null)
			GetNormalBtn.onClick.AddListener(() => OnClickGet(true));
		if (GetPremiumBtn != null)
			GetPremiumBtn.onClick.AddListener(() => OnClickGet(false));
	}

	public void Set(int order)
	{
		Order = order;
		UpdateStatus();
	}

	public void UpdateGemPass(bool ani = false)
	{
		if (PremiumLock != null) PremiumLock.SetActive(false);
		if (ani && PremiumLockAni != null)
			PremiumLockAni.Play("Unlock");
	}

	public void UpdateStatus()
	{
		UpdateCondition();
	}

	public void UpdateCondition()
	{
	}

	public bool IsClaimable(bool isPremium, out bool isAdsReward)
	{
		isAdsReward = false;
		// Check if reward is claimable based on player level and claim status
		return false;
	}

	private void OnClickGet(bool isNormal)
	{
		if (isNormal)
			GetNormal(0);
		else
		{
			OnClickPurchaseBtn?.Invoke();
		}
	}

	private void GetNormal(int gemValue)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateStatus();
	}

	private void GetADNormal(int gemValue)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateStatus();
	}

	private void GetPremium(int gemValue)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateStatus();
	}
}
