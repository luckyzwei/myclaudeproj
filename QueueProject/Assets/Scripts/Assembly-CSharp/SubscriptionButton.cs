using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine;

public class SubscriptionButton : MonoBehaviour
{
	private const string VIP_POPUP = "Prefabs/Popups/PopupVipOffer";

	private const string ANIM_ANIM_LEVELCOMPLETE_TOPUI_IDLE = "Anim-LevelComplete-TopUI-Idle";

	private const string ANIM_ANIM_LEVELCOMPLETE_TOPUI_VIPOFFER = "Anim-LevelComplete-TopUI-VIPOffer";

	[SerializeField]
	private string m_source;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSubscriptionUpdate()
	{
	}

	private void CoreEvents_PopupClosed(PopUpBase popUpBase)
	{
	}

	public void OnButtonPressed()
	{
	}

	private void BalancyMarketEvents_OnProductPurchased(StoreItem product, BalancyMarketEvents.PurchaseType type, string analyticInfo)
	{
	}
}
