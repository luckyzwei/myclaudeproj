using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageManageForest", false, false)]
public class PageManageForest : FullScreenUI
{
	public enum ToggleTab
	{
		Woker = 0,
		Forest = 1,
		Tree = 2,
		Max = 3
	}

	[SerializeField]
	private HudTopComponent hudTopComponent;

	[SerializeField]
	private List<Toggle> toggles;

	[SerializeField]
	private List<RectTransform> toggleContents;

	public ToggleTab CurrentTab { get; private set; }

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	public void ChangeTab(ToggleTab tab, bool on, bool selecttab = false)
	{
	}
}
