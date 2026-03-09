using Balancy.Models;
using UnityEngine;

public abstract class QueensControlSchemeBase : MonoBehaviour
{
	protected bool m_markingXEnabled;

	protected QueensGrid m_grid;

	protected virtual void Start()
	{
	}

	public abstract ControlSchemes GetScheme();

	public abstract void KillInput();

	protected bool IsActive()
	{
		return false;
	}

	protected QueensGridCell GetCell()
	{
		return null;
	}

	protected QueensGridCell GetCell(out Vector3 hitPoint)
	{
		hitPoint = default(Vector3);
		return null;
	}

	public void SetMarkingXEnabled(bool value)
	{
	}
}
