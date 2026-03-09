using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class DailyWinStreakVisuals : MonoBehaviour
{
	[Serializable]
	public struct ThresholdAnimation
	{
		public int Threshold;

		public string AnimationName;

		public UnityEngine.Gradient Gradient;
	}

	[SerializeField]
	private AnimatorHelper m_flameAnimatorHelper;

	[SerializeField]
	private TextMeshProUGUI m_daysTMP;

	[SerializeField]
	private Gradient2[] m_gradient2;

	[Header("Streak Animations")]
	[Tooltip("Animation to play when no thresholds match (optional)")]
	[SerializeField]
	private string m_defaultStreakAnimation;

	[Tooltip("Mappings of minimum streak values to animation state names. Highest threshold <= streak will be used.")]
	[SerializeField]
	private List<ThresholdAnimation> m_thresholdAnimations;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void GameplayEvents_WinStreakUpdated()
	{
	}

	private void UpdateStreakVisuals()
	{
	}

	public void PlayStreakAnimation(int streak)
	{
	}
}
