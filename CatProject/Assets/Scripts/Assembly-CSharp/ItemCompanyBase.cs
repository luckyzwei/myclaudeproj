using System.Collections.Generic;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemCompanyBase : MonoBehaviour
{
	[Header("CompanyInfo")]
	[SerializeField]
	private Image CompanyIcon;

	[SerializeField]
	private Text CompanyName;

	[SerializeField]
	private Text CompanyGrade;

	[SerializeField]
	private Image CompanyGradeBG;

	[SerializeField]
	private GameObject CompanySpecialLabelObj;

	[SerializeField]
	private List<Image> LevelObjs;

	[SerializeField]
	private Slider CompanyExpProgress;

	[SerializeField]
	private Text CompanyExpPerText;

	[SerializeField]
	private GameObject MaxLevelObj;

	private int RegionIdx;

	private int CompanyIdx;

	private BigInteger NeedCompanyExp;

	private CompositeDisposable Disposables;

	public int OfficeIdx { get; private set; }

	public void Set(int officeIdx)
	{
	}

	public void Reset()
	{
	}

	public void Set(int regionIdx, int officeIdx)
	{
	}

	private void UpdateCompanyExpInfo()
	{
	}

	private void SetCompanyExpInfo(BigInteger curExp, BigInteger needExp)
	{
	}

	private void OnDisable()
	{
	}
}
