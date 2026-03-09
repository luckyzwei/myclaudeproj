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
		return 0f;
	}

	public void PointerDown()
	{
	}

	public void PointerUp()
	{
	}

	public void AddListener(float progress, Action callback)
	{
	}

	private void Update()
	{
	}

	public void Fade(float value, float duration)
	{
	}
}
