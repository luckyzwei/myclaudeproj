using System.Collections.Generic;
using UnityEngine;

public class BizAcqBuilding : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> BuildingFx;

	[SerializeField]
	private DoTweenScriptComponent BuildingFxTween;

	[SerializeField]
	private ParticleSystemRenderer MoneyParticleRenderer;

	[Header("Sound")]
	[SerializeField]
	protected string BuildingFxName;

	protected int Region;

	private MaterialPropertyBlock MatPropBlock;

	public bool bPlaying { get; private set; }

	private void Awake()
	{
	}

	public void SetRegion(int region)
	{
	}

	public void PlayBuildingFx()
	{
	}

	public void Reset()
	{
	}
}
