using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageManager", false, false)]
public class PageManager : UIBase
{
	public enum E_MANAGER_TAP
	{
		ceo = 0,
		super_staff = 1,
		max = 2
	}

	public enum E_MANAGER_SORTING
	{
		None = 0,
		Reward = 1,
		Exp = 2,
		Level = 3,
		Acquisition = 4
	}

	[Header("PageManager")]
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Button SortingBtn;

	[SerializeField]
	private Text SortingText;

	[SerializeField]
	private List<Toggle> list_toggle;

	[SerializeField]
	private List<GameObject> list_tap_object;

	[Header("ManagerList")]
	[SerializeField]
	private ItemManagerCard ManagerItem;

	[SerializeField]
	private RecycleScrollRect ManagerScroll;

	[Header("SuperStaffList")]
	[SerializeField]
	private Button btn_super_staff_info;

	[SerializeField]
	private ItemSuperStaffCard superStaffCard;

	[SerializeField]
	private ScrollRect scroll_special_manager;

	[Space(5f)]
	[Header("Bottom")]
	[SerializeField]
	private GameObject BottomRoot;

	[SerializeField]
	private Button ManagerShopBtn;

	[SerializeField]
	private Button OfficeManagingBtn;

	[SerializeField]
	private GameObject EnableEquip_Noti;

	[SerializeField]
	private GameObject UnSatisfy_Noti;

	private E_MANAGER_SORTING CurCategory;

	private List<E_MANAGER_SORTING> CategoryList;

	private CompositeDisposable Disposables;

	private List<ManagerInfoData> CurrentSortingManagers;

	private List<ManagerInfoData> CurrentSortingUnlockManagers;

	private bool IsEnterAcquisition;

	[Header("Tap")]
	public E_MANAGER_TAP CurTab { get; private set; }

	public int TargetOfficeIdx { get; private set; }

	public int TargetManagerIdx { get; private set; }

	protected override void Awake()
	{
		base.Awake();
		Disposables = new CompositeDisposable();
		CurrentSortingManagers = new List<ManagerInfoData>();
		CurrentSortingUnlockManagers = new List<ManagerInfoData>();
		CategoryList = new List<E_MANAGER_SORTING> { E_MANAGER_SORTING.Reward, E_MANAGER_SORTING.Exp, E_MANAGER_SORTING.Level, E_MANAGER_SORTING.Acquisition };
		CurCategory = E_MANAGER_SORTING.None;
		CurTab = E_MANAGER_TAP.ceo;

		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfoBtn);
		if (SortingBtn != null) SortingBtn.onClick.AddListener(OnClickSortingBtn);
		if (ManagerShopBtn != null) ManagerShopBtn.onClick.AddListener(OnClickManagerShopBtn);
		if (OfficeManagingBtn != null) OfficeManagingBtn.onClick.AddListener(OnClickOfficeManagingBtn);
		if (btn_super_staff_info != null) btn_super_staff_info.onClick.AddListener(OnClickSuperStaffInfo);

		if (list_toggle != null)
		{
			for (int i = 0; i < list_toggle.Count; i++)
			{
				int tabIdx = i;
				if (list_toggle[i] != null)
					list_toggle[i].onValueChanged.AddListener((on) => ChangeTab((E_MANAGER_TAP)tabIdx, on));
			}
		}
	}

	private void OnDisable()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	public override void OnShowBefore()
	{
		SetCategory(CurCategory, true);
		UpdateList();
		Update_SpecialManagerList();
		UpdateNoti();
	}

	public override void OnRefresh()
	{
		UpdateList();
		UpdateNoti();
	}

	public override void OnHideAfter()
	{
		IsEnterAcquisition = false;
	}

	public void SetFocusCategory(E_MANAGER_SORTING category)
	{
		CurCategory = category;
	}

	public void SetEnterAcquisition(bool isEnter)
	{
		IsEnterAcquisition = isEnter;
	}

	private void OnClickInfoBtn()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickSuperStaffInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickOfficeManagingBtn()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageOfficeManagement>();
	}

	private void OnClickSortingBtn()
	{
		int curIdx = CategoryList.IndexOf(CurCategory);
		int nextIdx = (curIdx + 1) % CategoryList.Count;
		SetCategory(CategoryList[nextIdx]);
	}

	private void OnClickManagerShopBtn()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void SetCategory(E_MANAGER_SORTING category, bool isInit = false)
	{
		CurCategory = category;
		if (SortingText != null) SortingText.text = category.ToString();
		if (!isInit) SortingList();
	}

	public void UpdateList()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ManagerCardSystem == null) return;
		SortingList();
	}

	public void UpdateManagerCard()
	{
		UpdateList();
	}

	public void UpdateNoti()
	{
		if (EnableEquip_Noti != null) EnableEquip_Noti.SetActive(false);
		if (UnSatisfy_Noti != null) UnSatisfy_Noti.SetActive(false);
	}

	private void UpdateManagerCard(int managerIdx)
	{
	}

	private void Update_SpecialManagerList()
	{
	}

	public void SetTarget(int office, int manager)
	{
		TargetOfficeIdx = office;
		TargetManagerIdx = manager;
	}

	public void SortingList()
	{
		if (CurrentSortingManagers == null) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ManagerCardSystem == null) return;
	}

	private void ChangeTab(E_MANAGER_TAP tab, bool on)
	{
		if (!on) return;
		CurTab = tab;
		if (list_tap_object != null)
		{
			for (int i = 0; i < list_tap_object.Count; i++)
			{
				if (list_tap_object[i] != null)
					list_tap_object[i].SetActive(i == (int)tab);
			}
		}
		if (tab == E_MANAGER_TAP.ceo)
			UpdateList();
		else if (tab == E_MANAGER_TAP.super_staff)
			Update_SpecialManagerList();
	}

	public int GetNextManagerIdx(int curManagerIdx)
	{
		if (CurrentSortingManagers == null || CurrentSortingManagers.Count == 0) return 0;
		return 0;
	}

	public int GetPrevManagerIdx(int curManagerIdx)
	{
		if (CurrentSortingManagers == null || CurrentSortingManagers.Count == 0) return 0;
		return 0;
	}

	public GameObject GetFirstManagerCard()
	{
		if (ManagerItem != null) return ManagerItem.gameObject;
		return null;
	}
}
