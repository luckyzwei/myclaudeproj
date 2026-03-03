using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCompanyNewFind", false, false)]
public class PopupCompanyNewFind : UIBase
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
	private List<Image> LevelObjs;

	[SerializeField]
	private Slider CompanyExpProgress;

	[SerializeField]
	private Text CompanyExpPerText;

	[SerializeField]
	private GameObject MaxLevelobj;

	[SerializeField]
	private Button OutBtn;

	private int OfficeIdx;

	protected override void Awake()
	{
	}

	public void Set(int office)
	{
	}

	private void OnClickOut()
	{
	}
}
