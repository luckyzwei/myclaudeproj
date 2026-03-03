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

	public string CurManagerName => null;

	public Color CurFrameColor => default(Color);

	public int CurManagerIdx => 0;

	private void Awake()
	{
	}

	public virtual void Set(int managerIdx, int managerCount = -1, bool isNew = false, bool onHireObjDeactive = false, bool isAcquisition = false)
	{
	}

	public void SetRedDotCondition(ManagerCardSystem.E_RedDotCondition condition)
	{
	}

	public void UpdateRedDot()
	{
	}

	private void SetManagerCommonInfo(ManagerInfoData infoData)
	{
	}

	private void UpdateOfficeValue(int tempManagerCount, bool onHireObjDeactive = false)
	{
	}

	private void UpdateAcquisitionValue()
	{
	}

	private void UpdateHireInfo(bool onHireObjDeactive)
	{
	}

	protected virtual void OnClickManager()
	{
	}
}
