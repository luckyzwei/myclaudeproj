using System;
using Balancy.Models.LiveOps.Store;
using Balancy.Models.Store;
using UnityEngine;
using UnityEngine.UI;

public class StoreProductCell : MonoBehaviour
{
	[Serializable]
	private struct Badges
	{
		public GameObject popular;

		public GameObject once;

		public GameObject newB;

		public GameObject limited;

		public GameObject great;

		public GameObject free;

		public GameObject best;

		public void Setup(SlotType slotType)
		{
		}
	}

	[Header("Everything is optional")]
	[Header("References")]
	[SerializeField]
	private Text m_titleText;

	[SerializeField]
	protected StorePurchaseButton m_storePurchaseButton;

	[SerializeField]
	private Image m_featureImage;

	[SerializeField]
	private RewardWidget m_rewardWidget;

	[SerializeField]
	private PriceWidget m_priceWidget;

	[Header("Badges")]
	[SerializeField]
	private Badges m_badges;

	[Header("Timer")]
	[SerializeField]
	protected StoreProductCellTimer m_timerObject;

	[Header("Cell Animation")]
	[SerializeField]
	private AnimatorHelper m_cellAnimator;

	[SerializeField]
	private string m_animIntro;

	[Header("Notifications")]
	[SerializeField]
	private NotificationShowWidget m_notificationShowWidget;

	[SerializeField]
	private NotificationSwallowWidget m_notificationSwallowWidget;

	protected Product m_product;

	protected Slot m_slot;

	public virtual void Setup(Product product, Slot slot)
	{
	}

	private void OnEnable()
	{
	}

	protected virtual void SetupWidgets(Slot slot)
	{
	}

	protected virtual void UpdateVisuals()
	{
	}

	private void SetupBadges(Slot slot)
	{
	}

	internal void ShowIntroAnimationWithDelay(float delay)
	{
	}

	protected virtual void SetupTimer()
	{
	}

	private void OnTimerComplete()
	{
	}

	protected virtual void OnProductPurchased(bool wasSuccess)
	{
	}
}
