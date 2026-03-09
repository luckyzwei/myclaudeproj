using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class StoreItemDynamicGrid : MonoBehaviour
{
	private RectTransform m_content;

	[SerializeField]
	private int m_minElements;

	[SerializeField]
	private int m_maxElements;

	[SerializeField]
	private Vector2 m_maxCellSize;

	[SerializeField]
	private Vector2 m_minCellSize;

	private GridLayoutGroup m_gridLayout;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnTransformChildrenChanged()
	{
	}

	private void OnRectTransformDimensionsChange()
	{
	}

	private void AdjustCellSize()
	{
	}
}
