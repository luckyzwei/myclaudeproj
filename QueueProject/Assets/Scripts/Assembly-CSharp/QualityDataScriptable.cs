using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QualityDataSettings", menuName = "Kwalee/KWPerformance/QualityDataSettings", order = 1)]
public class QualityDataScriptable : ScriptableObject
{
	[Serializable]
	public class DeviceSetting
	{
		public string model;

		public int quality;
	}

	public List<DeviceSetting> settings;
}
