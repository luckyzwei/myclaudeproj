using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageGuideMiniGame_Dig", false, false)]
public class PageGuideMiniGame_Dig : UIBase
{
	[SerializeField]
	private Text Desc_1;

	private int CurrencyIdx;

	public override void OnShowBefore()
	{
		base.OnShowBefore();
	}
}
