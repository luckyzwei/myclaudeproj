using System;
using KWUserInterface;
using UnityEngine;

public class DecoramaScreen : KWUserInterface.Screen
{
	public const string PREFAB_NAME = "Prefabs/KWDecorama/Screen-Decorama";

	[SerializeField]
	private float m_nextFlowDelay;

	private Action m_onComplete;

	private void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public void Config(Action onComplete)
	{
	}

	private void NextFlow()
	{
	}

	private void DecoramaEvents_OnDecoramaUIStateChangedEvent(DecoramaState decoramaState)
	{
	}
}
