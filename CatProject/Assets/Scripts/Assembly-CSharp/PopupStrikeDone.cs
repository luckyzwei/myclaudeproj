using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupStrikeDone", false, false)]
public class PopupStrikeDone : UIBase
{
	[Header("PopupStrikeDone")]
	[SerializeField]
	private Image CompanyIcon;

	[SerializeField]
	private Text CompanyName;

	[SerializeField]
	private Text CompanyGrade;

	[SerializeField]
	private Image CompanyGradeBG;

	[SerializeField]
	private GameObject CompanySpecialObj;

	[Space(5f)]
	[SerializeField]
	private Text DescText;

	public void Set(int companyIdx)
	{
		// Update display
	}
}
