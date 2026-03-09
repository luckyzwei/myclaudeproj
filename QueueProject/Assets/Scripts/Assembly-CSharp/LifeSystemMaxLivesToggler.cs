using Balancy.Models.SmartObjects;
using UnityEngine;

public class LifeSystemMaxLivesToggler : MonoBehaviour
{
	[SerializeField]
	private bool m_stateWhenFullLives;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnItemUpdated(Item item, int count, int slotindex)
	{
	}

	private void OnEnable()
	{
	}

	private void SetActiveState()
	{
	}
}
