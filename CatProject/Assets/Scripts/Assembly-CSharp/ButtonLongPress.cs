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
		public _003CStart_003Ed__20(int _003C_003E1__state)
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
	private string LongPressedTrigger;

	[SerializeField]
	private string DisabledTrigger;

	[SerializeField]
	private GameObject LongPressShowFxObj;

	[Tooltip("클릭 이벤트로 판정되는 최대 시간. 이 시간내에 손을 떼면 클릭 이벤트로 판정.")]
	[SerializeField]
	private float PressEventMaxTimeSec;

	[Tooltip("롱 프레스 이벤트가 불리는 시간. 이 시간에 도달해야만 롱 프레스 성공으로 간주.")]
	[SerializeField]
	private float LongPressEventCallTimeSec;

	[Tooltip("롱 프레스 후 클릭시 해제되는 타입")]
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
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__20))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void RefreshState(bool bForceUpdate)
	{
	}

	public void ResetToNormal()
	{
	}

	public bool IsKeepLongPressState()
	{
		return false;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void OnButtonLongPressed()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void ResetPressInfo()
	{
	}
}
