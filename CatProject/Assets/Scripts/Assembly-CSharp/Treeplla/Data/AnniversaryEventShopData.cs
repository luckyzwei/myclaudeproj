using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AnniversaryEventShopData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Itemidx => 0;

		public int Itembuycount => 0;

		public static void ValidateVersion()
		{
		}

		public static AnniversaryEventShopData GetRootAsAnniversaryEventShopData(ByteBuffer _bb)
		{
			return default(AnniversaryEventShopData);
		}

		public static AnniversaryEventShopData GetRootAsAnniversaryEventShopData(ByteBuffer _bb, AnniversaryEventShopData obj)
		{
			return default(AnniversaryEventShopData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AnniversaryEventShopData __assign(int _i, ByteBuffer _bb)
		{
			return default(AnniversaryEventShopData);
		}

		public bool MutateItemidx(int itemidx)
		{
			return false;
		}

		public bool MutateItembuycount(int itembuycount)
		{
			return false;
		}

		public static Offset<AnniversaryEventShopData> CreateAnniversaryEventShopData(FlatBufferBuilder builder, int itemidx = 0, int itembuycount = 0)
		{
			return default(Offset<AnniversaryEventShopData>);
		}

		public static void StartAnniversaryEventShopData(FlatBufferBuilder builder)
		{
		}

		public static void AddItemidx(FlatBufferBuilder builder, int itemidx)
		{
		}

		public static void AddItembuycount(FlatBufferBuilder builder, int itembuycount)
		{
		}

		public static Offset<AnniversaryEventShopData> EndAnniversaryEventShopData(FlatBufferBuilder builder)
		{
			return default(Offset<AnniversaryEventShopData>);
		}

		public AnniversaryEventShopDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(AnniversaryEventShopDataT _o)
		{
		}

		public static Offset<AnniversaryEventShopData> Pack(FlatBufferBuilder builder, AnniversaryEventShopDataT _o)
		{
			return default(Offset<AnniversaryEventShopData>);
		}
	}
}
