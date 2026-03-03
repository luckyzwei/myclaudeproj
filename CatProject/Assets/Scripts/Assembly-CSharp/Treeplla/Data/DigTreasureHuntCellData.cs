using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct DigTreasureHuntCellData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Itemindex => 0;

		public bool Isopened => false;

		public static void ValidateVersion()
		{
		}

		public static DigTreasureHuntCellData GetRootAsDigTreasureHuntCellData(ByteBuffer _bb)
		{
			return default(DigTreasureHuntCellData);
		}

		public static DigTreasureHuntCellData GetRootAsDigTreasureHuntCellData(ByteBuffer _bb, DigTreasureHuntCellData obj)
		{
			return default(DigTreasureHuntCellData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public DigTreasureHuntCellData __assign(int _i, ByteBuffer _bb)
		{
			return default(DigTreasureHuntCellData);
		}

		public bool MutateItemindex(int itemindex)
		{
			return false;
		}

		public bool MutateIsopened(bool isopened)
		{
			return false;
		}

		public static Offset<DigTreasureHuntCellData> CreateDigTreasureHuntCellData(FlatBufferBuilder builder, int itemindex = 0, bool isopened = false)
		{
			return default(Offset<DigTreasureHuntCellData>);
		}

		public static void StartDigTreasureHuntCellData(FlatBufferBuilder builder)
		{
		}

		public static void AddItemindex(FlatBufferBuilder builder, int itemindex)
		{
		}

		public static void AddIsopened(FlatBufferBuilder builder, bool isopened)
		{
		}

		public static Offset<DigTreasureHuntCellData> EndDigTreasureHuntCellData(FlatBufferBuilder builder)
		{
			return default(Offset<DigTreasureHuntCellData>);
		}

		public DigTreasureHuntCellDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(DigTreasureHuntCellDataT _o)
		{
		}

		public static Offset<DigTreasureHuntCellData> Pack(FlatBufferBuilder builder, DigTreasureHuntCellDataT _o)
		{
			return default(Offset<DigTreasureHuntCellData>);
		}
	}
}
