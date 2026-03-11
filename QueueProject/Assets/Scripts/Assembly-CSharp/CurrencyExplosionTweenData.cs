using System;
using System.Collections.Generic;
using KWAudio;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrencyExplosionTweenData", menuName = "Kwalee/KWRewards/CurrencyExplosionTweenData", order = 1)]
public class CurrencyExplosionTweenData : ScriptableObject
{
	[SerializeField]
	protected string m_clientID;

	[SerializeField]
	protected CurrencyExplosionCell m_currencyExplosionPrefab;

	[SerializeField]
	protected int m_minNumtoSpawn;

	[SerializeField]
	protected int m_maxNumToSpawn;

	[Header("Initial Explosion")]
	[SerializeField]
	protected ParticleSystem m_particleSystem;

	[SerializeField]
	protected float m_explosionRadius;

	[SerializeField]
	protected float m_explosionTime;

	[SerializeField]
	protected AnimationCurve m_explosionCurve;

	[Header("Movement")]
	[SerializeField]
	protected float m_movementDelayMin;

	[SerializeField]
	protected float m_movementDelayMax;

	[SerializeField]
	protected bool m_randomDelay;

	[SerializeField]
	protected float m_movementTime;

	[SerializeField]
	protected AnimationCurve m_movementCurve;

	[SerializeField]
	protected bool m_useUnscaledTile;

	[Header("Explosion Audio")]
	[SerializeField]
	protected AudioClipReference m_defaultAudioClip;

	[SerializeField]
	protected List<CurrencyExplosionAudio> m_currencyExplosionAudio;

	[Header("Collection Audio")]
	[SerializeField]
	protected List<CurrencyExplosionAudio> m_currencyCollectionAudio;

	public string ClientdId => m_clientID;

	public virtual void PlayExplosionTween(Transform parent, Sprite sprite, int numToSpawn, Vector3 start, Transform target, Action firstElementReached, Action finished, string clientID = "default")
	{
	}
}
