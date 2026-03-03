using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalCoinRankData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public long Startranktime => 0L;

		public int Accumulatecnt => 0;

		public bool End => false;

		public int UserdataLength => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalCoinRankData GetRootAsSeasonalCoinRankData(ByteBuffer _bb)
		{
			return default(SeasonalCoinRankData);
		}

		public static SeasonalCoinRankData GetRootAsSeasonalCoinRankData(ByteBuffer _bb, SeasonalCoinRankData obj)
		{
			return default(SeasonalCoinRankData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalCoinRankData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalCoinRankData);
		}

		public bool MutateStartranktime(long startranktime)
		{
			return false;
		}

		public bool MutateAccumulatecnt(int accumulatecnt)
		{
			return false;
		}

		public bool MutateEnd(bool end)
		{
			return false;
		}

		public SeasonalUserData? Userdata(int j)
		{
			return null;
		}

		public static Offset<SeasonalCoinRankData> CreateSeasonalCoinRankData(FlatBufferBuilder builder, long startranktime = 0L, int accumulatecnt = 0, bool end = false, VectorOffset userdataOffset = default(VectorOffset))
		{
			return default(Offset<SeasonalCoinRankData>);
		}

		public static void StartSeasonalCoinRankData(FlatBufferBuilder builder)
		{
		}

		public static void AddStartranktime(FlatBufferBuilder builder, long startranktime)
		{
		}

		public static void AddAccumulatecnt(FlatBufferBuilder builder, int accumulatecnt)
		{
		}

		public static void AddEnd(FlatBufferBuilder builder, bool end)
		{
		}

		public static void AddUserdata(FlatBufferBuilder builder, VectorOffset userdataOffset)
		{
		}

		public static VectorOffset CreateUserdataVector(FlatBufferBuilder builder, Offset<SeasonalUserData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateUserdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalUserData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateUserdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalUserData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateUserdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartUserdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<SeasonalCoinRankData> EndSeasonalCoinRankData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalCoinRankData>);
		}

		public SeasonalCoinRankDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalCoinRankDataT _o)
		{
		}

		public static Offset<SeasonalCoinRankData> Pack(FlatBufferBuilder builder, SeasonalCoinRankDataT _o)
		{
			return default(Offset<SeasonalCoinRankData>);
		}
	}
}
