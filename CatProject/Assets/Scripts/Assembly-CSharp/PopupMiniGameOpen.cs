using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupMiniGameOpen", false, false)]
public class PopupMiniGameOpen : UIBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public HUDTotal hud;

		internal void _003CPlayMiniGameOpenEffect_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlayMiniGameOpenEffect_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

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
		public _003CPlayMiniGameOpenEffect_003Ed__8(int _003C_003E1__state)
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
	private Text TitleText;

	[SerializeField]
	private Text DescText;

	[SerializeField]
	private Image MainImage;

	[SerializeField]
	private Text RemainTimeText;

	private CompositeDisposable Disposables;

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	private void SetTimeText()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayMiniGameOpenEffect_003Ed__8))]
	public IEnumerator PlayMiniGameOpenEffect()
	{
		return null;
	}

	public override void OnHideAfter()
	{
	}
}
