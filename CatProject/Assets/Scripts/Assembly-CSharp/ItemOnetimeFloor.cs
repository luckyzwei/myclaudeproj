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

	public List<DoTweenScriptComponent> TouchLights { get { return null; } }

	private void Awake()
	{
	}

	public void SetLight(bool isDone)
	{
	}

	public void PlayLight()
	{
	}
}
