using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressed : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ButtonPressed _003C_003E4__this;

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
		public _003CStart_003Ed__23(int _003C_003E1__state)
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
	private string DisabledTrigger;

	private bool interactable;

	public float click_interval;

	public float click_interval_fast;

	public int fastPressCnt;

	[Header("Sound")]
	[SerializeField]
	protected string PressedSoundKey;

	private bool pressed;

	private float deltaTime;

	public Action OnPressed;

	public Action OnReleased;

	public bool UseLongPressed;

	public bool keepPressWhenDisabled;

	private Animator animator;

	public bool Interactable
	{
		get { return interactable; }
		set
		{
			interactable = value;
			RefreshState();
		}
	}

	public int pressedCnt { get; private set; }

	private void Awake()
	{
		animator = GetComponent<Animator>();
		interactable = true;
		pressedCnt = 0;
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__23))]
	private IEnumerator Start()
	{
		yield break;
	}

	private void OnEnable()
	{
		pressed = false;
		deltaTime = 0f;
		pressedCnt = 0;
	}

	private void RefreshState()
	{
		if (animator == null) return;
		if (!interactable)
		{
			if (!string.IsNullOrEmpty(DisabledTrigger))
				animator.SetTrigger(DisabledTrigger);
		}
		else
		{
			if (!string.IsNullOrEmpty(NormalTrigger))
				animator.SetTrigger(NormalTrigger);
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (!interactable) return;
		pressed = true;
		deltaTime = 0f;
		if (animator != null && !string.IsNullOrEmpty(PressedTrigger))
			animator.SetTrigger(PressedTrigger);
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		if (!interactable && !keepPressWhenDisabled) return;
		if (pressed)
		{
			pressedCnt++;
			OnPressed?.Invoke();
		}
		pressed = false;
		OnReleased?.Invoke();
		RefreshState();
	}

	private void OnDisable()
	{
		pressed = false;
		deltaTime = 0f;
	}

	public void OnDrag(PointerEventData eventData)
	{
		// TODO
	}

	public void OnCancel()
	{
		pressed = false;
		OnReleased?.Invoke();
		RefreshState();
	}

	private void Update()
	{
		if (!pressed || !UseLongPressed) return;
		deltaTime += Time.deltaTime;
		float interval = pressedCnt >= fastPressCnt ? click_interval_fast : click_interval;
		if (deltaTime >= interval)
		{
			deltaTime = 0f;
			pressedCnt++;
			OnPressed?.Invoke();
		}
	}
}
