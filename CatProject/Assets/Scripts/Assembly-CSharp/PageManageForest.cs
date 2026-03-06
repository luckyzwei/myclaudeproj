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
		base.Awake();
		if (toggles != null)
		{
			for (int i = 0; i < toggles.Count; i++)
			{
				int idx = i;
				if (toggles[i] != null)
					toggles[i].onValueChanged.AddListener(on => ChangeTab((ToggleTab)idx, on));
			}
		}
	}

	public override void OnShowBefore()
	{
		if (hudTopComponent != null) hudTopComponent.Binding();
		ChangeTab(ToggleTab.Woker, true, true);
	}

	public override void OnHideAfter()
	{
		if (hudTopComponent != null) hudTopComponent.Unbinding();
	}

	public void ChangeTab(ToggleTab tab, bool on, bool selecttab = false)
	{
		if (!on && !selecttab) return;
		CurrentTab = tab;
		if (toggleContents == null) return;
		for (int i = 0; i < toggleContents.Count; i++)
		{
			if (toggleContents[i] != null)
				toggleContents[i].gameObject.SetActive(i == (int)tab);
		}
	}
}
