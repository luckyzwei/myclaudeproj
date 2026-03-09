using System;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class AddressableLoadingScreen : PopUpBase
{
	public static string PREFAB_PATH;

	[SerializeField]
	private Image m_progressBar;

	private Action m_closed;

	public void Config(Action closeCallback)
	{
	}

	public void UpdateProgress(float progress)
	{
	}

	public void AutoClosePopUp()
	{
	}
}
