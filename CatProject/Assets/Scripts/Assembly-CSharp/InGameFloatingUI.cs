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
			get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CWaitOneFrame_003Ed__14(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					Callback?.Invoke();
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
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
		FollowTrans = parent;
		modetype = type;
		isHide = false;
	}

	public virtual void UpdatePos()
	{
		if (!TrackingPos || FollowTrans == null) return;
		transform.position = FollowTrans.position + TrackingOffset;
	}

	public void SetFloor(int Floor)
	{
		floor = Floor;
	}

	public void SetTrackingPos(bool bTrackingPos)
	{
		TrackingPos = bTrackingPos;
	}

	protected virtual void Update()
	{
		if (TrackingPos)
			UpdatePos();
	}

	public virtual void Show()
	{
		isHide = false;
		gameObject.SetActive(true);
		if (Ani != null)
			Ani.SetTrigger("Show");
	}

	[IteratorStateMachine(typeof(_003CWaitOneFrame_003Ed__14))]
	private IEnumerator WaitOneFrame(Action Callback)
	{
		yield return null;
		Callback?.Invoke();
	}

	public virtual GameType GetGameType()
	{
		return modetype;
	}

	public virtual void Hide()
	{
		isHide = true;
		if (Ani != null)
			Ani.SetTrigger("Hide");
		else
			gameObject.SetActive(false);
	}

	public void SetFollowOffset(Vector3 offset)
	{
		TrackingOffset = offset;
	}
}
