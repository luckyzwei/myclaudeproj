using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DecoramaQueue : MonoBehaviour
{
	[SerializeField]
	private Transform m_startingSpawnPoint;

	[SerializeField]
	private Vector3 m_queueDirection;

	[SerializeField]
	private float m_spacing;

	[SerializeField]
	private int m_activeSides;

	[SerializeField]
	private Ease m_moveTweenEase;

	[SerializeField]
	private float m_moveTweenDuration;

	private List<Decorama> m_spawnedDecoramas;

	private int m_visibleIndex;

	public void Config()
	{
	}

	public void RefocusDecoramas(int preSpawnNextDecorama)
	{
	}

	public Decorama PreviewNext()
	{
		return null;
	}

	public Decorama PreviewPrevious()
	{
		return null;
	}

	private void SendDecoramaUpdatedEvent()
	{
	}

	private Decorama Move(int moveDirection, bool tween = true, Action onMoveCompleteCallback = null)
	{
		return null;
	}

	private void CreateDecorama(Vector3 spawnPosition, int index)
	{
	}
}
