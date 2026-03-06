using Treeplla;
using UnityEngine;

[UIPath("UI/Page/PageManagerInfoGuide", false, false)]
public class PageManagerInfoGuide : UIBase
{
	[SerializeField]
	private GameObject AdditionalGuideObj;

	[SerializeField]
	private GameObject SeasonalGuideObj;

	[SerializeField]
	private GameObject BizAcqGuideObj;

	public override void OnShowBefore()
	{
		base.OnShowBefore();
	}
}
