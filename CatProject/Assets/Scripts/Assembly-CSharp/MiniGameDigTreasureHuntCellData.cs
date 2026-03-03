using Google.FlatBuffers;
using Treeplla.Data;

public class MiniGameDigTreasureHuntCellData
{
	public int ItemIndex { get; set; }

	public bool IsOpened { get; set; }

	public static MiniGameDigTreasureHuntCellData FromFlatBuffer(DigTreasureHuntCellData data)
	{
		return null;
	}

	public static Offset<DigTreasureHuntCellData> ToFlatBuffer(FlatBufferBuilder builder, MiniGameDigTreasureHuntCellData cellData)
	{
		return default(Offset<DigTreasureHuntCellData>);
	}
}
