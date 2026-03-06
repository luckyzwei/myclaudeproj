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
		base.Awake();
		Disposables = new CompositeDisposable();

		if (PrevManagerBtn != null) PrevManagerBtn.onClick.AddListener(OnClickPrevManagerBtn);
		if (NextManagerBtn != null) NextManagerBtn.onClick.AddListener(OnClickNextManagerBtn);
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public override void OnShowBefore()
	{
		if (Disposables != null) { Disposables.Dispose(); }
		Disposables = new CompositeDisposable();
	}

	public override void OnHideBefore()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public override void Hide()
	{
		base.Hide();
	}

	public void Set(int managerIdx, E_ManagerInfoTab initTab, bool isActivePrevNextBtn)
	{
		ManagerIdx = managerIdx;
		IsActivePrevNextBtn = isActivePrevNextBtn;

		if (ManagerCard != null) ManagerCard.Set(managerIdx);
		if (StatusTab != null) StatusTab.Set(managerIdx);
		if (SkillsTab != null) SkillsTab.Set(managerIdx);

		SetIsActivePrevNextBtn(isActivePrevNextBtn);
		UpdateRedDot();

		if (TabToggleGroup != null)
		{
			int tabIdx = initTab == E_ManagerInfoTab.Skills ? 1 : 0;
			TabToggleGroup.ChangeTab(tabIdx);
		}
	}

	public override void OnRefresh()
	{
		Set(ManagerIdx, E_ManagerInfoTab.None, IsActivePrevNextBtn);
	}

	private void UpdateRedDot()
	{
		if (RedDot_Status != null) RedDot_Status.SetActive(false);
		if (RedDot_Skills != null) RedDot_Skills.SetActive(false);
	}

	private void OnClickPrevManagerBtn()
	{
		int prevIdx = ManagerIdx - 1;
		if (prevIdx >= 0)
		{
			Set(prevIdx, E_ManagerInfoTab.None, IsActivePrevNextBtn);
		}
	}

	private void OnClickNextManagerBtn()
	{
		int nextIdx = ManagerIdx + 1;
		Set(nextIdx, E_ManagerInfoTab.None, IsActivePrevNextBtn);
	}

	public void SetIsActivePrevNextBtn(bool isActive)
	{
		IsActivePrevNextBtn = isActive;
		SetEnableMoveBtn(isActive);
	}

	private void SetEnableMoveBtn(bool bEnable)
	{
		if (PrevManagerBtn != null) PrevManagerBtn.gameObject.SetActive(bEnable);
		if (NextManagerBtn != null) NextManagerBtn.gameObject.SetActive(bEnable);
	}

	private void InitHudTopInfo(bool isOpenAcquisition)
	{
		if (HUDTopInfo == null) return;
	}

	public void ManagerReinforceTutorial()
	{
		if (TabToggleGroup != null)
			TabToggleGroup.ChangeTab(0);
	}

	public TabToggleGroup GetTabToggleGroup()
	{
		return TabToggleGroup;
	}
}
