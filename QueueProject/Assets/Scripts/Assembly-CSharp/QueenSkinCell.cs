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
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void Configure(QueenSkinIcons icon, Action<QueenSkinIcons> callback, Action<bool> purchaseCallback = null, Action purchaseFailCallback = null, Product product = null)
	{
	}

	private void OnStoreItemPurchased(Product product, bool wasSuccess)
	{
	}

	public virtual void OnButtonPressed()
	{
	}

	private void OnQueenSkinChanged()
	{
	}

	private void OnPurchased(bool success)
	{
	}

	protected void SetButtonAnimation()
	{
	}
}
