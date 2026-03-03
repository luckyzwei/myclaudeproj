using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
	[SerializeField]
	protected List<ParticleSystem> particles;

	private Transform FollowTrans;

	private bool autoRemove;

	private float deltaTime;

	private float targetTime;

	public virtual void Play(Vector3 worldPos, Transform followTrans)
	{
	}

	public virtual void Play()
	{
	}

	public virtual void Stop()
	{
	}

	public void SetAutoRemove(bool value, float time)
	{
	}

	private void Update()
	{
	}

	public void OnForceCollect()
	{
	}
}
