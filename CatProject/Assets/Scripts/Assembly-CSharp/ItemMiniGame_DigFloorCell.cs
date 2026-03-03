using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemMiniGame_DigFloorCell : MonoBehaviour
{
	[SerializeField]
	private GameObject FloorRoot;

	[SerializeField]
	private Button FloorBtn;

	private Action<Vector2Int> OnClickedCell;

	public Vector2Int Position { get; private set; }

	private void Awake()
	{
	}

	public void Init(Vector2Int position, bool isOpened, Action<Vector2Int> onClickedCell)
	{
	}

	public void OpenCell(bool isOpened)
	{
	}

	private void OnFloorBtnClick()
	{
	}
}
