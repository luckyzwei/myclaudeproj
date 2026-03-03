using System;
using Treeplla;
using UnityEngine;

[UIPath("UI/Page/PageGuideSpecialDay2Tree", false, false)]
public class PageGuideSpecialDay2Tree : UIBase
{
	[Header("PageGuideSpecialDay2Tree")]
	[SerializeField]
	private Transform GuideItemRoot;

	private int CurIdx;

	public override void OnShowBefore()
	{
	}

	private void UpdateSpecialDayInfo(Action cb)
	{
	}
}
