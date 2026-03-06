using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAcquisitionFailure", false, false)]
public class PopupAcquisitionFailure : UIBase
{
	public enum ButtonType
	{
		Confirm = 0,
		Retry = 1,
		Shortcut_Shop = 2,
		Shortcut_Reinforce = 3,
		Shortcut_ManagerKey = 4
	}

	[SerializeField]
	private Text StageText;

	[SerializeField]
	private Button ConfirmButton;

	[SerializeField]
	private Button RetryButton;

	[SerializeField]
	private Button Shortcut_ShopButton;

	[SerializeField]
	private Button Shortcut_ReinforceButton;

	[SerializeField]
	private Button Shortcut_ManagerKeyButton;

	public Action<ButtonType> OnClickedButtonEvent;

	protected override void Awake()
	{
		base.Awake();
		if (ConfirmButton != null) ConfirmButton.onClick.AddListener(OnClickedConfirmButton);
		if (RetryButton != null) RetryButton.onClick.AddListener(OnClickedRetryButton);
		if (Shortcut_ShopButton != null) Shortcut_ShopButton.onClick.AddListener(OnClickedShortcutShopButton);
		if (Shortcut_ReinforceButton != null) Shortcut_ReinforceButton.onClick.AddListener(OnClickedShortcutReinforceButton);
		if (Shortcut_ManagerKeyButton != null) Shortcut_ManagerKeyButton.onClick.AddListener(OnClickedShortcutManagerKeyButton);
	}

	public void Set(int stageIdx)
	{
		if (StageText != null) StageText.text = stageIdx.ToString();
		Show();
	}

	private void OnClickedConfirmButton()
	{
		OnClickedButtonEvent?.Invoke(ButtonType.Confirm);
		Hide();
	}

	private void OnClickedRetryButton()
	{
		OnClickedButtonEvent?.Invoke(ButtonType.Retry);
		Hide();
	}

	private void OnClickedShortcutShopButton()
	{
		OnClickedButtonEvent?.Invoke(ButtonType.Shortcut_Shop);
		Hide();
	}

	private void OnClickedShortcutReinforceButton()
	{
		OnClickedButtonEvent?.Invoke(ButtonType.Shortcut_Reinforce);
		Hide();
	}

	private void OnClickedShortcutManagerKeyButton()
	{
		OnClickedButtonEvent?.Invoke(ButtonType.Shortcut_ManagerKey);
		Hide();
	}
}
