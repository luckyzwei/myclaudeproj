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
		MatPropBlock = new MaterialPropertyBlock();
		bPlaying = false;
	}

	public void SetRegion(int region)
	{
		Region = region;
	}

	public void PlayBuildingFx()
	{
		bPlaying = true;
		if (BuildingFx != null)
		{
			for (int i = 0; i < BuildingFx.Count; i++)
				if (BuildingFx[i] != null) BuildingFx[i].SetActive(true);
		}
		if (BuildingFxTween != null) BuildingFxTween.Play();
	}

	public void Reset()
	{
		bPlaying = false;
		if (BuildingFx != null)
		{
			for (int i = 0; i < BuildingFx.Count; i++)
				if (BuildingFx[i] != null) BuildingFx[i].SetActive(false);
		}
	}
}
