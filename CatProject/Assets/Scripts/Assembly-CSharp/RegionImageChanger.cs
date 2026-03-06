using System;
using System.Collections.Generic;
using UnityEngine;

public class RegionImageChanger : MonoBehaviour
{
	[Serializable]
	public class RegionData
	{
		public int regionIdx;

		public Sprite img;
	}

	[SerializeField]
	private List<RegionData> regionDatas;

	[SerializeField]
	private bool allEnableCheck;

	private Sprite originSprite;

	private void Awake()
	{
		// Initialize region image changer
	}

	private void OnEnable()
	{
		// Enabled
	}
}
