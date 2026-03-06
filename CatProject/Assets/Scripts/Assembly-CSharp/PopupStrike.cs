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
		base.Awake();
		if (HireBtn != null) HireBtn.onClick.AddListener(OnClickHire);
		if (UpgradeBtn != null) UpgradeBtn.onClick.AddListener(OnClickUpgrade);
		if (NegotiationBtn != null) NegotiationBtn.onClick.AddListener(OnClickNegotiation);
	}

	public void Set(int officeIdx, int companyIdx)
	{
		OfficeIdx = officeIdx;
		CompanyIdx = companyIdx;
	}

	private void OnClickHire()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageManager>();
	}

	private void OnClickUpgrade()
	{
		Hide();
	}

	private void OnClickNegotiation()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.StrikeSystem == null) return;
		root.StrikeSystem.SetNegotiation(OfficeIdx);
		Hide();
	}
}
