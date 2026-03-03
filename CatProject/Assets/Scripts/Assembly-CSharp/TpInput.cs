using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

[Preserve]
public class TpInput : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CtapClickElementLifeCycle_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject target;

		public bool tap;

		public int count;

		public float interval;

		private Vector3 _003CscreenPosition_003E5__2;

		private PointerEventData _003CpointerEventData_003E5__3;

		private int _003Ci_003E5__4;

		private float _003Ctime_003E5__5;

		private float _003CelapsedTime_003E5__6;

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
		public _003CtapClickElementLifeCycle_003Ed__1(int _003C_003E1__state)
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

	private static Touch createTouch(Vector3 screenPosition)
	{
		return default(Touch);
	}

	[IteratorStateMachine(typeof(_003CtapClickElementLifeCycle_003Ed__1))]
	internal static IEnumerator tapClickElementLifeCycle(GameObject target, int count, float interval, bool tap)
	{
		return null;
	}
}
