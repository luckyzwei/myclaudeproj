using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAdsExp", false, false)]
public class PopupAdsExp : UIBase
{
	[SerializeField]
	private Text Desc;

	[SerializeField]
	private Text CompanyName;

	[SerializeField]
	private Image CompanyIcon;

	[SerializeField]
	private Text AddExp;

	[SerializeField]
	private Text ViewCount;

	[SerializeField]
	private Button RefuseBtn;

	[SerializeField]
	private Button AdsBtn;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	private int TargetCompany;

	private BigInteger GetExp;

	private bool GetReward;

	protected override void Awake()
	{
		base.Awake();
		if (RefuseBtn != null) RefuseBtn.onClick.AddListener(() => Hide());
		if (AdsBtn != null) AdsBtn.onClick.AddListener(OnClickGetExp);
	}

	public void Set(int company)
	{
		TargetCompany = company;
		GetReward = false;
	}

	private void OnClickGetExp()
	{
		GetReward = true;
		Hide();
	}

	public override void Hide()
	{
		base.Hide();
	}
}
