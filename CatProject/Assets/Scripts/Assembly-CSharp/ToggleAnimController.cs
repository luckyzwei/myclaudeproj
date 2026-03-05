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
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CEndFrameUpdate_003Ed__13(int _003C_003E1__state)
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
					if (!immediateSet)
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
					goto case 1;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E4__this.RefreshTriggerType();
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
		ToggleComponent = GetComponent<Toggle>();
		AnimatorComponent = GetComponent<Animator>();
		if (ToggleComponent != null)
			ToggleComponent.onValueChanged.AddListener((isOn) => OnValueChanged(isOn, false));
	}

	private void OnEnable()
	{
		OnValueChanged(ToggleComponent != null && ToggleComponent.isOn, true);
	}

	private void RefreshTriggerType()
	{
		if (AnimatorComponent == null) return;
		if (!CheckAnimTrigger()) return;

		E_TriggerType targetType;
		if (ToggleComponent != null && !ToggleComponent.interactable)
			targetType = E_TriggerType.Disabled;
		else if (ToggleComponent != null && ToggleComponent.isOn)
			targetType = E_TriggerType.Selected;
		else
			targetType = E_TriggerType.Normal;

		if (NowTriggerType == targetType) return;
		NowTriggerType = targetType;

		switch (targetType)
		{
			case E_TriggerType.Normal:
				if (!string.IsNullOrEmpty(NormalTrigger))
					AnimatorComponent.SetTrigger(NormalTrigger);
				break;
			case E_TriggerType.Selected:
				if (!string.IsNullOrEmpty(SelectedTrigger))
					AnimatorComponent.SetTrigger(SelectedTrigger);
				break;
			case E_TriggerType.Disabled:
				if (!string.IsNullOrEmpty(DisabledTrigger))
					AnimatorComponent.SetTrigger(DisabledTrigger);
				break;
		}
	}

	private bool CheckAnimTrigger()
	{
		return AnimatorComponent != null && AnimatorComponent.isActiveAndEnabled && AnimatorComponent.runtimeAnimatorController != null;
	}

	private void OnValueChanged(bool isOn, bool immediateSet)
	{
		if (EndFrameCoroutine != null)
			StopCoroutine(EndFrameCoroutine);
		EndFrameCoroutine = StartCoroutine(EndFrameUpdate(immediateSet));
	}

	[IteratorStateMachine(typeof(_003CEndFrameUpdate_003Ed__13))]
	private IEnumerator EndFrameUpdate(bool immediateSet)
	{
		var d = new _003CEndFrameUpdate_003Ed__13(0);
		d._003C_003E4__this = this;
		d.immediateSet = immediateSet;
		return d;
	}
}
