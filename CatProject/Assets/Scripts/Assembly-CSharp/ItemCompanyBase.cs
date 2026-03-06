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
		OfficeIdx = officeIdx;
	}

	public void Reset()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public void Set(int regionIdx, int officeIdx)
	{
		RegionIdx = regionIdx;
		OfficeIdx = officeIdx;
		UpdateCompanyExpInfo();
	}

	private void UpdateCompanyExpInfo()
	{
	}

	private void SetCompanyExpInfo(BigInteger curExp, BigInteger needExp)
	{
		if (needExp <= 0) { if (MaxLevelObj != null) MaxLevelObj.SetActive(true); return; }
		if (MaxLevelObj != null) MaxLevelObj.SetActive(false);
		if (CompanyExpProgress != null)
			CompanyExpProgress.value = (float)(curExp * 1000 / needExp) / 1000f;
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}
}
