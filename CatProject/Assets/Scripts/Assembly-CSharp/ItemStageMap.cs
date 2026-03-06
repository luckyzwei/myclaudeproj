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
		if (RegionName != null) RegionName.text = region.ToString();
		if (LastRegionObj != null) LastRegionObj.SetActive(false);

		if (Spots != null)
		{
			for (int i = 0; i < Spots.Count; i++)
			{
				if (Spots[i] != null)
				{
					Spots[i].SetStage(i);
					Spots[i].OnClick = OnClickStageSpot;
				}
			}
		}
	}

	private void OnClickStageSpot(int stage, Transform trans)
	{
		OnClickStage?.Invoke(stage, trans);
	}
}
