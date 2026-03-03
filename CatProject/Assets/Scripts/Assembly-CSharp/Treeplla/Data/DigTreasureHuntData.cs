using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct DigTreasureHuntData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Eventidx => 0;

		public int Stageidx => 0;

		public int GridLength => 0;

		public int ProgressrewardclaimedLength => 0;

		public int Scheduleidx => 0;

		public static void ValidateVersion()
		{
		}

		public static DigTreasureHuntData GetRootAsDigTreasureHuntData(ByteBuffer _bb)
		{
			return default(DigTreasureHuntData);
		}

		public static DigTreasureHuntData GetRootAsDigTreasureHuntData(ByteBuffer _bb, DigTreasureHuntData obj)
		{
			return default(DigTreasureHuntData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public DigTreasureHuntData __assign(int _i, ByteBuffer _bb)
		{
			return default(DigTreasureHuntData);
		}

		public bool MutateEventidx(int eventidx)
		{
			return false;
		}

		public bool MutateStageidx(int stageidx)
		{
			return false;
		}

		public DigTreasureHuntCellData? Grid(int j)
		{
			return null;
		}

		public bool Progressrewardclaimed(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetProgressrewardclaimedBytes()
		{
			return null;
		}

		public bool[] GetProgressrewardclaimedArray()
		{
			return null;
		}

		public bool MutateProgressrewardclaimed(int j, bool progressrewardclaimed)
		{
			return false;
		}

		public bool MutateScheduleidx(int scheduleidx)
		{
			return false;
		}

		public static Offset<DigTreasureHuntData> CreateDigTreasureHuntData(FlatBufferBuilder builder, int eventidx = 0, int stageidx = 0, VectorOffset gridOffset = default(VectorOffset), VectorOffset progressrewardclaimedOffset = default(VectorOffset), int scheduleidx = 0)
		{
			return default(Offset<DigTreasureHuntData>);
		}

		public static void StartDigTreasureHuntData(FlatBufferBuilder builder)
		{
		}

		public static void AddEventidx(FlatBufferBuilder builder, int eventidx)
		{
		}

		public static void AddStageidx(FlatBufferBuilder builder, int stageidx)
		{
		}

		public static void AddGrid(FlatBufferBuilder builder, VectorOffset gridOffset)
		{
		}

		public static VectorOffset CreateGridVector(FlatBufferBuilder builder, Offset<DigTreasureHuntCellData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGridVectorBlock(FlatBufferBuilder builder, Offset<DigTreasureHuntCellData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGridVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<DigTreasureHuntCellData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGridVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartGridVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddProgressrewardclaimed(FlatBufferBuilder builder, VectorOffset progressrewardclaimedOffset)
		{
		}

		public static VectorOffset CreateProgressrewardclaimedVector(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateProgressrewardclaimedVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateProgressrewardclaimedVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateProgressrewardclaimedVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartProgressrewardclaimedVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddScheduleidx(FlatBufferBuilder builder, int scheduleidx)
		{
		}

		public static Offset<DigTreasureHuntData> EndDigTreasureHuntData(FlatBufferBuilder builder)
		{
			return default(Offset<DigTreasureHuntData>);
		}

		public DigTreasureHuntDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(DigTreasureHuntDataT _o)
		{
		}

		public static Offset<DigTreasureHuntData> Pack(FlatBufferBuilder builder, DigTreasureHuntDataT _o)
		{
			return default(Offset<DigTreasureHuntData>);
		}
	}
}
