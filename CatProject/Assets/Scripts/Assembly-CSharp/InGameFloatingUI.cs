using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;

public class InGameFloatingUI : MonoBehaviour, IFloatingUI
{
	[CompilerGenerated]
	private sealed class _003CWaitOneFrame_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action Callback;

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
		public _003CWaitOneFrame_003Ed__14(int _003C_003E1__state)
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
	protected Animator Ani;

	[SerializeField]
	protected bool TrackingPos;

	[SerializeField]
	protected Vector3 TrackingOffset;

	protected Transform FollowTrans;

	protected bool isHide;

	[HideInInspector]
	public bool isWorld;

	[HideInInspector]
	public GameType modetype;

	[HideInInspector]
	public int floor;

	public virtual void Init(Transform parent, GameType type = GameType.Main)
	{
	}

	public virtual void UpdatePos()
	{
	}

	public void SetFloor(int Floor)
	{
	}

	public void SetTrackingPos(bool bTrackingPos)
	{
	}

	protected virtual void Update()
	{
	}

	public virtual void Show()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitOneFrame_003Ed__14))]
	private IEnumerator WaitOneFrame(Action Callback)
	{
		yield break;
	}

	public virtual GameType GetGameType()
	{
		return default(GameType);
	}

	public virtual void Hide()
	{
	}

	public void SetFollowOffset(Vector3 offset)
	{
	}
}
