using System;
using System.Collections.Generic;
using KPFCore;
using UnityEngine;

public abstract class ControllerBase : ScriptableObject, IController, IDisposable
{
	[SerializeField]
	private UIPrefabWithID[] m_uiPrefabsConfig;

	protected Dictionary<string, UIPrefabWithID> m_viewPrefabsDict;

	public void Initialise()
	{
	}

	protected abstract void InitialiseLocal();

	protected abstract void ShowView(IUIEvent evt);

	public void Dispose()
	{
	}

	public List<string> GetPrefabNames()
	{
		return null;
	}
}
