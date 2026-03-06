using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemManagerCard : MonoBehaviour
{
	[Header("ItemManagerCard")]
	[SerializeField]
	private Button ManagerBtn;

	[SerializeField]
	private GameObject OnHiringObj;

	[SerializeField]
	private Text HireRegionText;

	[SerializeField]
	private Text HireOfficeText;

	[Header("Lock")]
	[SerializeField]
	private Text ManagerLockText;

	[SerializeField]
	private GameObject ManagerLockObj;

	[Header("Info")]
	[SerializeField]
	private Text ManagerName;

	[SerializeField]
	private Image ManagerImg;

	[SerializeField]
	private Image ManagerFrame;

	[Header("Ability")]
	[SerializeField]
	private Image AbilityIcon;

	[SerializeField]
	private Text AbilityValue;

	[Header("Level")]
	[SerializeField]
	private Text ManagerLevel;

	[SerializeField]
	private Slider ManagerExpFill;

	[SerializeField]
	private Text ManagerExpText;

	[Space(5f)]
	[SerializeField]
	private GameObject LevelIcon;

	[SerializeField]
	private GameObject LevelUpArrow;

	[Space(10f)]
	[SerializeField]
	private GameObject NewNoti;

	[SerializeField]
	private GameObject LevelUpNoti;

	[Header("Acquisition")]
	[SerializeField]
	private Text AcqReinforceLvText;

	[SerializeField]
	private Text AcqDealPowerText;

	[SerializeField]
	private GameObject AssignedObj;

	[Header("Layout")]
	[SerializeField]
	private GameObject CardLevelObj;

	[SerializeField]
	private GameObject ReinforceLevelObj;

	[Header("ETC")]
	[SerializeField]
	private Text GachaCountText;

	protected int curManagerIdx;

	private ManagerCardData curCardData;

	private ManagerCardSystem.E_RedDotCondition RedDotCondition;

	public Action InfoCloseCb;

	public string CurManagerName { get { return ManagerName != null ? ManagerName.text : null; } }

	public Color CurFrameColor { get { return ManagerFrame != null ? ManagerFrame.color : default(Color); } }

	public int CurManagerIdx { get { return curManagerIdx; } }

	private void Awake()
	{
		if (ManagerBtn != null)
			ManagerBtn.onClick.AddListener(OnClickManager);
	}

	public virtual void Set(int managerIdx, int managerCount = -1, bool isNew = false, bool onHireObjDeactive = false, bool isAcquisition = false)
	{
		curManagerIdx = managerIdx;
		if (ManagerLockObj != null) ManagerLockObj.SetActive(false);
		if (NewNoti != null) NewNoti.SetActive(isNew);
		UpdateHireInfo(onHireObjDeactive);
		if (isAcquisition)
			UpdateAcquisitionValue();
		else
			UpdateOfficeValue(managerCount, onHireObjDeactive);
	}

	public void SetRedDotCondition(ManagerCardSystem.E_RedDotCondition condition)
	{
		RedDotCondition = condition;
	}

	public void UpdateRedDot()
	{
	}

	private void SetManagerCommonInfo(ManagerInfoData infoData)
	{
	}

	private void UpdateOfficeValue(int tempManagerCount, bool onHireObjDeactive = false)
	{
		if (CardLevelObj != null) CardLevelObj.SetActive(true);
		if (ReinforceLevelObj != null) ReinforceLevelObj.SetActive(false);
		if (GachaCountText != null && tempManagerCount >= 0)
			GachaCountText.text = tempManagerCount.ToString();
	}

	private void UpdateAcquisitionValue()
	{
		if (CardLevelObj != null) CardLevelObj.SetActive(false);
		if (ReinforceLevelObj != null) ReinforceLevelObj.SetActive(true);
	}

	private void UpdateHireInfo(bool onHireObjDeactive)
	{
		if (OnHiringObj != null)
			OnHiringObj.SetActive(!onHireObjDeactive && curManagerIdx > 0);
	}

	protected virtual void OnClickManager()
	{
	}
}
