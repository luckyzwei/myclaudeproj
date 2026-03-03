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
	}

	public void Init()
	{
	}

	public override void OnHideAfter()
	{
	}

	private void OnDestroy()
	{
	}
}
