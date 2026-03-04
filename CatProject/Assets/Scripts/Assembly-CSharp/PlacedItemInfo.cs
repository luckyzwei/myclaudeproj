using UnityEngine;

public class PlacedItemInfo
{
	public int Id;

	public int Index;

	public Vector2Int Position;

	public Vector2Int Size;

	public PlacedItemInfo(int id, int index, Vector2Int position, Vector2Int size)
	{
		Id = id;
		Index = index;
		Position = position;
		Size = size;
	}
}
