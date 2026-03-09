using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(GraphicRaycaster))]
[RequireComponent(typeof(NonDrawingGraphic))]
[RequireComponent(typeof(Canvas))]
public class InputBlocker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowSpinnerAfterDelay_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InputBlocker _003C_003E4__this;

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
		public _003CShowSpinnerAfterDelay_003Ed__6(int _003C_003E1__state)
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
	private GameObject m_spinner;

	[SerializeField]
	private float m_showSpinnerDelay;

	private Coroutine m_showSpinnerRoutine;

	private const string PREFAB_LOCATION = "InputBlocker";

	private static int s_stackCount;

	private static InputBlocker m_reference;

	private void Initialize(bool showSpinner)
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CShowSpinnerAfterDelay_003Ed__6))]
	private IEnumerator ShowSpinnerAfterDelay()
	{
		return null;
	}

	public static void Register(bool showSpinner = true)
	{
	}

	public static void Unregister()
	{
	}
}
