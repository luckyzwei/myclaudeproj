using System;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;
using UnityEngine;
using UnityEngine.UI;

public class QueenSkinCell : MonoBehaviour
{
	private const string ANIM_NORMAL = "Normal";

	private const string ANIM_HIGHLIGHTED = "Highlighted";

	private const string ANIM_PRESSED = "Pressed";

	private const string ANIM_SELECTED = "Selected";

	private const string ANIM_DISABLED = "Disabled";

	private const string ANIM_LOCKED = "Locked";

	[SerializeField]
	private Image m_image;

	[SerializeField]
	private StorePurchaseButton m_storePurchaseButton;

	[SerializeField]
	private PriceWidget m_priceWidget;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	protected QueenSkinIcons m_icon;

	protected Action<QueenSkinIcons> m_callback;

	protected Action<bool> m_purchaseCallback;

	protected Action m_purchaseFailCallback;

	protected Button m_button;

	protected bool m_unlocked;

	protected Product m_product;

	private void Awake()
	{
		m_button = GetComponent<Button>();
		if (m_button != null)
			m_button.onClick.AddListener(OnButtonPressed);
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void Configure(QueenSkinIcons icon, Action<QueenSkinIcons> callback, Action<bool> purchaseCallback = null, Action purchaseFailCallback = null, Product product = null)
	{
		m_icon = icon;
		m_callback = callback;
		m_purchaseCallback = purchaseCallback;
		m_purchaseFailCallback = purchaseFailCallback;
		m_product = product;

		// All skins unlocked in offline mode
		m_unlocked = true;

		// Set icon image if available
		// Note: icon sprite comes from Balancy ScriptableObject data

		// Hide purchase UI
		if (m_priceWidget != null)
			m_priceWidget.gameObject.SetActive(false);
		if (m_storePurchaseButton != null)
			m_storePurchaseButton.gameObject.SetActive(false);

		SetButtonAnimation();
	}

	private void OnStoreItemPurchased(Product product, bool wasSuccess)
	{
		if (wasSuccess)
			m_purchaseCallback?.Invoke(true);
		else
			m_purchaseFailCallback?.Invoke();
	}

	public virtual void OnButtonPressed()
	{
		m_callback?.Invoke(m_icon);
	}

	private void OnQueenSkinChanged()
	{
		SetButtonAnimation();
	}

	private void OnPurchased(bool success)
	{
		if (success)
		{
			m_unlocked = true;
			SetButtonAnimation();
			m_purchaseCallback?.Invoke(true);
		}
	}

	protected void SetButtonAnimation()
	{
		if (m_animatorHelper == null) return;

		string currentSkin = CosmeticsManager.QueenSkinClientID;
		if (m_icon != null && m_icon.ClientId == currentSkin)
			m_animatorHelper.Play(ANIM_SELECTED);
		else if (m_unlocked)
			m_animatorHelper.Play(ANIM_NORMAL);
		else
			m_animatorHelper.Play(ANIM_LOCKED);
	}
}
