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
		public _003CStart_003Ed__23(int _003C_003E1__state)
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
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int pressedCnt { get; private set; }

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__23))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void RefreshState()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void OnDisable()
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnCancel()
	{
	}

	private void Update()
	{
	}
}
