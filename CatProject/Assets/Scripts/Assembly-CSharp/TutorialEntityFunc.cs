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
		base.StartEntity();
		switch (Func)
		{
			case FuncType.ShowSecretary:
				// Show secretary character in office
				Complete = true;
				break;
			case FuncType.StartBus:
				// Start bus arrival animation
				Complete = true;
				break;
			case FuncType.WaitCeo:
				StartCoroutine(WaitCeo());
				break;
			case FuncType.EditCompanyName:
				// Open company name edit popup
				Complete = true;
				break;
			case FuncType.WorkCeo:
				// Make CEO start working
				Complete = true;
				break;
			case FuncType.DeleteSecretary:
				// Remove secretary character
				Complete = true;
				break;
			case FuncType.UIHideAll:
				// Hide all UI elements
				Complete = true;
				break;
			case FuncType.BusWait:
				StartCoroutine(WaitTime(2f));
				break;
			case FuncType.RepairingWait:
				StartCoroutine(WaitRepair(0));
				break;
			case FuncType.ShowPopupOfficeUpgrade:
				// Show office upgrade popup
				Complete = true;
				break;
			case FuncType.Vibrate:
				Handheld.Vibrate();
				Complete = true;
				break;
			case FuncType.ShowAdsupply:
				// Show ad supply button
				Complete = true;
				break;
			case FuncType.GiveTonic:
				// Give tonic item to player
				Complete = true;
				break;
			case FuncType.WaitFactory:
				StartCoroutine(WaitFactory());
				break;
			case FuncType.FocusFirstFactory:
				// Focus camera on first factory
				Complete = true;
				break;
			case FuncType.GiveFactoryFirstItem:
				// Give first factory production item
				Complete = true;
				break;
			case FuncType.FocusOrderBuilding:
				// Focus camera on order building
				Complete = true;
				break;
			case FuncType.HideFactoryWorkplacePopup:
				// Hide factory workplace popup
				Complete = true;
				break;
			case FuncType.GiveKey:
				// Give key item to player
				Complete = true;
				break;
			case FuncType.ShowManagerInfo:
				// Show manager info popup
				Complete = true;
				break;
			case FuncType.KillMask:
				// Remove tutorial mask
				Complete = true;
				break;
			case FuncType.CEOGotoRepair:
				// Make CEO go to repair
				Complete = true;
				break;
			case FuncType.ShowStrikeToast:
				// Show strike toast notification
				Complete = true;
				break;
			case FuncType.ShowRichPointInfoUI:
				// Show rich point info UI
				Complete = true;
				break;
			case FuncType.ShowAcquisitionMain:
				// Show acquisition main page
				Complete = true;
				break;
			case FuncType.ShowHouseSalePopup:
				// Show house sale popup
				Complete = true;
				break;
			case FuncType.UpdateRichWayProgress:
				// Update rich way progress
				Complete = true;
				break;
			case FuncType.ReinforceManager:
				// Reinforce manager
				Complete = true;
				break;
			case FuncType.ShowOfficeManagement_CeoTab:
				// Show office management CEO tab
				Complete = true;
				break;
			case FuncType.FocusHighestProductionFactory:
				// Focus on highest production factory
				Complete = true;
				break;
			case FuncType.WaitCloseRewardPage:
				// Wait for reward page to close
				Complete = true;
				break;
			default:
				Complete = true;
				break;
		}
	}

	[IteratorStateMachine(typeof(_003CWaitFactory_003Ed__3))]
	private IEnumerator WaitFactory()
	{
		yield return new WaitForSeconds(1f);
		Complete = true;
	}

	[IteratorStateMachine(typeof(_003CWaitRepair_003Ed__4))]
	private IEnumerator WaitRepair(int officeIdx)
	{
		yield return new WaitForSeconds(1f);
		Complete = true;
	}

	[IteratorStateMachine(typeof(_003CWaitTime_003Ed__5))]
	private IEnumerator WaitTime(float time)
	{
		yield return new WaitForSeconds(time);
		Complete = true;
	}

	[IteratorStateMachine(typeof(_003CWaitCeo_003Ed__6))]
	private IEnumerator WaitCeo()
	{
		yield return new WaitForSeconds(1f);
		Complete = true;
	}
}
