using System.Collections.Generic;
using Balancy.Models;
using KWCore.Utils;

public class QueensInputController : MonoSingleton<QueensInputController>
{
	private QueensGrid m_grid;

	private QueensGridCell m_currentCell;

	private bool m_isDragging;

	private Dictionary<ControlSchemes, QueensControlSchemeBase> m_schemes;

	private int m_pointerStatus;

	public QueensControlSchemeBase CurrentControlScheme => null;

	protected override void Init()
	{
	}

	public bool GetMouseButtonDown()
	{
		return false;
	}

	public bool GetMouseButton()
	{
		return false;
	}

	public bool GetMouseButtonUp()
	{
		return false;
	}

	private void OnPointerUp()
	{
	}

	private void OnPointerDown()
	{
	}

	private void LateUpdate()
	{
	}

	private void Start()
	{
	}

	public void RegisterControlScheme(QueensControlSchemeBase scheme)
	{
	}

	public bool CanClickOnCell(QueensGridCell cell)
	{
		return false;
	}

	public static ControlSchemes GetSelectedControlScheme()
	{
		return default(ControlSchemes);
	}

	public void KillInput()
	{
	}
}
