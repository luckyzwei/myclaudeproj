using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemOnetimeFloor : MonoBehaviour
{
	[Header("ItemOnetimeFloor")]
	[SerializeField]
	private List<Transform> LightTs;

	private List<Image> lightImages;

	private List<DoTweenScriptComponent> doneLights;

	[SerializeField]
	private List<Transform> AdditiveLightTs;

	private List<DoTweenScriptComponent> playLights;

	private List<DoTweenScriptComponent> idleLights;

	private List<DoTweenScriptComponent> touchLights;

	[SerializeField]
	private GameObject StarParticle;

	public List<DoTweenScriptComponent> TouchLights { get { return touchLights; } }

	private void Awake()
	{
		lightImages = new List<Image>();
		doneLights = new List<DoTweenScriptComponent>();
		playLights = new List<DoTweenScriptComponent>();
		idleLights = new List<DoTweenScriptComponent>();
		touchLights = new List<DoTweenScriptComponent>();
	}

	public void SetLight(bool isDone)
	{
		if (StarParticle != null)
			StarParticle.SetActive(isDone);
		if (doneLights != null)
		{
			for (int i = 0; i < doneLights.Count; i++)
			{
				if (doneLights[i] != null)
					doneLights[i].gameObject.SetActive(isDone);
			}
		}
	}

	public void PlayLight()
	{
		if (playLights != null)
		{
			for (int i = 0; i < playLights.Count; i++)
			{
				if (playLights[i] != null)
					playLights[i].Play();
			}
		}
	}
}
