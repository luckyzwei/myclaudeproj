using UnityEngine;
using UnityEngine.UI;

public class CentredGridLayoutGroup : LayoutGroup
{
	public enum Corner
	{
		UpperLeft = 0,
		UpperRight = 1,
		LowerLeft = 2,
		LowerRight = 3
	}

	public enum Axis
	{
		Horizontal = 0,
		Vertical = 1
	}

	public enum Constraint
	{
		Flexible = 0,
		FixedColumnCount = 1,
		FixedRowCount = 2
	}

	[Header("Grid Settings")]
	public Corner startCorner;

	public Axis startAxis;

	public Vector2 cellSize;

	public Vector2 spacing;

	[Header("Constraints")]
	public Constraint constraint;

	[Min(1f)]
	public int constraintCount;

	[Header("Special Formatting")]
	[Tooltip("If checked, the incomplete last row (or column) will be centered relative to the grid.")]
	public bool centerLastGroup;

	private int cellsPerMainAxis;

	private int actualCellCountX;

	private int actualCellCountY;

	public override void CalculateLayoutInputHorizontal()
	{
	}

	public override void CalculateLayoutInputVertical()
	{
	}

	public override void SetLayoutHorizontal()
	{
	}

	public override void SetLayoutVertical()
	{
	}

	private void SetCellsAlongAxis(int axis)
	{
	}
}
