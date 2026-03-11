using Balancy.Models;
using UnityEngine;

public abstract class QueensControlSchemeBase : MonoBehaviour
{
	protected bool m_markingXEnabled;

	protected QueensGrid m_grid;

	protected virtual void Start()
	{
		m_grid = GetComponentInParent<QueensGrid>();
		if (m_grid == null)
			m_grid = FindObjectOfType<QueensGrid>();
	}

	public abstract ControlSchemes GetScheme();

	public abstract void KillInput();

	protected bool IsActive()
	{
		return m_grid != null && m_grid.IsInputEnabled;
	}

	protected QueensGridCell GetCell()
	{
		Vector3 hitPoint;
		return GetCell(out hitPoint);
	}

	protected QueensGridCell GetCell(out Vector3 hitPoint)
	{
		hitPoint = Vector3.zero;
		Vector3 mousePos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
		if (hit.collider != null)
		{
			hitPoint = hit.point;
			return hit.collider.GetComponent<QueensGridCell>();
		}
		return null;
	}

	public void SetMarkingXEnabled(bool value)
	{
		m_markingXEnabled = value;
	}
}
