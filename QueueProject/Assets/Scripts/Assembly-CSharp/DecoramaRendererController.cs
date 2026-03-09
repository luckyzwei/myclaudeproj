using UnityEngine;

public class DecoramaRendererController : MonoBehaviour
{
	[SerializeField]
	private Renderer[] m_renderers;

	private Material[][] m_cachedMaterials;

	private void Awake()
	{
	}

	public void CacheRenderers()
	{
	}

	private void CacheMaterials()
	{
	}

	public void RestoreMaterials()
	{
	}

	public void LockedMaterial()
	{
	}
}
