using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;

[UIPath("UI/Guide/GuideOffice2", false, false)]
public class GuideOffice2 : UIBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public GuideOffice2 _003C_003E4__this;

		public PopupCompanyList popup;

		public Action _003C_003E9__7;

		internal void _003CStartGuide_003Eb__2()
		{
		}

		internal void _003CStartGuide_003Eb__3()
		{
		}

		internal void _003CStartGuide_003Eb__7()
		{
		}

		internal bool _003CStartGuide_003Eb__4()
		{
			return false;
		}

		internal bool _003CStartGuide_003Eb__5()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartGuide_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GuideOffice2 _003C_003E4__this;

		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

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
		public _003CStartGuide_003Ed__10(int _003C_003E1__state)
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
	private sealed class _003CWaitButton_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CWaitButton_003Ed__11(int _003C_003E1__state)
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

	private Coroutine coroutine;

	private bool isClicked;

	[IteratorStateMachine(typeof(_003CStartGuide_003Ed__10))]
	public IEnumerator StartGuide()
	{
		yield break;
	}

	[IteratorStateMachine(typeof(_003CWaitButton_003Ed__11))]
	private IEnumerator WaitButton(Action cb)
	{
		yield break;
	}

	protected override void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void UpdateItemGuide()
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

	private void Next()
	{
	}
}
