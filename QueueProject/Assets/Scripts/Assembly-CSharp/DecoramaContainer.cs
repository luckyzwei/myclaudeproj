using System.Collections.Generic;
using Balancy.Models.KWDecorama;
using UnityEngine;

[CreateAssetMenu(fileName = "DecoramaContainer", menuName = "Kwalee/KPF/Decorama/DecoramaContainer", order = 1)]
public class DecoramaContainer : ScriptableObject
{
	[SerializeField]
	private List<Decorama> m_availableDecoramas;

	[SerializeField]
	private Decorama m_fakeDecorama;

	private HashSet<string> m_clientAvailableDecoramaIDs;

	public List<Decorama> GetOrderedDecoramas()
	{
		return null;
	}

	private void TryPopulateHashSet()
	{
	}

	public List<DecoramaData> GetOrderedDecoramaSettings()
	{
		return null;
	}

	public DecoramaData GetDecoramaSettings(int index)
	{
		return null;
	}

	public bool DecoramaExistsLocally(string decoramaID)
	{
		return false;
	}

	public bool PaintableExistsLocally(string paintableID, string decoramaID)
	{
		return false;
	}

	private Decorama GetDecorama(string decoramaID)
	{
		return null;
	}
}
