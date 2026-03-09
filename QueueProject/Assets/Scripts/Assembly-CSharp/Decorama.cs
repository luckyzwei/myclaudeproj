using System.Collections.Generic;
using UnityEngine;

public class Decorama : MonoBehaviour
{
	[Header("Identifiers")]
	[SerializeField]
	private string m_decoramaID;

	[SerializeField]
	private string m_decoramaName;

	[Header("Elements")]
	[SerializeField]
	private DecoramaPaintable[] m_paintables;

	private bool m_isComplete;

	private int m_decoramaIndex;

	private List<DecoramaPaintable> m_paintableOrder;

	private DecoramaRendererController m_decoramaRendererController;

	public DecoramaPaintable[] Paintables => null;

	public List<DecoramaPaintable> OrderedPaintables => null;

	public string DecoramaID => null;

	public int DecoramaIndex => 0;

	public DecoramaRendererController DecoramaRendererController => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Config(int decoramaIndex)
	{
	}

	private void DisableUnsedPaintables()
	{
	}

	private void ToggleMaterial()
	{
	}

	public bool IsComplete()
	{
		return false;
	}

	public string GetDecoramaName()
	{
		return null;
	}

	public DecoramaPaintable GetActivePaintable()
	{
		return null;
	}
}
