using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour
{
	[SerializeField]
	private List<ParticleSystem> particles;

	public void Play()
	{
		gameObject.SetActive(true);
	}
}
