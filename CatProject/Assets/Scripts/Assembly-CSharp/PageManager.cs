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
	}

	private void OnDisable()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnRefresh()
	{
	}

	public override void OnHideAfter()
	{
	}

	public void SetFocusCategory(E_MANAGER_SORTING category)
	{
	}

	public void SetEnterAcquisition(bool isEnter)
	{
	}

	private void OnClickInfoBtn()
	{
	}

	private void OnClickSuperStaffInfo()
	{
	}

	private void OnClickOfficeManagingBtn()
	{
	}

	private void OnClickSortingBtn()
	{
	}

	private void OnClickManagerShopBtn()
	{
	}

	private void SetCategory(E_MANAGER_SORTING category, bool isInit = false)
	{
	}

	public void UpdateList()
	{
	}

	public void UpdateManagerCard()
	{
	}

	public void UpdateNoti()
	{
	}

	private void UpdateManagerCard(int managerIdx)
	{
	}

	private void Update_SpecialManagerList()
	{
	}

	public void SetTarget(int office, int manager)
	{
	}

	public void SortingList()
	{
	}

	private void ChangeTab(E_MANAGER_TAP tab, bool on)
	{
	}

	public int GetNextManagerIdx(int curManagerIdx)
	{
		return 0;
	}

	public int GetPrevManagerIdx(int curManagerIdx)
	{
		return 0;
	}

	public GameObject GetFirstManagerCard()
	{
		return null;
	}
}
