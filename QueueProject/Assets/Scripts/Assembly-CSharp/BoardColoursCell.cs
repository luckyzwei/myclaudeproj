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
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void Configure(BoardColorsIcon icon, Action<BoardColorsIcon> callback, Product product = null)
	{
	}

	public virtual void OnButtonPressed()
	{
	}

	private void OnPurchased(bool success)
	{
	}

	private void OnBoardColorsChanged()
	{
	}

	protected virtual bool IsUnlocked()
	{
		return false;
	}

	protected void SetButtonAnimations()
	{
	}
}
