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
		base.Awake();
		disposables = new CompositeDisposable();
		blueCode = blueDefine;
		greenCode = greenDefine;
	}

	public void Set(int officeIdx, int companyIdx, int managerIdx)
	{
		curOfficeIdx = officeIdx;
		curCompanyIdx = companyIdx;
		curManagerIdx = managerIdx;

		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		UpdateExp(0);
		UpdateEmployeeMood();
		UpdatePlant();
		UpdateBuffObject();

		Show();
	}

	private void UpdateExp(int officeExp)
	{
		if (TotalExpPerSecondText != null) TotalExpPerSecondText.text = "0";
		if (OfficeExpPerSecondText != null) OfficeExpPerSecondText.text = "0";
		if (PlantExpPerSecondText != null) PlantExpPerSecondText.text = "0";
		if (BuffObjectExpPerSecondText != null) BuffObjectExpPerSecondText.text = "0";
		if (CarExpPerSecondText != null) CarExpPerSecondText.text = "0";
		if (CollectionExpPerSecondText != null) CollectionExpPerSecondText.text = "0";
		if (BoosterExpPerSecondText != null) BoosterExpPerSecondText.text = "0";
	}

	private void UpdateEmployeeMood()
	{
		if (MoodUIs == null) return;
		for (int i = 0; i < MoodUIs.Count; i++)
		{
			var mood = MoodUIs[i];
			if (mood.MoodCount != null) mood.MoodCount.text = "0";
			if (mood.MoodGetExp != null) mood.MoodGetExp.text = "0";
			if (mood.MoodSums != null) mood.MoodSums.text = "0";
		}
	}

	private void UpdatePlant()
	{
		if (NullPlantObj != null) NullPlantObj.SetActive(true);
	}

	private void UpdateBuffObject()
	{
		if (NullBuffObjectObj != null) NullBuffObjectObj.SetActive(true);
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
