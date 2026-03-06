using System.Collections.Generic;
using Treeplla;
using UnityEngine;

public class MiniGame_DigTreasureHunt : MiniGameBase
{
	private Cell[,] Grid;

	private List<PlacedItemInfo> PlacedItems;

	public int ScheduleIdx { get; private set; }

	public int EventIdx { get; private set; }

	public int StageIdx { get; private set; }

	public int MaxStageIdx { get; private set; }

	public bool IsGameClear { get; private set; }

	public Vector2Int BoardSize { get; private set; }

	public override void Init(int scheduleIdx, int eventIdx)
	{
		ScheduleIdx = scheduleIdx;
		EventIdx = eventIdx;
		IsGameClear = false;

		var userData = Singleton<GameRoot>.Instance.UserData;
		var miniGameUserData = userData?.MiniGameUserData;
		var savedData = miniGameUserData?.GetDigTreasureHuntUserData(scheduleIdx);

		if (savedData != null && savedData.EventIdx == eventIdx)
		{
			StageIdx = savedData.StageIdx;
			// Restore grid from saved data
			if (savedData.Grid != null)
			{
				int savedWidth = savedData.Grid.GetLength(0);
				int savedHeight = savedData.Grid.GetLength(1);
				BoardSize = new Vector2Int(savedWidth, savedHeight);
				SetGrid(savedWidth, savedHeight);
				PlacedItems = new List<PlacedItemInfo>();

				for (int x = 0; x < savedWidth; x++)
				{
					for (int y = 0; y < savedHeight; y++)
					{
						var cellData = savedData.Grid[x, y];
						if (cellData != null)
						{
							Grid[x, y].ItemIndex = cellData.ItemIndex;
							Grid[x, y].IsOpened = cellData.IsOpened;
						}
					}
				}
			}
			else
			{
				CreateNewStage(eventIdx, StageIdx);
			}
		}
		else
		{
			StageIdx = 0;
			CreateNewStage(eventIdx, StageIdx);
		}
	}

	public override void Reset()
	{
		Grid = null;
		PlacedItems = null;
		ScheduleIdx = 0;
		EventIdx = 0;
		StageIdx = 0;
		MaxStageIdx = 0;
		IsGameClear = false;
		BoardSize = Vector2Int.zero;
	}

	public bool CheckAndUpdateNextStage()
	{
		if (!IsFindAllItems())
			return false;

		if (IsLastStage())
		{
			IsGameClear = true;
			SaveUserData();
			return false;
		}

		StageIdx++;
		CreateNewStage(EventIdx, StageIdx);
		SaveUserData();
		return true;
	}

	public OpenResult OpenGrid(int x, int y)
	{
		if (Grid == null || x < 0 || x >= BoardSize.x || y < 0 || y >= BoardSize.y)
			return new OpenResult(OpenResultStatus.InvalidPosition);

		Cell cell = Grid[x, y];

		if (cell.IsOpened)
			return new OpenResult(OpenResultStatus.AlreadyOpened);

		cell.IsOpened = true;

		if (cell.ItemIndex >= 0)
		{
			bool itemCompleted = IsItemFullyRevealed(cell.ItemIndex);
			SaveUserData();
			return new OpenResult(OpenResultStatus.HitItem, cell.ItemIndex, itemCompleted);
		}

		SaveUserData();
		return new OpenResult(OpenResultStatus.HitEmpty);
	}

	public bool IsItemFullyRevealed(int itemIndex)
	{
		if (Grid == null)
			return false;

		for (int x = 0; x < BoardSize.x; x++)
		{
			for (int y = 0; y < BoardSize.y; y++)
			{
				Cell cell = Grid[x, y];
				if (cell.ItemIndex == itemIndex && !cell.IsOpened)
					return false;
			}
		}
		return true;
	}

	public bool IsFindAllItems()
	{
		if (PlacedItems == null || PlacedItems.Count == 0)
			return false;

		for (int i = 0; i < PlacedItems.Count; i++)
		{
			if (!IsItemFullyRevealed(PlacedItems[i].Index))
				return false;
		}
		return true;
	}

	public bool IsLastStage()
	{
		return StageIdx >= MaxStageIdx;
	}

	public Cell GetCell(int x, int y)
	{
		if (Grid == null || x < 0 || x >= BoardSize.x || y < 0 || y >= BoardSize.y)
			return null;

		return Grid[x, y];
	}

	public IReadOnlyList<PlacedItemInfo> GetPlacedItems()
	{
		return PlacedItems;
	}

	private void CreateNewStage(int eventIdx, int stageIdx)
	{
		int boardSizeX = 6;
		int boardSizeY = 6;
		BoardSize = new Vector2Int(boardSizeX, boardSizeY);

		SetGrid(boardSizeX, boardSizeY);
		PlacedItems = new List<PlacedItemInfo>();

		TreasureItemData[] items = new TreasureItemData[]
		{
			new TreasureItemData { Id = 1, Index = 0, Size = new Vector2Int(3, 1) },
			new TreasureItemData { Id = 2, Index = 1, Size = new Vector2Int(2, 1) },
			new TreasureItemData { Id = 3, Index = 2, Size = new Vector2Int(2, 2) },
			new TreasureItemData { Id = 4, Index = 3, Size = new Vector2Int(1, 3) },
			new TreasureItemData { Id = 5, Index = 4, Size = new Vector2Int(1, 2) },
		};

		MaxStageIdx = stageIdx; // Will be set by table data if available

		PlaceItems(items);
		SaveUserData();
	}

	private void SetGrid(int boardSizeX, int boardSizeY)
	{
		Grid = new Cell[boardSizeX, boardSizeY];
		for (int x = 0; x < boardSizeX; x++)
		{
			for (int y = 0; y < boardSizeY; y++)
			{
				Grid[x, y] = new Cell();
				Grid[x, y].ItemIndex = -1;
				Grid[x, y].IsOpened = false;
			}
		}
	}

	private bool PlaceItems(TreasureItemData[] itemsToPlace)
	{
		if (itemsToPlace == null || itemsToPlace.Length == 0)
			return true;

		var items = new List<TreasureItemData>(itemsToPlace);
		items.Sort((a, b) => (b.Size.x * b.Size.y).CompareTo(a.Size.x * a.Size.y));

		return SolveWithRandomizedBacktracking(items);
	}

	private bool SolveWithRandomizedBacktracking(List<TreasureItemData> items)
	{
		if (items.Count == 0)
			return true;

		TreasureItemData currentItem = items[0];
		List<Vector2Int> validPositions = FindAllValidPositions(currentItem);

		if (validPositions.Count == 0)
			return false;

		Shuffle(validPositions);

		var remainingItems = new List<TreasureItemData>();
		for (int i = 1; i < items.Count; i++)
			remainingItems.Add(items[i]);

		for (int i = 0; i < validPositions.Count; i++)
		{
			Vector2Int pos = validPositions[i];
			PlaceItem(currentItem, pos);

			if (SolveWithRandomizedBacktracking(remainingItems))
				return true;

			UndoPlaceItem(currentItem);
		}

		return false;
	}

	private List<Vector2Int> FindAllValidPositions(TreasureItemData item)
	{
		var positions = new List<Vector2Int>();
		if (Grid == null)
			return positions;

		for (int x = 0; x <= BoardSize.x - item.Size.x; x++)
		{
			for (int y = 0; y <= BoardSize.y - item.Size.y; y++)
			{
				Vector2Int pos = new Vector2Int(x, y);
				if (CanPlaceItem(item, pos))
					positions.Add(pos);
			}
		}
		return positions;
	}

	private void UndoPlaceItem(TreasureItemData item)
	{
		if (Grid == null)
			return;

		for (int x = 0; x < BoardSize.x; x++)
		{
			for (int y = 0; y < BoardSize.y; y++)
			{
				if (Grid[x, y].ItemIndex == item.Index)
					Grid[x, y].ItemIndex = -1;
			}
		}

		for (int i = PlacedItems.Count - 1; i >= 0; i--)
		{
			if (PlacedItems[i].Index == item.Index)
			{
				PlacedItems.RemoveAt(i);
				break;
			}
		}
	}

	private bool CanPlaceItem(TreasureItemData item, Vector2Int position)
	{
		if (Grid == null)
			return false;

		for (int dx = 0; dx < item.Size.x; dx++)
		{
			for (int dy = 0; dy < item.Size.y; dy++)
			{
				int cx = position.x + dx;
				int cy = position.y + dy;

				if (cx < 0 || cx >= BoardSize.x || cy < 0 || cy >= BoardSize.y)
					return false;

				if (Grid[cx, cy].ItemIndex >= 0)
					return false;
			}
		}
		return true;
	}

	private void PlaceItem(TreasureItemData item, Vector2Int position)
	{
		for (int dx = 0; dx < item.Size.x; dx++)
		{
			for (int dy = 0; dy < item.Size.y; dy++)
			{
				Grid[position.x + dx, position.y + dy].ItemIndex = item.Index;
			}
		}

		PlacedItems.Add(new PlacedItemInfo(item.Id, item.Index, position, item.Size));
	}

	private void Shuffle<T>(List<T> list)
	{
		for (int i = list.Count - 1; i > 0; i--)
		{
			int j = Random.Range(0, i + 1);
			T temp = list[i];
			list[i] = list[j];
			list[j] = temp;
		}
	}

	private void SaveUserData()
	{
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData?.MiniGameUserData == null)
			return;

		var savedData = userData.MiniGameUserData.GetDigTreasureHuntUserData(ScheduleIdx);
		if (savedData == null)
			return;

		savedData.EventIdx = EventIdx;
		savedData.StageIdx = StageIdx;

		if (Grid != null)
		{
			int width = BoardSize.x;
			int height = BoardSize.y;
			savedData.Grid = new MiniGameDigTreasureHuntCellData[width, height];

			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < height; y++)
				{
					var cellData = new MiniGameDigTreasureHuntCellData();
					cellData.ItemIndex = Grid[x, y].ItemIndex;
					cellData.IsOpened = Grid[x, y].IsOpened;
					savedData.Grid[x, y] = cellData;
				}
			}
		}

		userData.Save();
	}
}
