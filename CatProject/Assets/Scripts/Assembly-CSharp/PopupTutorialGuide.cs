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
	}

	public override void Hide()
	{
	}
}
