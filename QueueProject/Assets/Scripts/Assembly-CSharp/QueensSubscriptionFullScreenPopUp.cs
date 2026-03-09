using UnityEngine;

[SortingLayer("SpecialOffer")]
public class QueensSubscriptionFullScreenPopUp : SubscriptionFullScreenPopUp
{
	[SerializeField]
	private VIPSubscriptionTimer m_timer;

	public const string PREFAB_NAME = "Prefabs/Popups/PopupVipOffer";

	private const string ANIM_ANIM_VIPPOPUP_INTRO = "Anim-VIPPopup-Intro";

	private const string ANIM_ANIM_VIPPOPUP_OUTRO = "Anim-VIPPopup-Outro";

	private const string ANIM_ANIM_VIPPOPUPOFFER_INTRO = "Anim-VIPPopupOffer-Intro";

	private const string ANIM_ANIM_VIPPOPUPOFFER_TRANSITION = "Anim-VIPPopupOffer-Transition";

	private const string ANIM_ANIM_VIPPOPUPOFFER_IDLE = "Anim-VIPPopupOffer-Idle";

	private const string ANIM_ANIM_VIPPOPUPOFFER_FASTINTRO = "Anim-VIPPopupOffer-FastIntro";

	private const string DOUBLE_COINS_PRODUCT = "double_coins";

	[SerializeField]
	private new AnimatorHelper m_animatorHelper;

	[SerializeField]
	private VipAnalyticSender m_analyticSender;

	private bool m_discounted;

	private string m_itemClientId;

	private void Start()
	{
	}

	private void Config(bool discounted)
	{
	}

	private void OnTimeOut()
	{
	}

	public override void OnSubscribeWeeklyPressed()
	{
	}

	private void OnDiscountedSubscriptionPressed()
	{
	}

	protected override void OnPurchasedSubscription(bool didPurchase)
	{
	}

	public void SendAnalytics(bool tap, string source)
	{
	}
}
