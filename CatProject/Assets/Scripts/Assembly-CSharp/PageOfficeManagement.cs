using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageOfficeManagement", false, false)]
public class PageOfficeManagement : UIBase
{
	public enum Tab
	{
		None = 0,
		Boost = 1,
		Ceo = 2,
		Management = 3
	}

	public enum E_OpenType
	{
		hud = 0,
		nomoney = 1,
		company_exp = 2,
		other = 3
	}

	[CompilerGenerated]
	private sealed class _003CCheckInput_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageOfficeManagement _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCheckInput_003Ed__44(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CFocusOffsetSlot_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PageOfficeManagement _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFocusOffsetSlot_003Ed__42(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Tab")]
	[SerializeField]
	private GameObject TabRoot;

	[SerializeField]
	private Toggle BoostTab;

	[SerializeField]
	private Toggle CeoTab;

	[SerializeField]
	private Toggle ManagementTab;

	[SerializeField]
	private GameObject BoostRoot;

	[SerializeField]
	private GameObject CeoRoot;

	[SerializeField]
	private GameObject ManagementRoot;

	[Header("RentalFeeTitle")]
	[SerializeField]
	private Text RentalFeeText;

	[SerializeField]
	private Text EarnRentalFeeTimeText;

	[SerializeField]
	private GameObject BoosterOnObj;

	[Header("RentalFeeTab")]
	[SerializeField]
	private ItemOfficeManagementRentalFeeTab RevenueTab;

	[Header("Strike")]
	[SerializeField]
	private GameObject InStrikeTimeObj;

	[SerializeField]
	private GameObject EnableStrikeObj;

	[SerializeField]
	private ItemRegionStrikeInfo StrikeGradeInfo;

	[SerializeField]
	private Button StrikeInfoBtn;

	[SerializeField]
	private GameObject StrikeInfoBubbleObj;

	[SerializeField]
	private Text StrikeInfoDesc;

	[SerializeField]
	private Button StrikeInfoCloseBtn;

	[Header("Ceo")]
	[SerializeField]
	private ScrollRect CeoScroll;

	[SerializeField]
	private GameObject CeoItem;

	[Header("Management")]
	[SerializeField]
	private ScrollRect ManagementScroll;

	[SerializeField]
	private GameObject ManagementItem;

	[Header("Option")]
	[SerializeField]
	private ToggleController CompanyLvUpAtOnceToggle;

	private Tab CurTab;

	private GameObject FocusOfficeSlot;

	private Coroutine InputCheckCoroutine;

	private CompositeDisposable disposables;

	public static E_OpenType OpenType { get; private set; }

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();
		CurTab = Tab.None;

		if (BoostTab != null) BoostTab.onValueChanged.AddListener((on) => { if (on) OnClickChangeTab(Tab.Boost); });
		if (CeoTab != null) CeoTab.onValueChanged.AddListener((on) => { if (on) OnClickChangeTab(Tab.Ceo); });
		if (ManagementTab != null) ManagementTab.onValueChanged.AddListener((on) => { if (on) OnClickChangeTab(Tab.Management); });
		if (StrikeInfoBtn != null) StrikeInfoBtn.onClick.AddListener(OnClickStrikeInfo);
		if (StrikeInfoCloseBtn != null) StrikeInfoCloseBtn.onClick.AddListener(OnClickStrikeInfoClose);
		if (CompanyLvUpAtOnceToggle != null) CompanyLvUpAtOnceToggle.setToggleListener(OnChangeCompanyLvUpAtOnceToggle);
	}

	public override void OnShowBefore()
	{
		SetRentalFee();
		UpdateStrikeMessage();
	}

	public void Init(E_OpenType openType, Tab tab = Tab.None, int focusOfficeIdx = -1)
	{
		OpenType = openType;
		if (tab == Tab.None) tab = Tab.Boost;
		OnClickChangeTab(tab, true);
		if (focusOfficeIdx >= 0)
		{
			FocusOfficeSlot = null;
			if (tab == Tab.Ceo) SetCeo(focusOfficeIdx);
			else if (tab == Tab.Management) SetManagement(focusOfficeIdx);
		}
	}

	private void SetRentalFee()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (BoosterOnObj != null) BoosterOnObj.SetActive(false);
	}

	private void SetCeo(int focusOfficeIdx)
	{
		UpdateCeoList();
		if (focusOfficeIdx >= 0)
		{
			// Set focus slot and scroll to it
			StartCoroutine(FocusOffsetSlot());
		}
	}

	private void UpdateCeoList()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateCeoStrikeStatus();
	}

	private void UpdateStrikeMessage()
	{
		if (InStrikeTimeObj != null) InStrikeTimeObj.SetActive(false);
		if (EnableStrikeObj != null) EnableStrikeObj.SetActive(false);
	}

	private void UpdateCeoStrikeStatus()
	{
	}

	private void SetManagement(int focusOfficeIdx)
	{
		// Populate management list
		if (focusOfficeIdx >= 0)
		{
			StartCoroutine(FocusOffsetSlot());
		}
	}

	[IteratorStateMachine(typeof(_003CFocusOffsetSlot_003Ed__42))]
	private IEnumerator FocusOffsetSlot()
	{
		yield return null;
		// Scroll to the focused office slot
		if (FocusOfficeSlot != null && CeoScroll != null)
		{
			// Calculate normalized position and set scroll
		}
	}

	private void OnScrolled(Vector2 value)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckInput_003Ed__44))]
	private IEnumerator CheckInput()
	{
		while (true)
		{
			yield return null;
			// Check for input events while page is active
		}
	}

	private void OnClickChangeTab(Tab tab, bool isInit = false)
	{
		CurTab = tab;
		if (BoostRoot != null) BoostRoot.SetActive(tab == Tab.Boost);
		if (CeoRoot != null) CeoRoot.SetActive(tab == Tab.Ceo);
		if (ManagementRoot != null) ManagementRoot.SetActive(tab == Tab.Management);

		if (!isInit)
		{
			if (tab == Tab.Ceo) UpdateCeoList();
		}
	}

	private void OnClickStrikeInfo()
	{
		if (StrikeInfoBubbleObj != null) StrikeInfoBubbleObj.SetActive(true);
	}

	private void OnClickStrikeInfoClose()
	{
		if (StrikeInfoBubbleObj != null) StrikeInfoBubbleObj.SetActive(false);
	}

	private void OnChangeCompanyLvUpAtOnceToggle(bool isOn)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}

	private void OnDisable()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = new CompositeDisposable();
		}
		if (InputCheckCoroutine != null)
		{
			StopCoroutine(InputCheckCoroutine);
			InputCheckCoroutine = null;
		}
	}

	public GameObject GetRentalFeeBoostBtn()
	{
		if (RevenueTab != null) return RevenueTab.gameObject;
		return null;
	}
}
