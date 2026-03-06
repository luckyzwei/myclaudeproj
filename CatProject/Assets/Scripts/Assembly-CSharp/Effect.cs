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
		transform.position = worldPos;
		FollowTrans = followTrans;
		Play();
	}

	public virtual void Play()
	{
		if (particles == null) return;
		for (int i = 0; i < particles.Count; i++)
		{
			if (particles[i] != null)
				particles[i].Play();
		}
	}

	public virtual void Stop()
	{
		if (particles == null) return;
		for (int i = 0; i < particles.Count; i++)
		{
			if (particles[i] != null)
				particles[i].Stop();
		}
	}

	public void SetAutoRemove(bool value, float time)
	{
		autoRemove = value;
		targetTime = time;
		deltaTime = 0f;
	}

	private void Update()
	{
		if (FollowTrans != null)
			transform.position = FollowTrans.position;

		if (autoRemove)
		{
			deltaTime += Time.deltaTime;
			if (deltaTime >= targetTime)
			{
				autoRemove = false;
				OnForceCollect();
			}
		}
	}

	public void OnForceCollect()
	{
		Stop();
		gameObject.SetActive(false);
	}
}
