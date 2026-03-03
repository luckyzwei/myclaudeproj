using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MiniGameData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int DigtreasurehuntdataLength => 0;

		public int ShopdataLength => 0;

		public int Lastplayscheduleidx => 0;

		public bool Shownopenpopup => false;

		public static void ValidateVersion()
		{
		}

		public static MiniGameData GetRootAsMiniGameData(ByteBuffer _bb)
		{
			return default(MiniGameData);
		}

		public static MiniGameData GetRootAsMiniGameData(ByteBuffer _bb, MiniGameData obj)
		{
			return default(MiniGameData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public MiniGameData __assign(int _i, ByteBuffer _bb)
		{
			return default(MiniGameData);
		}

		public DigTreasureHuntData? Digtreasurehuntdata(int j)
		{
			return null;
		}

		public MiniGameShopData? Shopdata(int j)
		{
			return null;
		}

		public bool MutateLastplayscheduleidx(int lastplayscheduleidx)
		{
			return false;
		}

		public bool MutateShownopenpopup(bool shownopenpopup)
		{
			return false;
		}

		public static Offset<MiniGameData> CreateMiniGameData(FlatBufferBuilder builder, VectorOffset digtreasurehuntdataOffset = default(VectorOffset), VectorOffset shopdataOffset = default(VectorOffset), int lastplayscheduleidx = 0, bool shownopenpopup = false)
		{
			return default(Offset<MiniGameData>);
		}

		public static void StartMiniGameData(FlatBufferBuilder builder)
		{
		}

		public static void AddDigtreasurehuntdata(FlatBufferBuilder builder, VectorOffset digtreasurehuntdataOffset)
		{
		}

		public static VectorOffset CreateDigtreasurehuntdataVector(FlatBufferBuilder builder, Offset<DigTreasureHuntData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateDigtreasurehuntdataVectorBlock(FlatBufferBuilder builder, Offset<DigTreasureHuntData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateDigtreasurehuntdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<DigTreasureHuntData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateDigtreasurehuntdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartDigtreasurehuntdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddShopdata(FlatBufferBuilder builder, VectorOffset shopdataOffset)
		{
		}

		public static VectorOffset CreateShopdataVector(FlatBufferBuilder builder, Offset<MiniGameShopData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateShopdataVectorBlock(FlatBufferBuilder builder, Offset<MiniGameShopData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateShopdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<MiniGameShopData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateShopdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartShopdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddLastplayscheduleidx(FlatBufferBuilder builder, int lastplayscheduleidx)
		{
		}

		public static void AddShownopenpopup(FlatBufferBuilder builder, bool shownopenpopup)
		{
		}

		public static Offset<MiniGameData> EndMiniGameData(FlatBufferBuilder builder)
		{
			return default(Offset<MiniGameData>);
		}

		public MiniGameDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(MiniGameDataT _o)
		{
		}

		public static Offset<MiniGameData> Pack(FlatBufferBuilder builder, MiniGameDataT _o)
		{
			return default(Offset<MiniGameData>);
		}
	}
}
