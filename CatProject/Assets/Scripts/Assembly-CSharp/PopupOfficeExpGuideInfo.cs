using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupOfficeExpGuideInfo", false, false)]
public class PopupOfficeExpGuideInfo : UIBase
{
	[Serializable]
	public struct MoodUI
	{
		public Text MoodCount;

		public Text MoodGetExp;

		public Text MoodSums;
	}

	[Header("[PopupOfficeExpGuideInfo]")]
	[SerializeField]
	private Text TotalExpPerSecondText;

	[SerializeField]
	private Text OfficeExpPerSecondText;

	[SerializeField]
	private Text PlantExpPerSecondText;

	[SerializeField]
	private Text BuffObjectExpPerSecondText;

	[SerializeField]
	private Text CarExpPerSecondText;

	[SerializeField]
	private Text CollectionExpPerSecondText;

	[SerializeField]
	private Text BoosterExpPerSecondText;

	[Space(10f)]
	[SerializeField]
	private List<MoodUI> MoodUIs;

	[Space(10f)]
	[SerializeField]
	private ItemExpRatioInfo ItemObj;

	[SerializeField]
	private ScrollRect PlantRootScroll;

	[SerializeField]
	private GameObject NullPlantObj;

	[SerializeField]
	private ScrollRect BuffObjectRootScroll;

	[SerializeField]
	private GameObject NullBuffObjectObj;

	[Header("[Color]")]
	[SerializeField]
	private string blueDefine;

	[SerializeField]
	private string greenDefine;

	private string blueCode;

	private string greenCode;

	private int curOfficeIdx;

	private int curCompanyIdx;

	private int curManagerIdx;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
	}

	public void Set(int officeIdx, int companyIdx, int managerIdx)
	{
	}

	private void UpdateExp(int officeExp)
	{
	}

	private void UpdateEmployeeMood()
	{
	}

	private void UpdatePlant()
	{
	}

	private void UpdateBuffObject()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
