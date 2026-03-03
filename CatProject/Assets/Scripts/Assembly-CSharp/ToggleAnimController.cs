using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
[RequireComponent(typeof(Animator))]
public class ToggleAnimController : MonoBehaviour
{
	private enum E_TriggerType
	{
		None = 0,
		Normal = 1,
		Selected = 2,
		Disabled = 3
	}

	[CompilerGenerated]
	private sealed class _003CEndFrameUpdate_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ToggleAnimController _003C_003E4__this;

		public bool immediateSet;

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
		public _003CEndFrameUpdate_003Ed__13(int _003C_003E1__state)
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
	private string NormalTrigger;

	[SerializeField]
	private string SelectedTrigger;

	[SerializeField]
	private string DisabledTrigger;

	private Toggle ToggleComponent;

	private Animator AnimatorComponent;

	private E_TriggerType NowTriggerType;

	private Coroutine EndFrameCoroutine;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void RefreshTriggerType()
	{
	}

	private bool CheckAnimTrigger()
	{
		return false;
	}

	private void OnValueChanged(bool isOn, bool immediateSet)
	{
	}

	[IteratorStateMachine(typeof(_003CEndFrameUpdate_003Ed__13))]
	private IEnumerator EndFrameUpdate(bool immediateSet)
	{
		return null;
	}
}
