using DG.Tweening;
using UnityEngine;

public class NavigationBarVisuals : MonoBehaviour
{
	[SerializeField]
	private Transform m_selectedVisuals;

	[SerializeField]
	private TabToolbarButton[] m_tabButtons;

	private Tweener m_tweener;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void TabChanged(int index, bool immediately)
	{
	}
}
