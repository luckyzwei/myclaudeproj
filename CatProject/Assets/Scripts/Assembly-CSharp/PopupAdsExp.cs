using System.Numerics;
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
	}

	public void Set(int company)
	{
	}

	private void OnClickGetExp()
	{
	}

	public override void Hide()
	{
	}
}
