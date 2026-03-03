using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialEntityFunc : TutorialEntity
{
	private enum FuncType
	{
		ShowSecretary = 0,
		StartBus = 1,
		WaitCeo = 2,
		EditCompanyName = 3,
		WorkCeo = 4,
		DeleteSecretary = 5,
		UIHideAll = 6,
		BusWait = 7,
		RepairingWait = 8,
		ShowPopupOfficeUpgrade = 9,
		Vibrate = 10,
		ShowAdsupply = 11,
		GiveTonic = 12,
		WaitFactory = 13,
		FocusFirstFactory = 14,
		GiveFactoryFirstItem = 15,
		FocusOrderBuilding = 16,
		HideFactoryWorkplacePopup = 17,
		GiveKey = 18,
		ShowManagerInfo = 19,
		KillMask = 20,
		CEOGotoRepair = 21,
		ShowStrikeToast = 22,
		ShowRichPointInfoUI = 23,
		ShowAcquisitionMain = 24,
		ShowHouseSalePopup = 25,
		UpdateRichWayProgress = 26,
		ReinforceManager = 27,
		ShowOfficeManagement_CeoTab = 28,
		FocusHighestProductionFactory = 29,
		WaitCloseRewardPage = 30
	}

	[CompilerGenerated]
	private sealed class _003CWaitCeo_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntityFunc _003C_003E4__this;

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
		public _003CWaitCeo_003Ed__6(int _003C_003E1__state)
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
	private sealed class _003CWaitFactory_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialEntityFunc _003C_003E4__this;

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
		public _003CWaitFactory_003Ed__3(int _003C_003E1__state)
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
	private sealed class _003CWaitRepair_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int officeIdx;

		public TutorialEntityFunc _003C_003E4__this;

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
		public _003CWaitRepair_003Ed__4(int _003C_003E1__state)
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
	private sealed class _003CWaitTime_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public TutorialEntityFunc _003C_003E4__this;

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
		public _003CWaitTime_003Ed__5(int _003C_003E1__state)
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

	[SerializeField]
	private FuncType Func;

	public override void StartEntity()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitFactory_003Ed__3))]
	private IEnumerator WaitFactory()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitRepair_003Ed__4))]
	private IEnumerator WaitRepair(int officeIdx)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitTime_003Ed__5))]
	private IEnumerator WaitTime(float time)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitCeo_003Ed__6))]
	private IEnumerator WaitCeo()
	{
		return null;
	}
}
