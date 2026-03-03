using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupToastSmall", false, false)]
public class PopupToastSmall : UIBase
{
	[SerializeField]
	private Text Desc;

	public void SetText(string descKey)
	{
	}

	public override void OnHideAfter()
	{
	}
}
