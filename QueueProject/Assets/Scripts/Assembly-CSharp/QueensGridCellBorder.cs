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
		if (grid == null || cell == null || grid.LevelData == null) return 0;

		int config = 0;
		int x = cell.Coords.x;
		int y = cell.Coords.y;
		int myColor = cell.Colour;
		var levelData = grid.LevelData;

		// Check 4 cardinal neighbors - set flag if different color
		// Top
		if (y > 0 && levelData.GetColor(x, y - 1) != myColor) config |= TOP;
		else if (y == 0) config |= TOP;
		// Bottom
		if (y < levelData.sizeY - 1 && levelData.GetColor(x, y + 1) != myColor) config |= BOTTOM;
		else if (y == levelData.sizeY - 1) config |= BOTTOM;
		// Left
		if (x > 0 && levelData.GetColor(x - 1, y) != myColor) config |= LEFT;
		else if (x == 0) config |= LEFT;
		// Right
		if (x < levelData.sizeX - 1 && levelData.GetColor(x + 1, y) != myColor) config |= RIGHT;
		else if (x == levelData.sizeX - 1) config |= RIGHT;

		// Check 4 diagonal neighbors
		// Top-Left
		if (x > 0 && y > 0 && levelData.GetColor(x - 1, y - 1) != myColor) config |= TOPLEFT;
		// Top-Right
		if (x < levelData.sizeX - 1 && y > 0 && levelData.GetColor(x + 1, y - 1) != myColor) config |= TOPRIGHT;
		// Bottom-Left
		if (x > 0 && y < levelData.sizeY - 1 && levelData.GetColor(x - 1, y + 1) != myColor) config |= BOTTOMLEFT;
		// Bottom-Right
		if (x < levelData.sizeX - 1 && y < levelData.sizeY - 1 && levelData.GetColor(x + 1, y + 1) != myColor) config |= BOTTOMRIGHT;

		return config;
	}

	public void Configure(int config)
	{
		// Show/hide border segments based on bitmask config
		SetActive(m_topRight, (config & TOP) != 0 && (config & RIGHT) == 0);
		SetActive(m_topLeft, (config & TOP) != 0 && (config & LEFT) == 0);
		SetActive(m_bottomRight, (config & BOTTOM) != 0 && (config & RIGHT) == 0);
		SetActive(m_bottomLeft, (config & BOTTOM) != 0 && (config & LEFT) == 0);
		SetActive(m_rightTop, (config & RIGHT) != 0 && (config & TOP) == 0);
		SetActive(m_rightBottom, (config & RIGHT) != 0 && (config & BOTTOM) == 0);
		SetActive(m_leftTop, (config & LEFT) != 0 && (config & TOP) == 0);
		SetActive(m_leftBottom, (config & LEFT) != 0 && (config & BOTTOM) == 0);

		// Corners - show when both adjacent sides have borders
		SetActive(m_rightTopCorner, (config & RIGHT) != 0 && (config & TOP) != 0);
		SetActive(m_rightBottomCorner, (config & RIGHT) != 0 && (config & BOTTOM) != 0);
		SetActive(m_leftTopCorner, (config & LEFT) != 0 && (config & TOP) != 0);
		SetActive(m_leftBottomCorner, (config & LEFT) != 0 && (config & BOTTOM) != 0);

		// Reverse corners - show when diagonal differs but both adjacent sides are same color
		SetActive(m_rightTopReverseCorner, (config & TOPRIGHT) != 0 && (config & RIGHT) == 0 && (config & TOP) == 0);
		SetActive(m_rightBottomReverseCorner, (config & BOTTOMRIGHT) != 0 && (config & RIGHT) == 0 && (config & BOTTOM) == 0);
		SetActive(m_leftTopReverseCorner, (config & TOPLEFT) != 0 && (config & LEFT) == 0 && (config & TOP) == 0);
		SetActive(m_leftBottomReverseCorner, (config & BOTTOMLEFT) != 0 && (config & LEFT) == 0 && (config & BOTTOM) == 0);
	}

	private void SetActive(GameObject obj, bool active)
	{
		if (obj != null) obj.SetActive(active);
	}
}
