using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TabToolbar : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TabToolbar _003C_003E4__this;

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
		public _003CStart_003Ed__10(int _003C_003E1__state)
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
	private int m_defaultSelected;

	[SerializeField]
	private bool m_tabChangingEnabled;

	[Space]
	[SerializeField]
	private TabToolbarButton[] m_tabButtons;

	private int m_selectedTabIndex;

	private int m_lastSelectedTabIndex;

	public int SelectedTabIndex => 0;

	public int LastSelectedTabIndex => 0;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Swiped(int dir)
	{
	}

	private bool IsAvailable(TabToolbarButton tab)
	{
		return false;
	}

	public void SetTabChangingEnabled(bool value)
	{
	}

	private void RegisterButtonListeners()
	{
	}

	private void OnTabPressedCallback(int index)
	{
	}

	public void SetTabLocked(int index, bool locked)
	{
	}

	public Vector3 GetButtonPosition(int buttonIndex)
	{
		return default(Vector3);
	}

	public void ChangeTab(int index)
	{
	}

	public void ChangeTab(int index, bool forced = false, bool immediately = false)
	{
	}

	public int GetTabsCount()
	{
		return 0;
	}

	public TabToolbarButton GetTab(int index)
	{
		return null;
	}
}
