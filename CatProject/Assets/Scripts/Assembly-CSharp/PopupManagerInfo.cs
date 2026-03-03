using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupManagerInfo", false, false)]
public class PopupManagerInfo : UIBase, ITabToggleGroup
{
	public enum E_ManagerInfoTab
	{
		None = 0,
		Status = 1,
		Skills = 2
	}

	[SerializeField]
	private GameObject BottomTabObj;

	[SerializeField]
	private TabToggleGroup TabToggleGroup;

	[SerializeField]
	private HUDTopInfo HUDTopInfo;

	[SerializeField]
	private ItemManagerInfoStatusTab StatusTab;

	[SerializeField]
	private ItemManagerInfoSkillsTab SkillsTab;

	[SerializeField]
	private ItemCommonManagerCard ManagerCard;

	[SerializeField]
	private GameObject ManagerLockUnActiveObj;

	[SerializeField]
	private Button PrevManagerBtn;

	[SerializeField]
	private Button NextManagerBtn;

	[SerializeField]
	private GameObject RedDot_Status;

	[SerializeField]
	private GameObject RedDot_Skills;

	private CompositeDisposable Disposables;

	public int ManagerIdx { get; private set; }

	public bool IsActivePrevNextBtn { get; private set; }

	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	public override void Hide()
	{
	}

	public void Set(int managerIdx, E_ManagerInfoTab initTab, bool isActivePrevNextBtn)
	{
	}

	public override void OnRefresh()
	{
	}

	private void UpdateRedDot()
	{
	}

	private void OnClickPrevManagerBtn()
	{
	}

	private void OnClickNextManagerBtn()
	{
	}

	public void SetIsActivePrevNextBtn(bool isActive)
	{
	}

	private void SetEnableMoveBtn(bool bEnable)
	{
	}

	private void InitHudTopInfo(bool isOpenAcquisition)
	{
	}

	public void ManagerReinforceTutorial()
	{
	}

	public TabToggleGroup GetTabToggleGroup()
	{
		return null;
	}
}
