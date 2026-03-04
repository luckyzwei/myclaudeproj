using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;
using UnityEngine.UI;

public class ItemCompanyExpUp : MonoBehaviour
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
	private Image OriginExpProgress;

	[SerializeField]
	private Slider ExpProgress;

	[SerializeField]
	private Text ExpPerText;

	[SerializeField]
	private GameObject Effect;

	[SerializeField]
	private GameObject LvUpObj;

	public bool Set(int company, BigInteger before_exp, BigInteger get_exp, int region = -1)
	{
		return false;
	}

	public bool SetPreview(int company, BigInteger before_exp, BigInteger get_exp)
	{
		return false;
	}
}
