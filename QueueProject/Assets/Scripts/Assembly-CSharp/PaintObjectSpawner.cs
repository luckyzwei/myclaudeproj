using System;
using System.Collections.Generic;
using KWGameCore;
using UnityEngine;

public class PaintObjectSpawner : MonoBehaviour
{
	private const float DOUBLE = 2f;

	private const int POOL_SIZE = 10;

	[SerializeField]
	private PaintObject[] m_paintObjectPrefabs;

	[Header("Paint Object")]
	[SerializeField]
	private float m_paintObjectRotationSpeed;

	[SerializeField]
	private float m_paintObjectScale;

	[SerializeField]
	private Material[] m_paintObjectMaterials;

	[Header("Tweens")]
	[SerializeField]
	private float m_paintMoveDuration;

	[SerializeField]
	private AnimationCurve m_paintMoveTweenEase;

	[SerializeField]
	private AnimationCurve m_painScaleTweenEase;

	[Header("Position Multipliers")]
	[SerializeField]
	private float m_cameraSpawnPlanZ;

	[SerializeField]
	private float m_startSideXMultiplier;

	[SerializeField]
	private float m_centerUpMultiplier;

	[SerializeField]
	private float m_centerSideMultiplier;

	private List<Pool<PaintObject>> m_paintObjectPool;

	private Vector3 m_buildButtonPosition;

	private void Awake()
	{
	}

	public void CacheBuildButtonPosition()
	{
	}

	public void SpawnPaintObject(Vector3 moveToPos, Action completeCallback)
	{
	}
}
