using System;
using UnityEngine;

public class JigsawFragment : CurrencyExplosionCell
{
	private Vector3 m_startPosition;

	private Transform m_target;

	private float m_duration;

	private float m_time;

	private bool m_isChasing;

	private Action m_finishCallback;

	public void Chase(Transform target, float moveTime, Action callback)
	{
	}

	private void Update()
	{
	}
}
