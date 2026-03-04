using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SliderTextComponent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateSliderValue_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SliderTextComponent _003C_003E4__this;

		public E_AnimationType animationType;

		public float startValue;

		public float targetValue;

		private float _003CelapsedTime_003E5__2;

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
		public _003CAnimateSliderValue_003Ed__16(int _003C_003E1__state)
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
	private Slider GaugeSlider;

	[SerializeField]
	private Text GaugeValueText;

	[SerializeField]
	private ProgressText GaugeValueProgressText;

	[Header("애니메이션 타입 - 값이 늘어날 때 애니메이션")]
	[SerializeField]
	private E_AnimationType IncreaseAnimationType;

	[Header("애니메이션 타입 - 값이 줄어들 때 애니메이션")]
	[SerializeField]
	private E_AnimationType DecreaseAnimationType;

	[Header("애니메이션 플레이 시간")]
	[SerializeField]
	private float AnimationDuration;

	private Coroutine CurrentAnimationCoroutine;

	private float PlaySpeed;

	public Action OnAnimationEndEvent;

	public void SetValue<T>(T initValue, T maxValue, bool isForceSet = false)
	{
	}

	public void SetValueFrontOnly<T>(T initValue, T maxValue, bool isForceSet = false)
	{
	}

	public void SetPlaySpeed(float speed)
	{
	}

	public bool IsFull()
	{
		return false;
	}

	public float GetAnimationDuration()
	{
		return 0f;
	}

	private void SetGaugeSlider<T>(T curValue, T maxValue)
	{
	}

	private void SetGaugeSliderWithSmartAnimation<T>(T curValue, T maxValue)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateSliderValue_003Ed__16))]
	private IEnumerator AnimateSliderValue(float startValue, float targetValue, E_AnimationType animationType)
	{
		yield break;
	}

	private float GetEasedProgress(float progress, E_AnimationType animationType)
	{
		return 0f;
	}

	private float GetLinearProgress(float t)
	{
		return 0f;
	}

	private float GetEaseInProgress(float t)
	{
		return 0f;
	}

	private float GetEaseOutProgress(float t)
	{
		return 0f;
	}

	private float GetEaseInOutProgress(float t)
	{
		return 0f;
	}

	private float GetBounceProgress(float t)
	{
		return 0f;
	}

	private float GetElasticProgress(float t)
	{
		return 0f;
	}

	private void StopCurrentAnimation()
	{
	}

	private void SetGaugeValue<T>(T curValue, T maxValue)
	{
	}

	private void SetGaugeValue<T>(T value)
	{
	}

	private void OnDisable()
	{
	}
}
