using System;
using KWCore.UI;
using UnityEngine;

public class PopUpLifeWarning : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/KWLifeSystem/PopUp-LoseALifeWarning";

	[SerializeField]
	private bool m_autoClose;

	private Action m_onReplayPressed;

	private Action m_onHomePressed;

	public void Config(Action onReplayPressed, Action onHomePressed)
	{
	}

	public void OnReplayPressed()
	{
	}

	public void OnHomePressed()
	{
	}
}
