using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageRegionMove", false, false)]
public class PageRegionMove : UIBase
{
	[Header("PageRegionMove")]
	[SerializeField]
	private HudTopComponent hud;

	[SerializeField]
	private ScrollRect ItemListScroll;

	[SerializeField]
	private GameObject ItemObj;

	public override void OnShowBefore()
	{
		Init();
	}

	public void Init()
	{
		if (hud != null) hud.Binding();
	}

	public override void OnHideAfter()
	{
		if (hud != null) hud.Unbinding();
	}

	private void OnDestroy()
	{
		// Cleanup
	}
}
