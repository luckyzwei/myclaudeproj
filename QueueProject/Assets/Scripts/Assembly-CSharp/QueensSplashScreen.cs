using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class QueensSplashScreen : MonoBehaviour
{
	[SerializeField]
	private Image m_loadingBarFill;

	[SerializeField]
	private float m_minDelayAfterStep;

	[SerializeField]
	private float m_maxDelayAfterStep;

	[SerializeField]
	private List<Milestone> m_milestones;

	private Sequence m_loadingSequence;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLoadingCompleted()
	{
	}

	private void Start()
	{
	}

	private void ProcessMilestones()
	{
	}
}
