using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageOneTimeInfo", false, false)]
public class PageOneTimeInfo : UIBase
{
	[Header("[PageOneTimeInfo]")]
	[SerializeField]
	private Text titleText;

	public override void OnShowBefore()
	{
		base.OnShowBefore();
	}
}
