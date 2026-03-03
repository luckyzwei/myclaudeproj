using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalDistributorData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Sellingproductidx => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalDistributorData GetRootAsSeasonalDistributorData(ByteBuffer _bb)
		{
			return default(SeasonalDistributorData);
		}

		public static SeasonalDistributorData GetRootAsSeasonalDistributorData(ByteBuffer _bb, SeasonalDistributorData obj)
		{
			return default(SeasonalDistributorData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalDistributorData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalDistributorData);
		}

		public bool MutateSellingproductidx(int sellingproductidx)
		{
			return false;
		}

		public static Offset<SeasonalDistributorData> CreateSeasonalDistributorData(FlatBufferBuilder builder, int sellingproductidx = 0)
		{
			return default(Offset<SeasonalDistributorData>);
		}

		public static void StartSeasonalDistributorData(FlatBufferBuilder builder)
		{
		}

		public static void AddSellingproductidx(FlatBufferBuilder builder, int sellingproductidx)
		{
		}

		public static Offset<SeasonalDistributorData> EndSeasonalDistributorData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalDistributorData>);
		}

		public SeasonalDistributorDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalDistributorDataT _o)
		{
		}

		public static Offset<SeasonalDistributorData> Pack(FlatBufferBuilder builder, SeasonalDistributorDataT _o)
		{
			return default(Offset<SeasonalDistributorData>);
		}
	}
}
