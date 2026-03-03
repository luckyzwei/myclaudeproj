using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Activeseasonidx => 0;

		public int SeasonalstagedataLength => 0;

		public int PlayedseasoninfoidxlistLength => 0;

		public int SeasonalshopdataLength => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalData GetRootAsSeasonalData(ByteBuffer _bb)
		{
			return default(SeasonalData);
		}

		public static SeasonalData GetRootAsSeasonalData(ByteBuffer _bb, SeasonalData obj)
		{
			return default(SeasonalData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalData);
		}

		public bool MutateActiveseasonidx(int activeseasonidx)
		{
			return false;
		}

		public SeasonalStageData? Seasonalstagedata(int j)
		{
			return null;
		}

		public int Playedseasoninfoidxlist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetPlayedseasoninfoidxlistBytes()
		{
			return null;
		}

		public int[] GetPlayedseasoninfoidxlistArray()
		{
			return null;
		}

		public bool MutatePlayedseasoninfoidxlist(int j, int playedseasoninfoidxlist)
		{
			return false;
		}

		public SeasonalShopData? Seasonalshopdata(int j)
		{
			return null;
		}

		public static Offset<SeasonalData> CreateSeasonalData(FlatBufferBuilder builder, int activeseasonidx = 0, VectorOffset seasonalstagedataOffset = default(VectorOffset), VectorOffset playedseasoninfoidxlistOffset = default(VectorOffset), VectorOffset seasonalshopdataOffset = default(VectorOffset))
		{
			return default(Offset<SeasonalData>);
		}

		public static void StartSeasonalData(FlatBufferBuilder builder)
		{
		}

		public static void AddActiveseasonidx(FlatBufferBuilder builder, int activeseasonidx)
		{
		}

		public static void AddSeasonalstagedata(FlatBufferBuilder builder, VectorOffset seasonalstagedataOffset)
		{
		}

		public static VectorOffset CreateSeasonalstagedataVector(FlatBufferBuilder builder, Offset<SeasonalStageData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSeasonalstagedataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalStageData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSeasonalstagedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalStageData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSeasonalstagedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartSeasonalstagedataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPlayedseasoninfoidxlist(FlatBufferBuilder builder, VectorOffset playedseasoninfoidxlistOffset)
		{
		}

		public static VectorOffset CreatePlayedseasoninfoidxlistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePlayedseasoninfoidxlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePlayedseasoninfoidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePlayedseasoninfoidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartPlayedseasoninfoidxlistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddSeasonalshopdata(FlatBufferBuilder builder, VectorOffset seasonalshopdataOffset)
		{
		}

		public static VectorOffset CreateSeasonalshopdataVector(FlatBufferBuilder builder, Offset<SeasonalShopData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSeasonalshopdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalShopData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSeasonalshopdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalShopData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSeasonalshopdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartSeasonalshopdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<SeasonalData> EndSeasonalData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalData>);
		}

		public SeasonalDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalDataT _o)
		{
		}

		public static Offset<SeasonalData> Pack(FlatBufferBuilder builder, SeasonalDataT _o)
		{
			return default(Offset<SeasonalData>);
		}
	}
}
