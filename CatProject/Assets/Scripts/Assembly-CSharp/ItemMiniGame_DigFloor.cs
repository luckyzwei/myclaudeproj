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
	}

	public void SetItem(Vector2Int startCellPos, ItemMiniGame_DigTreasure item)
	{
	}

	public void OpenCell(Vector2Int position, bool isOpened)
	{
	}

	public GameObject GetCell(Vector2Int position)
	{
		return null;
	}
}
