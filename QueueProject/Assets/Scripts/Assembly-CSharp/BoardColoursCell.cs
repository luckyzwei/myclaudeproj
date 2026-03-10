using System;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;
using UnityEngine;
using UnityEngine.UI;

public class BoardColoursCell : MonoBehaviour
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
	protected PriceWidget m_priceWidget;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	protected BoardColorsIcon m_icon;

	protected Action<BoardColorsIcon> m_callback;

	protected Button m_button;

	protected Product m_product;

	protected bool m_unlocked;

	private void Awake()
	{
		m_button = GetComponent<Button>();
		if (m_button != null)
			m_button.onClick.AddListener(OnButtonPressed);
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void Configure(BoardColorsIcon icon, Action<BoardColorsIcon> callback, Product product = null)
	{
		m_icon = icon;
		m_callback = callback;
		m_product = product;

		// All colors unlocked in offline mode
		m_unlocked = true;

		// Note: icon sprite comes from Balancy ScriptableObject data

		// Hide purchase UI
		if (m_priceWidget != null)
			m_priceWidget.gameObject.SetActive(false);
		if (m_storePurchaseButton != null)
			m_storePurchaseButton.gameObject.SetActive(false);

		SetButtonAnimations();
	}

	public virtual void OnButtonPressed()
	{
		m_callback?.Invoke(m_icon);
	}

	private void OnPurchased(bool success)
	{
		if (success)
		{
			m_unlocked = true;
			SetButtonAnimations();
		}
	}

	private void OnBoardColorsChanged()
	{
		SetButtonAnimations();
	}

	protected virtual bool IsUnlocked()
	{
		return m_unlocked;
	}

	protected void SetButtonAnimations()
	{
		if (m_animatorHelper == null) return;

		string currentColors = CosmeticsManager.BoardColorsClientID;
		if (m_icon != null && m_icon.ClientId == currentColors)
			m_animatorHelper.Play(ANIM_SELECTED);
		else if (m_unlocked)
			m_animatorHelper.Play(ANIM_NORMAL);
		else
			m_animatorHelper.Play(ANIM_LOCKED);
	}
}
