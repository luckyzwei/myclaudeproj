using System.Numerics;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemManagerInfoAcquisition : MonoBehaviour
{
	[Header("Reinforce")]
	[SerializeField]
	private Text ReinforceLevelText;

	[SerializeField]
	private GameObject ReinforceBtnObj;

	[SerializeField]
	private GameObject ReinforceResourceObj;

	[SerializeField]
	private Button ReinforceBtn;

	[SerializeField]
	private Image ReinforceResourceImage;

	[SerializeField]
	private SliderTextComponent ReinforceCostInfo;

	[SerializeField]
	private Text ReinforceBtnText;

	[Header("Need Level")]
	[SerializeField]
	private GameObject NeedLevelBtnObj;

	[SerializeField]
	private Button NeedLevelBtn;

	[SerializeField]
	private Text NeedLevelText;

	[SerializeField]
	private GameObject CardLvUpFocusFxObj;

	[Header("Reinforce Reset")]
	[SerializeField]
	private GameObject ReinforceResetObj;

	[SerializeField]
	private Button ReinforceResetBtn;

	[Header("Ability Value")]
	[SerializeField]
	private Text ForceValueText;

	[SerializeField]
	private GameObject LevelUpFxObj;

	[SerializeField]
	private GameObject ReinforceRedDot;

	[Header("Skill")]
	[SerializeField]
	private ItemManagerSkill SkillInfo;

	[Header("Lock")]
	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject LockUnActiveObj;

	[Header("BizAcquisition")]
	[SerializeField]
	private GameObject AcqTeamAssignedObj;

	private int ManagerIdx;

	private bool IsMaxReinforceLevel;

	private bool IsEnoughHasCurrency;

	private BigInteger NeedValue;

	private BigInteger HasValue;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Set(int managerIdx)
	{
	}

	public void Refresh()
	{
	}

	public void Reset()
	{
	}

	private void UpdateLevelInfo()
	{
	}

	private void UpdateReinforceResetInfo()
	{
	}

	private void SetAbilityValueInfo(int managerIdx, int reinforceLevel)
	{
	}

	private void SetReinforceBtnText(bool isMaxLevel)
	{
	}

	private void OnClickReinforce()
	{
	}

	private void OnClickNeedLevelBtn()
	{
	}

	private void OnClickReinforceResetBtn()
	{
	}

	private void ShowLevelUpEffect()
	{
	}

	public void ManagerReinforceTutorial()
	{
	}
}
