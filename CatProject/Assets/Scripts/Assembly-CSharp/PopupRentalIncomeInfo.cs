using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRentalIncomeInfo", false, false)]
public class PopupRentalIncomeInfo : UIBase
{
	[Header("[PopupRentalIncomeInfo]")]
	[SerializeField]
	private Text RentalFeeText;

	[SerializeField]
	private Text RentalFeeValue;

	[SerializeField]
	private Text ItemFeeText;

	[SerializeField]
	private Text ItemFeeValue;

	[SerializeField]
	private GameObject CEOBuffRoot;

	[SerializeField]
	private Text CEOBuffText;

	[SerializeField]
	private Text CEOBuffValue;

	[SerializeField]
	private GameObject SpecialCompanyRoot;

	[SerializeField]
	private Text SpecialCompanyText;

	[SerializeField]
	private Text SpecialCompanyValue;

	[SerializeField]
	private Text TotalFeeText;

	[SerializeField]
	private Text TotalFeeValue;

	[Space(5f)]
	[SerializeField]
	private Text MoodDebuffText;

	[SerializeField]
	private GameObject DebuffOnObj;

	public void Set(int office)
	{
		// Update display
	}
}
