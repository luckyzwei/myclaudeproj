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
		base.Awake();
		if (btnShortcut != null) btnShortcut.onClick.AddListener(OnClickShortcut);
	}

	public override void OnShowBefore()
	{
		SetPackageBanner();
	}

	public void SetVisibleShortcutBtn(bool visible)
	{
		if (btnShortcut != null) btnShortcut.gameObject.SetActive(visible);
	}

	private void SetPackageBanner()
	{
		if (PackageBanner != null) PackageBanner.gameObject.SetActive(false);
	}

	private void OnClickShortcut()
	{
		Hide();
	}
}
