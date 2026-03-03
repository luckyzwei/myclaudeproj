using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupCoinDCSlot", false, false)]
public class PopupCoinDCSlot : UIBase
{
	[SerializeField]
	private Text textRemainTime;

	[SerializeField]
	private Button btnShortcut;

	[Header("PackageBanner")]
	[SerializeField]
	private ItemSeasonalPackageBanner PackageBanner;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public void SetVisibleShortcutBtn(bool visible)
	{
	}

	private void SetPackageBanner()
	{
	}

	private void OnClickShortcut()
	{
	}
}
