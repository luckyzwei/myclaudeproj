using System;
using Balancy.Models;
using DG.Tweening;
using KWCore.UI;
using TMPro;
using UnityEngine;

public class PopupSpecialOffer : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/PopUpSpecialOffer";

	public const string PREFAB_VIP_NAME = "Prefabs/Popups/PopUpSpecialOffer";

	private const string REWARD_POPUP = "Prefabs/KWReward/Popup-StoreReward";

	private const string ANIM_OUTRO = "Outro";

	private const string ANIM_ANIM_NOADSICON_OUTRO = "Anim-NoAdsIcon-Outro";

	private const string ANIM_ANIM_NOADSICON_BREAK = "Anim-NoAdsIcon-Break";

	[SerializeField]
	protected Transform m_containerParent;

	[SerializeField]
	protected ItemWithAmountCell m_itemWithAmountCell;

	[SerializeField]
	private StorePurchaseButton m_storePurchaseButton;

	[SerializeField]
	private PriceWidget m_priceWidget;

	[SerializeField]
	private TextMeshProUGUI m_coinAmount;

	[SerializeField]
	private TextMeshProUGUI m_originalPriceText;

	[SerializeField]
	private TextMeshProUGUI m_iapText;

	[SerializeField]
	private TextMeshProUGUI m_percentageOffText;

	[SerializeField]
	private TextMeshProUGUI m_valueText;

	[SerializeField]
	private AnimatorHelper m_iconAnimatorHelper;

	[SerializeField]
	private TextMeshProUGUI m_title;

	[SerializeField]
	private GameObject m_discountTag;

	[SerializeField]
	private GameObject m_valueTag;

	[Header("Icon movement")]
	[SerializeField]
	protected Transform m_iconTransform;

	[SerializeField]
	protected CanvasGroup m_iconCanvasGroup;

	[SerializeField]
	private ParticleSystem m_iconVfx;

	[SerializeField]
	private float m_moveDuration;

	[SerializeField]
	private float m_fadeDuration;

	[SerializeField]
	private float m_moveDelay;

	[SerializeField]
	private float m_iconFadeDelay;

	[SerializeField]
	private Vector3 m_moveFinalScale;

	[SerializeField]
	private Ease m_moveEase;

	[SerializeField]
	private Ease m_scaleEase;

	private Transform m_receiverTransform;

	private Transform m_receiverParent;

	private Action m_receiverStartCallback;

	private Action m_receiverFinishCallback;

	protected KwaleeOffer m_kwaleeOffer;

	private Action m_callback;

	private bool m_hasClaimed;

	[SerializeField]
	private bool m_alignRewardsCenter;

	private CanvasGroup m_receiverCanvasGroup;

	public void ConfigReceiver(Transform receiver = null, Transform parent = null, Action startMoveCallback = null, Action finishMoveCallback = null)
	{
	}

	public virtual void Config(KwaleeOffer kwaleeOffer, Action callback = null, bool userRequested = false, string source = "")
	{
	}

	protected virtual void SpawnRewardsCells()
	{
	}

	protected virtual void PurchaseButtonPressed(bool purchased)
	{
	}

	private void Update()
	{
	}

	private void MoveTowardsReceiver()
	{
	}

	private void ActivateVFX()
	{
	}

	private void DestroyIcon()
	{
	}

	public virtual void MoveIconAndClose()
	{
	}

	private void HidePopup()
	{
	}

	public string GetOfferClientId()
	{
		return null;
	}
}
