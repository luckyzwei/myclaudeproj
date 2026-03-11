using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace KWGameCore
{
	public static class CoroutineUtils
	{
		public static IEnumerator Delay(float delayInSeconds, Action finishedCallback)
		{
			yield return new WaitForSeconds(delayInSeconds);
			finishedCallback?.Invoke();
		}

		public static IEnumerator DelayRealtime(float delayInSeconds, Action finishedCallback)
		{
			yield return new WaitForSecondsRealtime(delayInSeconds);
			finishedCallback?.Invoke();
		}

		public static IEnumerator WaitFrames(int frames, Action finishedCallback)
		{
			for (int i = 0; i < frames; i++)
			{
				yield return null;
			}
			finishedCallback?.Invoke();
		}

		public static IEnumerator WaitForEndOfFrame(Action finishedCallback)
		{
			yield return new WaitForEndOfFrame();
			finishedCallback?.Invoke();
		}

		public static IEnumerator MoveTo(Transform transform, Vector3 origin, Vector3 target, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return MoveToInternal(false, transform, origin, target, duration, KWEase.GetEase(type), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator MoveTo(Transform transform, Vector3 origin, Vector3 target, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return MoveToInternal(false, transform, origin, target, duration, KWEase.GetEase(curve), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator MoveToLocal(Transform transform, Vector3 origin, Vector3 target, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return MoveToInternal(true, transform, origin, target, duration, KWEase.GetEase(type), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator MoveToLocal(Transform transform, Vector3 origin, Vector3 target, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return MoveToInternal(true, transform, origin, target, duration, KWEase.GetEase(curve), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		private static IEnumerator MoveToInternal(bool isLocal, Transform transform, Vector3 origin, Vector3 target, float duration, KWEase.EaseFunction function, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				Vector3 value = Vector3.LerpUnclamped(origin, target, eased);
				if (isLocal)
					transform.localPosition = value;
				else
					transform.position = value;
				onValueChanged?.Invoke(value);
				yield return null;
			}
			if (isLocal)
				transform.localPosition = target;
			else
				transform.position = target;
			onValueChanged?.Invoke(target);
			finishedCallback?.Invoke();
		}

		public static IEnumerator ScaleTo(Transform transform, Vector3 startScale, Vector3 endScale, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return ScaleToInternal(transform, startScale, endScale, duration, KWEase.GetEase(type), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator ScaleTo(Transform transform, Vector3 startScale, Vector3 endScale, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return ScaleToInternal(transform, startScale, endScale, duration, KWEase.GetEase(curve), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		private static IEnumerator ScaleToInternal(Transform transform, Vector3 startScale, Vector3 endScale, float duration, KWEase.EaseFunction function, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				Vector3 value = Vector3.LerpUnclamped(startScale, endScale, eased);
				transform.localScale = value;
				onValueChanged?.Invoke(value);
				yield return null;
			}
			transform.localScale = endScale;
			onValueChanged?.Invoke(endScale);
			finishedCallback?.Invoke();
		}

		public static IEnumerator Rotate(Transform transform, Vector3 targetRot, float rotationSpeed, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool unscaledTime = false)
		{
			return RotateInternal(transform, targetRot, rotationSpeed, KWEase.GetEase(type), onValueChanged, finishedCallback, unscaledTime);
		}

		public static IEnumerator Rotate(Transform transform, Vector3 targetRot, float rotationSpeed, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool unscaledTime = false)
		{
			return RotateInternal(transform, targetRot, rotationSpeed, KWEase.GetEase(curve), onValueChanged, finishedCallback, unscaledTime);
		}

		private static IEnumerator RotateInternal(Transform transform, Vector3 targetRot, float rotationSpeed, KWEase.EaseFunction function, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool unscaledTime = false)
		{
			Quaternion startRotation = transform.rotation;
			Quaternion endRotation = Quaternion.Euler(targetRot);
			float angle = Quaternion.Angle(startRotation, endRotation);
			float duration = angle / rotationSpeed;
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = Mathf.Clamp01(elapsed / duration);
				float eased = function != null ? function(t) : t;
				transform.rotation = Quaternion.LerpUnclamped(startRotation, endRotation, eased);
				onValueChanged?.Invoke(transform.eulerAngles);
				yield return null;
			}
			transform.rotation = endRotation;
			onValueChanged?.Invoke(targetRot);
			finishedCallback?.Invoke();
		}

		public static IEnumerator RotateTo(Transform transform, Vector3 targetRot, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return RotateToInternal(false, transform, targetRot, duration, KWEase.GetEase(type), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator RotateTo(Transform transform, Vector3 targetRot, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return RotateToInternal(false, transform, targetRot, duration, KWEase.GetEase(curve), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator RotateToLocal(Transform transform, Vector3 targetRot, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return RotateToInternal(true, transform, targetRot, duration, KWEase.GetEase(type), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator RotateToLocal(Transform transform, Vector3 targetRot, float duration, AnimationCurve curve = null, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return RotateToInternal(true, transform, targetRot, duration, KWEase.GetEase(curve), onValueChanged, finishedCallback, clamp, unscaledTime);
		}

		private static IEnumerator RotateToInternal(bool isLocal, Transform transform, Vector3 targetRot, float duration, KWEase.EaseFunction function, Action<Vector3> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			Vector3 startRot = isLocal ? transform.localEulerAngles : transform.eulerAngles;
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				Vector3 value = Vector3.LerpUnclamped(startRot, targetRot, eased);
				if (isLocal)
					transform.localEulerAngles = value;
				else
					transform.eulerAngles = value;
				onValueChanged?.Invoke(value);
				yield return null;
			}
			if (isLocal)
				transform.localEulerAngles = targetRot;
			else
				transform.eulerAngles = targetRot;
			onValueChanged?.Invoke(targetRot);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpFloat(float startValue, float endValue, float duration, Action<float> valueChangedCallback, Action finishedCallback = null, KWEase.Type type = KWEase.Type.LINEAR, bool clamp = true, bool unscaledTime = false)
		{
			return LerpFloatInternal(startValue, endValue, duration, KWEase.GetEase(type), valueChangedCallback, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpFloat(float startValue, float endValue, float duration, Action<float> valueChangedCallback, Action finishedCallback = null, AnimationCurve curve = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpFloatInternal(startValue, endValue, duration, KWEase.GetEase(curve), valueChangedCallback, finishedCallback, clamp, unscaledTime);
		}

		private static IEnumerator LerpFloatInternal(float startValue, float endValue, float duration, KWEase.EaseFunction function, Action<float> valueChangedCallback, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				float value = Mathf.LerpUnclamped(startValue, endValue, eased);
				valueChangedCallback?.Invoke(value);
				yield return null;
			}
			valueChangedCallback?.Invoke(endValue);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpVector(Vector3 startValue, Vector3 endValue, float duration, Action<Vector3> valueChangedCallback, KWEase.Type type = KWEase.Type.LINEAR, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpVectorInternal(startValue, endValue, duration, KWEase.GetEase(type), valueChangedCallback, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpVector(Vector3 startValue, Vector3 endValue, float duration, Action<Vector3> valueChangedCallback, AnimationCurve curve = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpVectorInternal(startValue, endValue, duration, KWEase.GetEase(curve), valueChangedCallback, finishedCallback, clamp, unscaledTime);
		}

		private static IEnumerator LerpVectorInternal(Vector3 startValue, Vector3 endValue, float duration, KWEase.EaseFunction function, Action<Vector3> valueChangedCallback, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				Vector3 value = Vector3.LerpUnclamped(startValue, endValue, eased);
				valueChangedCallback?.Invoke(value);
				yield return null;
			}
			valueChangedCallback?.Invoke(endValue);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpColour(Color startColour, Color endColour, float duration, Action<Color> valueChangedCallback, KWEase.Type type = KWEase.Type.LINEAR, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(type), valueChangedCallback, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpColour(Color startColour, Color endColour, float duration, Action<Color> valueChangedCallback, AnimationCurve curve = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(curve), valueChangedCallback, finishedCallback, clamp, unscaledTime);
		}

		private static IEnumerator LerpColourInternal(Color startColour, Color endColour, float duration, KWEase.EaseFunction function, Action<Color> valueChangedCallback, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				Color value = Color.LerpUnclamped(startColour, endColour, eased);
				valueChangedCallback?.Invoke(value);
				yield return null;
			}
			valueChangedCallback?.Invoke(endColour);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpGraphicColour(Graphic graphic, Color startColour, Color endColour, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(type), (Color c) => { graphic.color = c; onValueChanged?.Invoke(c); }, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpGraphicColour(Graphic graphic, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(curve), (Color c) => { graphic.color = c; onValueChanged?.Invoke(c); }, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpSpriteColour(SpriteRenderer sprite, Color startColour, Color endColour, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(type), (Color c) => { sprite.color = c; onValueChanged?.Invoke(c); }, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpSpriteColour(SpriteRenderer sprite, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(curve), (Color c) => { sprite.color = c; onValueChanged?.Invoke(c); }, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpMaterialColour(Material material, Color startColour, Color endColour, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(type), (Color c) => { material.color = c; onValueChanged?.Invoke(c); }, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpMaterialColour(Material material, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(curve), (Color c) => { material.color = c; onValueChanged?.Invoke(c); }, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpRendererColour(Renderer renderer, Color startColour, Color endColour, float duration, AnimationCurve curve = null, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(curve), (Color c) => { renderer.material.color = c; onValueChanged?.Invoke(c); }, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpRendererColour(Renderer renderer, Color startColour, Color endColour, float duration, KWEase.Type type, Action<Color> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			return LerpColourInternal(startColour, endColour, duration, KWEase.GetEase(type), (Color c) => { renderer.material.color = c; onValueChanged?.Invoke(c); }, finishedCallback, clamp, unscaledTime);
		}

		public static IEnumerator LerpAlpha(Color color, float startAlpha, float endAlpha, float duration, Action<Color> valueChangedCallback, AnimationCurve curve = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(curve);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				color.a = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				valueChangedCallback?.Invoke(color);
				yield return null;
			}
			color.a = endAlpha;
			valueChangedCallback?.Invoke(color);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpAlpha(Color color, float startAlpha, float endAlpha, float duration, Action<Color> valueChangedCallback, KWEase.Type type = KWEase.Type.LINEAR, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(type);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				color.a = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				valueChangedCallback?.Invoke(color);
				yield return null;
			}
			color.a = endAlpha;
			valueChangedCallback?.Invoke(color);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpAlpha(Graphic graphic, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(type);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				float alpha = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				Color c = graphic.color;
				c.a = alpha;
				graphic.color = c;
				onValueChanged?.Invoke(alpha);
				yield return null;
			}
			Color final_c = graphic.color;
			final_c.a = endAlpha;
			graphic.color = final_c;
			onValueChanged?.Invoke(endAlpha);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpAlpha(Graphic graphic, float startAlpha, float endAlpha, float duration, AnimationCurve curve, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(curve);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				float alpha = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				Color c = graphic.color;
				c.a = alpha;
				graphic.color = c;
				onValueChanged?.Invoke(alpha);
				yield return null;
			}
			Color final_c = graphic.color;
			final_c.a = endAlpha;
			graphic.color = final_c;
			onValueChanged?.Invoke(endAlpha);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpAlpha(Material material, float startAlpha, float endAlpha, float duration, AnimationCurve curve = null, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(curve);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				float alpha = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				Color c = material.color;
				c.a = alpha;
				material.color = c;
				onValueChanged?.Invoke(alpha);
				yield return null;
			}
			Color final_c = material.color;
			final_c.a = endAlpha;
			material.color = final_c;
			onValueChanged?.Invoke(endAlpha);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpAlpha(Material material, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(type);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				float alpha = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				Color c = material.color;
				c.a = alpha;
				material.color = c;
				onValueChanged?.Invoke(alpha);
				yield return null;
			}
			Color final_c = material.color;
			final_c.a = endAlpha;
			material.color = final_c;
			onValueChanged?.Invoke(endAlpha);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpAlpha(Renderer renderer, float startAlpha, float endAlpha, float duration, AnimationCurve curve = null, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(curve);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				float alpha = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				Color c = renderer.material.color;
				c.a = alpha;
				renderer.material.color = c;
				onValueChanged?.Invoke(alpha);
				yield return null;
			}
			Color final_c = renderer.material.color;
			final_c.a = endAlpha;
			renderer.material.color = final_c;
			onValueChanged?.Invoke(endAlpha);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpAlpha(Renderer renderer, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(type);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				float alpha = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				Color c = renderer.material.color;
				c.a = alpha;
				renderer.material.color = c;
				onValueChanged?.Invoke(alpha);
				yield return null;
			}
			Color final_c = renderer.material.color;
			final_c.a = endAlpha;
			renderer.material.color = final_c;
			onValueChanged?.Invoke(endAlpha);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpAlpha(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration, KWEase.Type type = KWEase.Type.LINEAR, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(type);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				float alpha = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				canvasGroup.alpha = alpha;
				onValueChanged?.Invoke(alpha);
				yield return null;
			}
			canvasGroup.alpha = endAlpha;
			onValueChanged?.Invoke(endAlpha);
			finishedCallback?.Invoke();
		}

		public static IEnumerator LerpAlpha(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration, AnimationCurve curve = null, Action<float> onValueChanged = null, Action finishedCallback = null, bool clamp = true, bool unscaledTime = false)
		{
			KWEase.EaseFunction function = KWEase.GetEase(curve);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				elapsed += unscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
				float t = elapsed / duration;
				if (clamp)
					t = Mathf.Clamp01(t);
				float eased = function != null ? function(t) : t;
				float alpha = Mathf.LerpUnclamped(startAlpha, endAlpha, eased);
				canvasGroup.alpha = alpha;
				onValueChanged?.Invoke(alpha);
				yield return null;
			}
			canvasGroup.alpha = endAlpha;
			onValueChanged?.Invoke(endAlpha);
			finishedCallback?.Invoke();
		}
	}
}
