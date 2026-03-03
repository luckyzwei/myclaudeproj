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
	}

	public override void OnShowBefore()
	{
	}

	public void Init(E_OpenType openType, Tab tab = Tab.None, int focusOfficeIdx = -1)
	{
	}

	private void SetRentalFee()
	{
	}

	private void SetCeo(int focusOfficeIdx)
	{
	}

	private void UpdateCeoList()
	{
	}

	private void UpdateStrikeMessage()
	{
	}

	private void UpdateCeoStrikeStatus()
	{
	}

	private void SetManagement(int focusOfficeIdx)
	{
	}

	[IteratorStateMachine(typeof(_003CFocusOffsetSlot_003Ed__42))]
	private IEnumerator FocusOffsetSlot()
	{
		return null;
	}

	private void OnScrolled(Vector2 value)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckInput_003Ed__44))]
	private IEnumerator CheckInput()
	{
		return null;
	}

	private void OnClickChangeTab(Tab tab, bool isInit = false)
	{
	}

	private void OnClickStrikeInfo()
	{
	}

	private void OnClickStrikeInfoClose()
	{
	}

	private void OnChangeCompanyLvUpAtOnceToggle(bool isOn)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public GameObject GetRentalFeeBoostBtn()
	{
		return null;
	}
}
