using System;
using KWCore;
using KWGameCore;
using UnityEngine;
using UnityEngine.UI;

public static class AutoExtensionsCore
{
	public static Coroutine AutoMoveTo(this Transform transform, Vector3 origin, Vector3 target, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(origin, target, duration, v => { if (transform != null) { transform.position = v; onValueChanged?.Invoke(v); } }, type, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoMoveTo(this Transform transform, Vector3 origin, Vector3 target, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(origin, target, duration, v => { if (transform != null) { transform.position = v; onValueChanged?.Invoke(v); } }, curve, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoMoveToLocal(this Transform transform, Vector3 origin, Vector3 target, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(origin, target, duration, v => { if (transform != null) { transform.localPosition = v; onValueChanged?.Invoke(v); } }, type, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoMoveToLocal(this Transform transform, Vector3 origin, Vector3 target, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(origin, target, duration, v => { if (transform != null) { transform.localPosition = v; onValueChanged?.Invoke(v); } }, curve, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoScaleTo(this Transform transform, Vector3 startScale, Vector3 endScale, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(startScale, endScale, duration, v => { if (transform != null) { transform.localScale = v; onValueChanged?.Invoke(v); } }, type, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoScaleTo(this Transform transform, Vector3 startScale, Vector3 endScale, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(startScale, endScale, duration, v => { if (transform != null) { transform.localScale = v; onValueChanged?.Invoke(v); } }, curve, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoRotate(this Transform transform, Vector3 targetRot, float rotationSpeed, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool unscaledTime = false)
	{
		Vector3 startRot = transform != null ? transform.eulerAngles : Vector3.zero;
		float duration = rotationSpeed > 0 ? Vector3.Distance(startRot, targetRot) / rotationSpeed : 0f;
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(startRot, targetRot, duration, v => { if (transform != null) { transform.eulerAngles = v; onValueChanged?.Invoke(v); } }, type, finishedCallback, true, unscaledTime));
	}

	public static Coroutine AutoRotate(this Transform transform, Vector3 targetRot, float rotationSpeed, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool unscaledTime = false)
	{
		Vector3 startRot = transform != null ? transform.eulerAngles : Vector3.zero;
		float duration = rotationSpeed > 0 ? Vector3.Distance(startRot, targetRot) / rotationSpeed : 0f;
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(startRot, targetRot, duration, v => { if (transform != null) { transform.eulerAngles = v; onValueChanged?.Invoke(v); } }, curve, finishedCallback, true, unscaledTime));
	}

	public static Coroutine AutoRotateTo(this Transform transform, Vector3 targetRot, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		Vector3 startRot = transform != null ? transform.eulerAngles : Vector3.zero;
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(startRot, targetRot, duration, v => { if (transform != null) { transform.eulerAngles = v; onValueChanged?.Invoke(v); } }, type, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoRotateTo(this Transform transform, Vector3 targetRot, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		Vector3 startRot = transform != null ? transform.eulerAngles : Vector3.zero;
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(startRot, targetRot, duration, v => { if (transform != null) { transform.eulerAngles = v; onValueChanged?.Invoke(v); } }, curve, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoRotateToLocal(this Transform transform, Vector3 targetRot, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		Vector3 startRot = transform != null ? transform.localEulerAngles : Vector3.zero;
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(startRot, targetRot, duration, v => { if (transform != null) { transform.localEulerAngles = v; onValueChanged?.Invoke(v); } }, type, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoRotateToLocal(this Transform transform, Vector3 targetRot, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		Vector3 startRot = transform != null ? transform.localEulerAngles : Vector3.zero;
		return CoroutineRunner.Run(CoroutineUtils.LerpVector(startRot, targetRot, duration, v => { if (transform != null) { transform.localEulerAngles = v; onValueChanged?.Invoke(v); } }, curve, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpColourTo(this Graphic graphic, Color startColour, Color endColour, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpGraphicColour(graphic, startColour, endColour, duration, type, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpColourTo(this Graphic graphic, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpGraphicColour(graphic, startColour, endColour, duration, curve, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpColourTo(this SpriteRenderer sprite, Color startColour, Color endColour, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpSpriteColour(sprite, startColour, endColour, duration, type, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpColourTo(this SpriteRenderer sprite, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpSpriteColour(sprite, startColour, endColour, duration, curve, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpColourTo(this Material material, Color startColour, Color endColour, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpMaterialColour(material, startColour, endColour, duration, type, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpColourTo(this Material material, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpMaterialColour(material, startColour, endColour, duration, curve, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpColourTo(this Renderer renderer, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpRendererColour(renderer, startColour, endColour, duration, curve, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpColourTo(this Renderer renderer, Color startColour, Color endColour, float duration, KWEase.Type type, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpRendererColour(renderer, startColour, endColour, duration, type, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpAlphaTo(this Graphic graphic, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpAlpha(graphic, startAlpha, endAlpha, duration, type, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpAlphaTo(this Graphic graphic, float startAlpha, float endAlpha, float duration, AnimationCurve curve, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpAlpha(graphic, startAlpha, endAlpha, duration, curve, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpAlphaTo(this Material material, float startAlpha, float endAlpha, float duration, AnimationCurve curve = null, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpAlpha(material, startAlpha, endAlpha, duration, curve, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpAlphaTo(this Material material, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpAlpha(material, startAlpha, endAlpha, duration, type, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpAlphaTo(this Renderer renderer, float startAlpha, float endAlpha, float duration, AnimationCurve curve = null, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpAlpha(renderer, startAlpha, endAlpha, duration, curve, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpAlphaTo(this Renderer renderer, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpAlpha(renderer, startAlpha, endAlpha, duration, type, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpAlphaTo(this CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpAlpha(canvasGroup, startAlpha, endAlpha, duration, type, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpAlphaTo(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration, AnimationCurve curve = null, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpAlpha(canvasGroup, startAlpha, endAlpha, duration, curve, onValueChanged, finishedCallback, clamp, unscaledTime));
	}

	public static Coroutine AutoLerpTo(this float startValue, float endValue, float duration, Action<float> valueChangedCallback, Action finishedCallback = null, KWEase.Type type = KWEase.Type.LINEAR, bool clamp = true)
	{
		return CoroutineRunner.Run(CoroutineUtils.LerpFloat(startValue, endValue, duration, valueChangedCallback, finishedCallback, type, clamp));
	}
}
