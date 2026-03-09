using Balancy.Models.SmartObjects;
using UnityEngine;
using UnityEngine.Serialization;

public class LifeHorizontalDisplay : MonoBehaviour
{
	[SerializeField]
	private LifeHeart m_lifeHeartPrefab;

	[FormerlySerializedAs("m_spawnHeartsAtStart")]
	[SerializeField]
	private bool m_updateHeartsAtStart;

	private LifeHeart[] m_instantiatedLifeHearts;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void UpdateHeartVisuals()
	{
	}

	private void OnItemChanged(Item item, int count, int slotindex)
	{
	}

	private void ClearAnyPreviousHearts()
	{
	}

	private void InstantiateHeartPrefabs()
	{
	}

	private void UpdateHeartPrefabVisuals(bool useDelay = false)
	{
	}
}
