using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupFactoryShortcut", false, false)]
public class PopupFactoryShortcut : UIBase
{
	private enum E_PopupContentsType
	{
		None = 0,
		FactoryShortcut = 1,
		SeasonalPreOpen = 2
	}

	[SerializeField]
	private Button ConfirmBtn;

	[SerializeField]
	private GameObject CancelBtn;

	[SerializeField]
	private Text ConfirmBtnText;

	[SerializeField]
	private Image CharImage;

	[SerializeField]
	private Text CharName;

	[SerializeField]
	private Image MainImage;

	[SerializeField]
	private Text Desc;

	private string place;

	private E_PopupContentsType PopupContentsType;

	protected override void Awake()
	{
	}

	public void SetOrderShortcut()
	{
	}

	public void SetStorageShortcut()
	{
	}

	public void SetFactoryOpen()
	{
	}

	public void SeasonalPreOpenNotice()
	{
	}

	private void SetChar_Economic()
	{
	}

	private void SetChar_Secretary()
	{
	}

	private void OnClickConfirmBtn()
	{
	}

	private void GotoFactory()
	{
	}
}
