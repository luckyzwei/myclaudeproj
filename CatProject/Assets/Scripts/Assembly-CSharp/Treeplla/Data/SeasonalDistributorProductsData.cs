using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalDistributorProductsData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Productidx => 0;

		public int Productlevel => 0;

		public bool Isselling => false;

		public bool Isupgradeopen => false;

		public static void ValidateVersion()
		{
		}

		public static SeasonalDistributorProductsData GetRootAsSeasonalDistributorProductsData(ByteBuffer _bb)
		{
			return default(SeasonalDistributorProductsData);
		}

		public static SeasonalDistributorProductsData GetRootAsSeasonalDistributorProductsData(ByteBuffer _bb, SeasonalDistributorProductsData obj)
		{
			return default(SeasonalDistributorProductsData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalDistributorProductsData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalDistributorProductsData);
		}

		public bool MutateProductidx(int productidx)
		{
			return false;
		}

		public bool MutateProductlevel(int productlevel)
		{
			return false;
		}

		public bool MutateIsselling(bool isselling)
		{
			return false;
		}

		public bool MutateIsupgradeopen(bool isupgradeopen)
		{
			return false;
		}

		public static Offset<SeasonalDistributorProductsData> CreateSeasonalDistributorProductsData(FlatBufferBuilder builder, int productidx = 0, int productlevel = 0, bool isselling = false, bool isupgradeopen = false)
		{
			return default(Offset<SeasonalDistributorProductsData>);
		}

		public static void StartSeasonalDistributorProductsData(FlatBufferBuilder builder)
		{
		}

		public static void AddProductidx(FlatBufferBuilder builder, int productidx)
		{
		}

		public static void AddProductlevel(FlatBufferBuilder builder, int productlevel)
		{
		}

		public static void AddIsselling(FlatBufferBuilder builder, bool isselling)
		{
		}

		public static void AddIsupgradeopen(FlatBufferBuilder builder, bool isupgradeopen)
		{
		}

		public static Offset<SeasonalDistributorProductsData> EndSeasonalDistributorProductsData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalDistributorProductsData>);
		}

		public SeasonalDistributorProductsDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalDistributorProductsDataT _o)
		{
		}

		public static Offset<SeasonalDistributorProductsData> Pack(FlatBufferBuilder builder, SeasonalDistributorProductsDataT _o)
		{
			return default(Offset<SeasonalDistributorProductsData>);
		}
	}
}
