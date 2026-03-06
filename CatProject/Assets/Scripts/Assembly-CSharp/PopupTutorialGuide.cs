using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupTutorialGuide", false, false)]
public class PopupTutorialGuide : UIBase
{
	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Text DescText;

	[SerializeField]
	private Transform Root;

	private GameObject GuideObj;

	public void StartTutorial(int tuto_key)
	{
		if (TitleText != null) TitleText.text = "";
		if (DescText != null) DescText.text = "";
		if (Root != null && GuideObj == null)
		{
			// Load tutorial guide resource
		}
	}

	public override void Hide()
	{
		if (GuideObj != null)
		{
			Destroy(GuideObj);
			GuideObj = null;
		}
		base.Hide();
	}
}
