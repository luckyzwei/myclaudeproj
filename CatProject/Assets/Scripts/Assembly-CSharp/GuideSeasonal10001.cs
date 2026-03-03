using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;

[UIPath("UI/Guide/GuideSeasonal10001", false, false)]
public class GuideSeasonal10001 : UIBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public GuideSeasonal10001 _003C_003E4__this;

		public int targetBuildingIdx;

		public SeasonalBuildingFacilityData facilityData;

		internal void _003CStartGuide_003Eb__0()
		{
		}

		internal void _003CStartGuide_003Eb__1()
		{
		}

		internal bool _003CStartGuide_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartGuide_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GuideSeasonal10001 _003C_003E4__this;

		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

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
		public _003CStartGuide_003Ed__9(int _003C_003E1__state)
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
	private sealed class _003CWaitPopup_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action cb;

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
		public _003CWaitPopup_003Ed__10(int _003C_003E1__state)
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
	private RectTransform clickObj;

	private List<Action> guideActions;

	private int curActionIdx;

	private Transform followTrans;

	private bool bWait;

	private bool clickObjActive;

	private GameObject target;

	private Rect ClickAble;

	private CompositeDisposable disposables;

	private bool isClicked;

	[IteratorStateMachine(typeof(_003CStartGuide_003Ed__9))]
	public IEnumerator StartGuide()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitPopup_003Ed__10))]
	private IEnumerator WaitPopup(Action cb)
	{
		return null;
	}

	protected override void OnEnable()
	{
	}

	private void Clear()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}
}
