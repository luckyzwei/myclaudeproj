using System;
using UnityEngine;

public class RecordingPlayback : MonoBehaviour
{
	private const float CHANCE_OF_CUSTOM_SKIN = 0.33f;

	private const string DEFAULT_SKIN = "Skin_A";

	private const string DEFAULT_COLOR = "BoardColors_A";

	private const float DEFAULT_SPEED = 2f;

	private const float EPS = 0.0001f;

	[SerializeField]
	private GridPlayback m_grid;

	[SerializeField]
	private ScaledTimeTimer m_timer;

	[SerializeField]
	private QueensRowWidget m_queensRowWidget;

	[SerializeField]
	private float m_endSpeedMultiplier;

	[SerializeField]
	private AnimationCurve m_speedCurve;

	[SerializeField]
	private bool m_isOpponent;

	private LevelPlayRecording m_recording;

	private Action m_finishCallback;

	private float m_playbackSpeed;

	private float m_time;

	private int m_actionIndex;

	private bool m_isPlaying;

	private float m_duration;

	public bool IsPlaying => false;

	public float Progress => 0f;

	public void ConfigPlayback(LevelPlayRecording recording, float duration, Action callback = null)
	{
	}

	private float CalculateSpeedFromDuration(LevelPlayRecording recording, float duration)
	{
		return 0f;
	}

	private float CalculateInverseCurveIntegral01(int steps = 60)
	{
		return 0f;
	}

	private void ConfigGrid()
	{
	}

	[ContextMenu("Play")]
	public void StartPlayback(Action callback = null)
	{
	}

	private void Update()
	{
	}

	private bool ProgressTime(float deltaTime)
	{
		return false;
	}

	private void PlaySingleAction(UserSingleAction action)
	{
	}

	public void SkipToEnd()
	{
	}
}
