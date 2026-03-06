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
		if (FloorBtn != null) FloorBtn.onClick.AddListener(OnFloorBtnClick);
	}

	public void Init(Vector2Int position, bool isOpened, Action<Vector2Int> onClickedCell)
	{
		Position = position;
		OnClickedCell = onClickedCell;
		OpenCell(isOpened);
	}

	public void OpenCell(bool isOpened)
	{
		if (FloorRoot != null) FloorRoot.SetActive(!isOpened);
	}

	private void OnFloorBtnClick()
	{
		OnClickedCell?.Invoke(Position);
	}
}
