using System;
using UnityEngine;

public class LeaguePodiumWidget : MonoBehaviour
{
	[SerializeField]
	private LeaguePodiumStepWidget m_firstLeaguePodiumStep;

	[SerializeField]
	private LeaguePodiumStepWidget m_secondLeaguePodiumStep;

	[SerializeField]
	private LeaguePodiumStepWidget m_thirdLeaguePodiumStep;

	[SerializeField]
	private Sprite m_explosionSprite;

	public void Configure(int newPlayerRank)
	{
	}

	public void PlayPlayerAnimations(bool dynamic)
	{
	}

	private void ConfigurePodiumWithBot(LeaguePodiumStepWidget stepWidget, int rank, int playerRank)
	{
	}

	public void DoCurrencyExplosionOnPlayer(int number, int rank, Action callback)
	{
	}
}
