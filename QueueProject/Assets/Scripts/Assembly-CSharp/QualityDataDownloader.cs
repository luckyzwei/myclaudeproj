using System.Collections;
using KWQualitySettings;
using UnityEngine;

[RequireComponent(typeof(QualityDataHandler))]
[RequireComponent(typeof(QualitySettingsManager))]
public class QualityDataDownloader : LoadDataFromServer
{
	[SerializeField]
	private QualityDataHandler m_qualityDataHandler;

	[SerializeField]
	private QualitySettingsManager qualitySettingsManager;

	private KWQualitySettings.QualitySettings m_settings;

	protected override void Init()
	{
	}

	protected override void OnValidate()
	{
	}

	protected override DataSheetSettings GetDataSheetSettings()
	{
		return null;
	}

	protected override void DataLoaded(Hashtable data)
	{
	}
}
