using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemMiniGame_DigFloor : MonoBehaviour
{
	[SerializeField]
	private Transform FloorRootTr;

	[SerializeField]
	private Transform ItemRootTr;

	private List<ItemMiniGame_DigFloorCell> ItemMiniGame_DigFloorList;

	private int GridSize;

	public void Init(int gridSize, Action<Vector2Int> onClickedCell)
	{
		GridSize = gridSize;
		ItemMiniGame_DigFloorList = new List<ItemMiniGame_DigFloorCell>();
	}

	public void SetItem(Vector2Int startCellPos, ItemMiniGame_DigTreasure item)
	{
		if (item != null && ItemRootTr != null)
		{
			item.transform.SetParent(ItemRootTr, false);
		}
	}

	public void OpenCell(Vector2Int position, bool isOpened)
	{
		if (ItemMiniGame_DigFloorList == null) return;
		for (int i = 0; i < ItemMiniGame_DigFloorList.Count; i++)
		{
			if (ItemMiniGame_DigFloorList[i] != null && ItemMiniGame_DigFloorList[i].Position == position)
			{
				ItemMiniGame_DigFloorList[i].OpenCell(isOpened);
				break;
			}
		}
	}

	public GameObject GetCell(Vector2Int position)
	{
		if (ItemMiniGame_DigFloorList == null) return null;
		for (int i = 0; i < ItemMiniGame_DigFloorList.Count; i++)
		{
			if (ItemMiniGame_DigFloorList[i] != null && ItemMiniGame_DigFloorList[i].Position == position)
				return ItemMiniGame_DigFloorList[i].gameObject;
		}
		return null;
	}
}
