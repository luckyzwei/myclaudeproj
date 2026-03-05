using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InGameWorldmap : OutGameMode
{
	[CompilerGenerated]
	private sealed class _003CDelayLoadEnd_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CDelayLoadEnd_003Ed__3(int _003C_003E1__state)
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
	private sealed class _003CWaitRegion_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameWorldmap _003C_003E4__this;

		public Action waitCb;

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
		public _003CWaitRegion_003Ed__8(int _003C_003E1__state)
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
	private Transform Root;

	[HideInInspector]
	public InGameWorldmapRegion Region;

	public override void Load()
	{
		base.Load();
		Type = GameType.WorldMap;
		StartCoroutine(DelayLoadEnd());
	}

	[IteratorStateMachine(typeof(_003CDelayLoadEnd_003Ed__3))]
	private IEnumerator DelayLoadEnd()
	{
		yield return null;
		// Delay one frame to allow all world objects to initialize
	}

	public void AddRegionWorld(int region_idx, Action Cb)
	{
		if (Region != null)
		{
			Region.Init(region_idx);
			Cb?.Invoke();
		}
	}

	public void FocusToZone(int zone, bool showArrow = false)
	{
		if (Region != null)
		{
			Region.FocusCamera(zone);
			if (showArrow)
				Region.ShowArrow(zone);
		}
	}

	public void SetGuideStage(int stage)
	{
		if (Region != null)
			Region.FocusCamera(stage);
	}

	public void WaitRegionCb(Action Cb)
	{
		if (Region != null)
			Cb?.Invoke();
		else
			StartCoroutine(WaitRegion(Cb));
	}

	[IteratorStateMachine(typeof(_003CWaitRegion_003Ed__8))]
	private IEnumerator WaitRegion(Action waitCb)
	{
		yield return new WaitUntil(() => Region != null);
		waitCb?.Invoke();
	}

	protected override void LoadUI()
	{
	}

	public override void UnLoad()
	{
		base.UnLoad();
		if (Region != null)
			Destroy(Region.gameObject);
		Region = null;
	}
}
