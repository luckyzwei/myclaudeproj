using System.Collections.Generic;
using UnityEngine;

public class FrameRateTracker : MonoBehaviour
{
	public class FrameRateData
	{
		public float averageFrameRate;

		public float frameRateStd;

		public float percentile95;

		public int numFrames;
	}

	private const float FPS_SAMPLE_INTERVAL = 1f;

	private const int MAX_FPS = 120;

	private static bool s_isTracking;

	private static float s_totalFrameTime;

	private static float s_rollingFrameTime;

	private static int s_frameCount;

	private static int s_rollingFrameCount;

	private static float[] s_frames;

	private static List<float> s_fpss;

	public static void StartTracking()
	{
	}

	public static FrameRateData StopTracking()
	{
		return null;
	}

	public static bool IsTracking()
	{
		return false;
	}

	private void Update()
	{
	}

	private static float Calculate95thPercentile(List<float> values)
	{
		return 0f;
	}

	private static float CalculateStandardDeviation(List<float> values)
	{
		return 0f;
	}

	public static FrameRateData CalculateStatistics()
	{
		return null;
	}
}
