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
		base.Awake();
		if (ConfirmBtn != null) ConfirmBtn.onClick.AddListener(OnClickConfirmBtn);
	}

	public void SetOrderShortcut()
	{
		PopupContentsType = E_PopupContentsType.FactoryShortcut;
		place = "Order";
		SetChar_Secretary();
		if (CancelBtn != null) CancelBtn.SetActive(true);
		Show();
	}

	public void SetStorageShortcut()
	{
		PopupContentsType = E_PopupContentsType.FactoryShortcut;
		place = "Storage";
		SetChar_Economic();
		if (CancelBtn != null) CancelBtn.SetActive(true);
		Show();
	}

	public void SetFactoryOpen()
	{
		PopupContentsType = E_PopupContentsType.FactoryShortcut;
		place = "Factory";
		SetChar_Economic();
		if (CancelBtn != null) CancelBtn.SetActive(false);
		Show();
	}

	public void SeasonalPreOpenNotice()
	{
		PopupContentsType = E_PopupContentsType.SeasonalPreOpen;
		SetChar_Secretary();
		if (CancelBtn != null) CancelBtn.SetActive(true);
		Show();
	}

	private void SetChar_Economic()
	{
		if (CharImage != null) CharImage.gameObject.SetActive(true);
	}

	private void SetChar_Secretary()
	{
		if (CharImage != null) CharImage.gameObject.SetActive(true);
	}

	private void OnClickConfirmBtn()
	{
		if (PopupContentsType == E_PopupContentsType.FactoryShortcut)
			GotoFactory();
		Hide();
	}

	private void GotoFactory()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
	}
}
