using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonLongPress : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ButtonLongPress _003C_003E4__this;

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
		public _003CStart_003Ed__20(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
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
	private string PressedTrigger;

	[SerializeField]
	private string LongPressedTrigger;

	[SerializeField]
	private string DisabledTrigger;

	[SerializeField]
	private GameObject LongPressShowFxObj;

	[SerializeField]
	private float PressEventMaxTimeSec;

	[SerializeField]
	private float LongPressEventCallTimeSec;

	[SerializeField]
	private bool ToggleLongPressType;

	private bool interactable;

	private Animator animator;

	private bool bPressed;

	private float PressElapsedTimeSec;

	private bool bStartLongPress;

	private bool bKeepLongPress;

	public Action OnPressed;

	public Action OnLongPressed;

	public bool Interactable
	{
		get { return interactable; }
		set
		{
			interactable = value;
			RefreshState(true);
		}
	}

	private void Awake()
	{
		animator = GetComponent<Animator>();
		interactable = true;
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__20))]
	private IEnumerator Start()
	{
		yield break;
	}

	private void OnEnable()
	{
		ResetPressInfo();
	}

	private void RefreshState(bool bForceUpdate)
	{
		if (animator == null) return;
		if (!interactable)
		{
			if (!string.IsNullOrEmpty(DisabledTrigger))
				animator.SetTrigger(DisabledTrigger);
		}
		else if (bKeepLongPress)
		{
			if (!string.IsNullOrEmpty(LongPressedTrigger))
				animator.SetTrigger(LongPressedTrigger);
		}
		else
		{
			if (!string.IsNullOrEmpty(NormalTrigger))
				animator.SetTrigger(NormalTrigger);
		}
	}

	public void ResetToNormal()
	{
		bKeepLongPress = false;
		RefreshState(true);
	}

	public bool IsKeepLongPressState()
	{
		return bKeepLongPress;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (!interactable) return;
		bPressed = true;
		PressElapsedTimeSec = 0f;
		bStartLongPress = false;
		if (animator != null && !string.IsNullOrEmpty(PressedTrigger))
			animator.SetTrigger(PressedTrigger);
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		if (!interactable) return;
		if (bPressed)
		{
			if (PressElapsedTimeSec < PressEventMaxTimeSec)
			{
				if (ToggleLongPressType && bKeepLongPress)
				{
					bKeepLongPress = false;
					RefreshState(false);
				}
				else
				{
					OnPressed?.Invoke();
				}
			}
		}
		ResetPressInfo();
		RefreshState(false);
	}

	private void OnButtonLongPressed()
	{
		bKeepLongPress = true;
		if (LongPressShowFxObj != null)
			LongPressShowFxObj.SetActive(true);
		OnLongPressed?.Invoke();
		RefreshState(false);
	}

	private void OnDisable()
	{
		ResetPressInfo();
	}

	private void Update()
	{
		if (!bPressed) return;
		PressElapsedTimeSec += Time.deltaTime;
		if (!bStartLongPress && PressElapsedTimeSec >= LongPressEventCallTimeSec)
		{
			bStartLongPress = true;
			OnButtonLongPressed();
		}
	}

	private void ResetPressInfo()
	{
		bPressed = false;
		PressElapsedTimeSec = 0f;
		bStartLongPress = false;
		if (LongPressShowFxObj != null)
			LongPressShowFxObj.SetActive(false);
	}
}
