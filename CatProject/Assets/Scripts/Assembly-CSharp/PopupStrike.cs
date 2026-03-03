using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupStrike", false, false)]
public class PopupStrike : UIBase
{
	[Header("[PopupStrike]")]
	[SerializeField]
	private Text StrikeTimeText;

	[SerializeField]
	private Text CashCount;

	[Space(5f)]
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

	[Space(10f)]
	[SerializeField]
	private Text NeedCompanyLvText;

	[SerializeField]
	private ItemManagerCard ItemManagerCard;

	[Header("Btns")]
	[SerializeField]
	private Button HireBtn;

	[SerializeField]
	private Button UpgradeBtn;

	[SerializeField]
	private Button NegotiationBtn;

	[SerializeField]
	private Text NegotiationGemText;

	private int OfficeIdx;

	private int CompanyIdx;

	private int ManagerIdx;

	protected override void Awake()
	{
	}

	public void Set(int officeIdx, int companyIdx)
	{
	}

	private void OnClickHire()
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickNegotiation()
	{
	}
}
