using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Treeplla;
using UnityEngine;

public class HUDBaseSeasonal : HUDAniBase, IHUDTopInfo, IScreenAction
{
	[CompilerGenerated]
	private sealed class _003CWaitComebackCo_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDBaseSeasonal _003C_003E4__this;

		public bool value;

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
		public _003CWaitComebackCo_003Ed__24(int _003C_003E1__state)
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

	[Header("[HUDBase]")]
	[SerializeField]
	protected HUDTopInfo CurrencyHud;

	[SerializeField]
	private List<RectTransform> LeftRoot;

	[SerializeField]
	private List<RectTransform> RightRoot;

	private HUDType[] aniType;

	private bool appear;

	private bool screenAction;

	private List<float> originLeftPos;

	private List<float> originRightPos;

	private Coroutine ScreenActionCo;

	private List<Tween> ScreenActionTweens;

	public HUDType[] HudType => null;

	public bool IsAppear => false;

	public bool IsScreenAction => false;

	public WaitUntil WaitHUDAppear { get; set; }

	protected override void Awake()
	{
	}

	private void initRootOrigin()
	{
	}

	public Vector3 GetHUDWorldPos(Config.CurrencyID type)
	{
		return default(Vector3);
	}

	public HUDTopInfo GetHUDTopInfo()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitComebackCo_003Ed__24))]
	private IEnumerator WaitComebackCo(bool value)
	{
		return null;
	}

	public void ScreenAction(bool value)
	{
	}

	public void ScreenTopOn(bool value)
	{
	}

	public bool IsScreenTopOn()
	{
		return false;
	}

	private void ShowRootObject(List<RectTransform> rootObjects, List<float> moveXPos)
	{
	}

	private void HideRootObjects(List<RectTransform> rootObjects, float moveXPos)
	{
	}
}
