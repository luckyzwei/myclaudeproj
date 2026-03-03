using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupStrikeGem", false, false)]
public class PopupStrikeGem : UIBase
{
	[Header("Company")]
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

	[SerializeField]
	private Text DescText;

	[Header("Btn")]
	[SerializeField]
	private Button NegotiationBtn;

	[SerializeField]
	private Text NegotiationGemText;

	private int OfficeIdx;

	protected override void Awake()
	{
	}

	public void Set(int officeIdx)
	{
	}

	private void OnClickNegotiation()
	{
	}
}
