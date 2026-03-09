using System;
using System.Collections.Generic;
using KWCore.Utils;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class QualitySettingsManager : MonoSingleton<QualitySettingsManager>
{
	[Serializable]
	public struct ScoreStruct
	{
		public int gpu;

		public int qualityLevel;
	}

	private const float FREQUENCY_WEIGHT = 0.5f;

	private const float SYSTEM_WEIGHT = 0.3f;

	private const float GRAPHICS_WEIGHT = 0.2f;

	[SerializeField]
	private QualityDataScriptable m_qualitySettings;

	[SerializeField]
	private List<ScoreStruct> m_iosScores;

	[SerializeField]
	private List<ScoreStruct> m_androidScores;

	[SerializeField]
	private List<UniversalRenderPipelineAsset> m_pipelineSettingsList;

	private PhoneRatingAnalytics m_analytics;

	private int m_qualityLevel;

	public int QualityLevel => 0;

	protected override void Init()
	{
	}

	public void StartTrackingFrameRate()
	{
	}

	public void SendPhoneRating()
	{
	}

	private void Start()
	{
	}

	private int FindInQualitySettings()
	{
		return 0;
	}

	public void SetQualitySettings()
	{
	}

	public void OverrideQualitySettings(int qualityLevel)
	{
	}

	private int GetAndroidQualityLevel()
	{
		return 0;
	}

	private int GetIosQualityLevel()
	{
		return 0;
	}

	private int GetQualityLevel(float score, List<ScoreStruct> scoreList)
	{
		return 0;
	}

	private void SetRenderPipelineSettings(int qualityLevel)
	{
	}
}
