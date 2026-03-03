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
	}

	public override void OnShowBefore()
	{
	}

	private void SetDescText()
	{
	}

	private void OnClickedShortcutBtn()
	{
	}
}
