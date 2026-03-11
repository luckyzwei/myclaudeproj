using System;
using System.Collections.Generic;
using UnityEngine;

public class ExtraTutorialHand : MonoBehaviour
{
	private const string ANIM_ANIM_HANDTAPDOWN = "Anim-HandTapDown";

	private const string ANIM_ANIM_HANDTAPRELEASE = "Anim-HandTapRelease";

	[SerializeField]
	private AnimatorHelper m_animator;

	[SerializeField]
	private CanvasGroup m_canvasGroup;

	private float m_time;

	private float m_duration;

	private Vector3 m_source;

	private Vector3 m_destination;

	private bool m_isMoving;

	private List<Tuple<float, Action>> m_listeners;

	public float Drag(Vector3 startPoint, Vector3 finishPoint, float speedMultiplier)
	{
		m_source = startPoint;
		m_destination = finishPoint;
		transform.position = startPoint;

		float distance = Vector3.Distance(startPoint, finishPoint);
		m_duration = distance / (speedMultiplier > 0f ? speedMultiplier : 1f);
		m_time = 0f;
		m_isMoving = true;

		return m_duration;
	}

	public void PointerDown()
	{
		if (m_animator != null)
			m_animator.SetTrigger(ANIM_ANIM_HANDTAPDOWN);
	}

	public void PointerUp()
	{
		if (m_animator != null)
			m_animator.SetTrigger(ANIM_ANIM_HANDTAPRELEASE);
	}

	public void AddListener(float progress, Action callback)
	{
		if (m_listeners == null)
			m_listeners = new List<Tuple<float, Action>>();
		m_listeners.Add(new Tuple<float, Action>(progress, callback));
	}

	private void Update()
	{
		if (!m_isMoving || m_duration <= 0f)
			return;

		m_time += Time.deltaTime;
		float t = Mathf.Clamp01(m_time / m_duration);
		transform.position = Vector3.Lerp(m_source, m_destination, t);

		// Fire listeners at progress thresholds
		if (m_listeners != null)
		{
			for (int i = m_listeners.Count - 1; i >= 0; i--)
			{
				if (t >= m_listeners[i].Item1)
				{
					m_listeners[i].Item2?.Invoke();
					m_listeners.RemoveAt(i);
				}
			}
		}

		if (t >= 1f)
			m_isMoving = false;
	}

	// Called by AnimationEvent on HandSwipe animation loop
	private void AnimEventLooped()
	{
	}

	public void Fade(float value, float duration)
	{
		if (m_canvasGroup != null)
		{
			if (duration <= 0f)
			{
				m_canvasGroup.alpha = value;
			}
			else
			{
				StartCoroutine(FadeCoroutine(value, duration));
			}
		}
	}

	private System.Collections.IEnumerator FadeCoroutine(float targetAlpha, float duration)
	{
		float startAlpha = m_canvasGroup.alpha;
		float elapsed = 0f;
		while (elapsed < duration)
		{
			elapsed += Time.deltaTime;
			m_canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsed / duration);
			yield return null;
		}
		m_canvasGroup.alpha = targetAlpha;
	}
}
