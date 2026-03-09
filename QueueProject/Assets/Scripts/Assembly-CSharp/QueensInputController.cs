using System.Collections.Generic;
using Balancy.Models;
using KWCore.Utils;
using UnityEngine;

public class QueensInputController : MonoSingleton<QueensInputController>
{
	private QueensGrid m_grid;

	private QueensGridCell m_currentCell;

	private bool m_isDragging;

	private Dictionary<ControlSchemes, QueensControlSchemeBase> m_schemes;

	private int m_pointerStatus; // 0=none, 1=down, 2=held

	private QueensControlSchemeBase m_currentControlScheme;

	public QueensControlSchemeBase CurrentControlScheme => m_currentControlScheme;

	protected override void Init()
	{
		m_schemes = new Dictionary<ControlSchemes, QueensControlSchemeBase>();
	}

	public bool GetMouseButtonDown()
	{
		return m_pointerStatus == 1;
	}

	public bool GetMouseButton()
	{
		return m_pointerStatus >= 1;
	}

	public bool GetMouseButtonUp()
	{
		return m_pointerStatus == -1;
	}

	private void OnPointerUp()
	{
		m_pointerStatus = -1;
	}

	private void OnPointerDown()
	{
		m_pointerStatus = 1;
	}

	public void OnPointerDownFromControlPad()
	{
		m_pointerStatus = 1;
	}

	public void OnPointerUpFromControlPad()
	{
		m_pointerStatus = -1;
	}

	private void LateUpdate()
	{
		// Transition pointer status after frame
		if (m_pointerStatus == 1)
			m_pointerStatus = 2; // down -> held
		else if (m_pointerStatus == -1)
			m_pointerStatus = 0; // up -> none
	}

	private void Start()
	{
		// Find control schemes on this object or children
		var schemes = GetComponentsInChildren<QueensControlSchemeBase>(true);
		foreach (var scheme in schemes)
		{
			RegisterControlScheme(scheme);
		}

		// Default to Scheme_A
		var selectedScheme = GetSelectedControlScheme();
		if (m_schemes.ContainsKey(selectedScheme))
		{
			m_currentControlScheme = m_schemes[selectedScheme];
		}
		else if (m_schemes.Count > 0)
		{
			// Fallback to first available scheme
			foreach (var kvp in m_schemes)
			{
				m_currentControlScheme = kvp.Value;
				break;
			}
		}

		// Enable the active scheme, disable others
		foreach (var kvp in m_schemes)
		{
			kvp.Value.enabled = (kvp.Value == m_currentControlScheme);
		}
	}

	public void RegisterControlScheme(QueensControlSchemeBase scheme)
	{
		if (scheme == null) return;
		var key = scheme.GetScheme();
		m_schemes[key] = scheme;
	}

	public bool CanClickOnCell(QueensGridCell cell)
	{
		if (cell == null) return false;
		return true;
	}

	public static ControlSchemes GetSelectedControlScheme()
	{
		return ControlSchemes.Scheme_A;
	}

	public void KillInput()
	{
		m_pointerStatus = 0;
		if (m_currentControlScheme != null)
			m_currentControlScheme.KillInput();
	}
}
