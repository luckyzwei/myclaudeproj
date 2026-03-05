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
		SetGaugeValue(initValue, maxValue);
		if (isForceSet)
			SetGaugeSlider(initValue, maxValue);
		else
			SetGaugeSliderWithSmartAnimation(initValue, maxValue);
	}

	public void SetValueFrontOnly<T>(T initValue, T maxValue, bool isForceSet = false)
	{
		if (isForceSet)
			SetGaugeSlider(initValue, maxValue);
		else
			SetGaugeSliderWithSmartAnimation(initValue, maxValue);
	}

	public void SetPlaySpeed(float speed)
	{
		PlaySpeed = speed;
	}

	public bool IsFull()
	{
		return GaugeSlider != null && GaugeSlider.value >= 1f;
	}

	public float GetAnimationDuration()
	{
		return AnimationDuration;
	}

	private void SetGaugeSlider<T>(T curValue, T maxValue)
	{
		if (GaugeSlider == null) return;
		float cur = System.Convert.ToSingle(curValue);
		float max = System.Convert.ToSingle(maxValue);
		GaugeSlider.value = max > 0f ? Mathf.Clamp01(cur / max) : 0f;
	}

	private void SetGaugeSliderWithSmartAnimation<T>(T curValue, T maxValue)
	{
		if (GaugeSlider == null) return;
		float cur = System.Convert.ToSingle(curValue);
		float max = System.Convert.ToSingle(maxValue);
		float targetValue = max > 0f ? Mathf.Clamp01(cur / max) : 0f;
		float startValue = GaugeSlider.value;
		E_AnimationType animType = targetValue > startValue ? IncreaseAnimationType : DecreaseAnimationType;
		if (animType == E_AnimationType.None)
		{
			GaugeSlider.value = targetValue;
			return;
		}
		StopCurrentAnimation();
		CurrentAnimationCoroutine = StartCoroutine(AnimateSliderValue(startValue, targetValue, animType));
	}

	[IteratorStateMachine(typeof(_003CAnimateSliderValue_003Ed__16))]
	private IEnumerator AnimateSliderValue(float startValue, float targetValue, E_AnimationType animationType)
	{
		float elapsedTime = 0f;
		float duration = AnimationDuration > 0f ? AnimationDuration : 0.3f;
		float speed = PlaySpeed > 0f ? PlaySpeed : 1f;
		while (elapsedTime < duration)
		{
			elapsedTime += Time.deltaTime * speed;
			float t = Mathf.Clamp01(elapsedTime / duration);
			float easedT = GetEasedProgress(t, animationType);
			if (GaugeSlider != null)
				GaugeSlider.value = Mathf.Lerp(startValue, targetValue, easedT);
			yield return null;
		}
		if (GaugeSlider != null)
			GaugeSlider.value = targetValue;
		CurrentAnimationCoroutine = null;
		OnAnimationEndEvent?.Invoke();
	}

	private float GetEasedProgress(float progress, E_AnimationType animationType)
	{
		switch (animationType)
		{
			case E_AnimationType.Linear: return GetLinearProgress(progress);
			case E_AnimationType.EaseIn: return GetEaseInProgress(progress);
			case E_AnimationType.EaseOut: return GetEaseOutProgress(progress);
			case E_AnimationType.EaseInOut: return GetEaseInOutProgress(progress);
			case E_AnimationType.Bounce: return GetBounceProgress(progress);
			case E_AnimationType.Elastic: return GetElasticProgress(progress);
			default: return progress;
		}
	}

	private float GetLinearProgress(float t)
	{
		return t;
	}

	private float GetEaseInProgress(float t)
	{
		return t * t;
	}

	private float GetEaseOutProgress(float t)
	{
		return 1f - (1f - t) * (1f - t);
	}

	private float GetEaseInOutProgress(float t)
	{
		return t < 0.5f ? 2f * t * t : 1f - Mathf.Pow(-2f * t + 2f, 2f) / 2f;
	}

	private float GetBounceProgress(float t)
	{
		if (t < 1f / 2.75f) return 7.5625f * t * t;
		if (t < 2f / 2.75f) { t -= 1.5f / 2.75f; return 7.5625f * t * t + 0.75f; }
		if (t < 2.5f / 2.75f) { t -= 2.25f / 2.75f; return 7.5625f * t * t + 0.9375f; }
		t -= 2.625f / 2.75f;
		return 7.5625f * t * t + 0.984375f;
	}

	private float GetElasticProgress(float t)
	{
		if (t <= 0f) return 0f;
		if (t >= 1f) return 1f;
		return Mathf.Pow(2f, -10f * t) * Mathf.Sin((t - 0.075f) * (2f * Mathf.PI) / 0.3f) + 1f;
	}

	private void StopCurrentAnimation()
	{
		if (CurrentAnimationCoroutine != null)
		{
			StopCoroutine(CurrentAnimationCoroutine);
			CurrentAnimationCoroutine = null;
		}
	}

	private void SetGaugeValue<T>(T curValue, T maxValue)
	{
		if (GaugeValueText != null)
			GaugeValueText.text = curValue.ToString() + "/" + maxValue.ToString();
	}

	private void SetGaugeValue<T>(T value)
	{
		if (GaugeValueText != null)
			GaugeValueText.text = value.ToString();
	}

	private void OnDisable()
	{
		StopCurrentAnimation();
	}
}
