using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupSeasonalShortcut", false, false)]
public class PopupSeasonalShortcut : UIBase
{
	[SerializeField]
	private Text DescText;

	[SerializeField]
	private Button ShortcutBtn;

	protected override void Awake()
	{
		base.Awake();
		if (ShortcutBtn != null) ShortcutBtn.onClick.AddListener(OnClickedShortcutBtn);
	}

	public override void OnShowBefore()
	{
		SetDescText();
	}

	private void SetDescText()
	{
	}

	private void OnClickedShortcutBtn()
	{
		Hide();
	}
}
