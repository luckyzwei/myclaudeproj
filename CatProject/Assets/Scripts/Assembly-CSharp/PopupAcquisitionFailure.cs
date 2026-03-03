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
	}

	public void Set(int stageIdx)
	{
	}

	private void OnClickedConfirmButton()
	{
	}

	private void OnClickedRetryButton()
	{
	}

	private void OnClickedShortcutShopButton()
	{
	}

	private void OnClickedShortcutReinforceButton()
	{
	}

	private void OnClickedShortcutManagerKeyButton()
	{
	}
}
