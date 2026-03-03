using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStageMap : MonoBehaviour
{
	[SerializeField]
	private Text RegionName;

	[SerializeField]
	private List<ItemStageSpot> Spots;

	[SerializeField]
	private GameObject LastRegionObj;

	public Action<int, Transform> OnClickStage;

	public void Set(int region)
	{
	}

	private void OnClickStageSpot(int stage, Transform trans)
	{
	}
}
