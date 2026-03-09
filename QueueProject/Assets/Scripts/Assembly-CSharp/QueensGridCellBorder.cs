using UnityEngine;

public class QueensGridCellBorder : MonoBehaviour
{
	[SerializeField]
	private GameObject m_rightTopCorner;

	[SerializeField]
	private GameObject m_rightBottomCorner;

	[SerializeField]
	private GameObject m_leftTopCorner;

	[SerializeField]
	private GameObject m_leftBottomCorner;

	[SerializeField]
	private GameObject m_rightTopReverseCorner;

	[SerializeField]
	private GameObject m_rightBottomReverseCorner;

	[SerializeField]
	private GameObject m_leftTopReverseCorner;

	[SerializeField]
	private GameObject m_leftBottomReverseCorner;

	[SerializeField]
	private GameObject m_topRight;

	[SerializeField]
	private GameObject m_topLeft;

	[SerializeField]
	private GameObject m_bottomRight;

	[SerializeField]
	private GameObject m_bottomLeft;

	[SerializeField]
	private GameObject m_rightTop;

	[SerializeField]
	private GameObject m_rightBottom;

	[SerializeField]
	private GameObject m_leftTop;

	[SerializeField]
	private GameObject m_leftBottom;

	public const int TOP = 1;

	public const int BOTTOM = 2;

	public const int LEFT = 4;

	public const int RIGHT = 8;

	public const int TOPLEFT = 16;

	public const int TOPRIGHT = 32;

	public const int BOTTOMLEFT = 64;

	public const int BOTTOMRIGHT = 128;

	public static int GetConfigFromCell(QueensGrid grid, QueensGridCell cell)
	{
		return 0;
	}

	public void Configure(int config)
	{
	}
}
