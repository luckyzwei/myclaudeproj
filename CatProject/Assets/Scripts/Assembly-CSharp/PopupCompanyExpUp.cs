using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCompanyExpUp", false, false)]
public class PopupCompanyExpUp : UIBase
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text CompanyGrade;

	[SerializeField]
	private Image CompanyGradeBG;

	[SerializeField]
	private Text AddExp;

	[SerializeField]
	private Slider ExpProgress;

	[SerializeField]
	private Text ExpPerText;

	[SerializeField]
	private GameObject Effect;

	[SerializeField]
	private GameObject LvUpObj;

	public void Set(int company, BigInteger before_exp, BigInteger get_exp)
	{
		// Update display
	}
}
