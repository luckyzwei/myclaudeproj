using Google.FlatBuffers;
using Treeplla.Data;

public class MiniGameDigTreasureHuntCellData
{
	public int ItemIndex { get; set; }

	public bool IsOpened { get; set; }

	public static MiniGameDigTreasureHuntCellData FromFlatBuffer(DigTreasureHuntCellData data)
	{
		var result = new MiniGameDigTreasureHuntCellData();
		result.ItemIndex = data.Itemindex;
		result.IsOpened = data.Isopened;
		return result;
	}

	public static Offset<DigTreasureHuntCellData> ToFlatBuffer(FlatBufferBuilder builder, MiniGameDigTreasureHuntCellData cellData)
	{
		if (cellData == null) return default(Offset<DigTreasureHuntCellData>);
		return DigTreasureHuntCellData.CreateDigTreasureHuntCellData(builder, cellData.ItemIndex, cellData.IsOpened);
	}
}
