using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
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
		Disposables = new CompositeDisposable();

		if (ReinforceBtn != null) ReinforceBtn.onClick.AddListener(OnClickReinforce);
		if (NeedLevelBtn != null) NeedLevelBtn.onClick.AddListener(OnClickNeedLevelBtn);
		if (ReinforceResetBtn != null) ReinforceResetBtn.onClick.AddListener(OnClickReinforceResetBtn);
	}

	private void OnEnable()
	{
		Refresh();
	}

	public void Set(int managerIdx)
	{
		ManagerIdx = managerIdx;
		Refresh();
	}

	public void Refresh()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
		UpdateLevelInfo();
		UpdateReinforceResetInfo();
	}

	public void Reset()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
		IsMaxReinforceLevel = false;
		IsEnoughHasCurrency = false;
		NeedValue = BigInteger.Zero;
		HasValue = BigInteger.Zero;
	}

	private void UpdateLevelInfo()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		int reinforceLevel = 0; // Get from manager data
		IsMaxReinforceLevel = false;

		if (ReinforceLevelText != null) ReinforceLevelText.text = "Lv." + reinforceLevel.ToString();
		SetAbilityValueInfo(ManagerIdx, reinforceLevel);
		SetReinforceBtnText(IsMaxReinforceLevel);

		if (ReinforceBtnObj != null) ReinforceBtnObj.SetActive(!IsMaxReinforceLevel);
		if (ReinforceResourceObj != null) ReinforceResourceObj.SetActive(!IsMaxReinforceLevel);
		if (LockObj != null) LockObj.SetActive(false);
		if (ReinforceRedDot != null) ReinforceRedDot.SetActive(!IsMaxReinforceLevel && IsEnoughHasCurrency);
	}

	private void UpdateReinforceResetInfo()
	{
		if (ReinforceResetObj != null) ReinforceResetObj.SetActive(false);
	}

	private void SetAbilityValueInfo(int managerIdx, int reinforceLevel)
	{
		if (ForceValueText != null) ForceValueText.text = "0";
	}

	private void SetReinforceBtnText(bool isMaxLevel)
	{
		if (ReinforceBtnText != null)
			ReinforceBtnText.text = isMaxLevel ? "MAX" : "";
	}

	private void OnClickReinforce()
	{
		if (IsMaxReinforceLevel) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Reinforce manager
		ShowLevelUpEffect();
		Refresh();
	}

	private void OnClickNeedLevelBtn()
	{
	}

	private void OnClickReinforceResetBtn()
	{
	}

	private void ShowLevelUpEffect()
	{
		if (LevelUpFxObj != null)
		{
			LevelUpFxObj.SetActive(false);
			LevelUpFxObj.SetActive(true);
		}
	}

	public void ManagerReinforceTutorial()
	{
		if (CardLvUpFocusFxObj != null) CardLvUpFocusFxObj.SetActive(true);
	}
}
