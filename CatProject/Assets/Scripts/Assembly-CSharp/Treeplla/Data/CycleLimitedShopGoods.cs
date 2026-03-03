using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CycleLimitedShopGoods : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Shopgoodsidx => 0;

		public long Nextresettime => 0L;

		public int Buycount => 0;

		public static void ValidateVersion()
		{
		}

		public static CycleLimitedShopGoods GetRootAsCycleLimitedShopGoods(ByteBuffer _bb)
		{
			return default(CycleLimitedShopGoods);
		}

		public static CycleLimitedShopGoods GetRootAsCycleLimitedShopGoods(ByteBuffer _bb, CycleLimitedShopGoods obj)
		{
			return default(CycleLimitedShopGoods);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public CycleLimitedShopGoods __assign(int _i, ByteBuffer _bb)
		{
			return default(CycleLimitedShopGoods);
		}

		public bool MutateShopgoodsidx(int shopgoodsidx)
		{
			return false;
		}

		public bool MutateNextresettime(long nextresettime)
		{
			return false;
		}

		public bool MutateBuycount(int buycount)
		{
			return false;
		}

		public static Offset<CycleLimitedShopGoods> CreateCycleLimitedShopGoods(FlatBufferBuilder builder, int shopgoodsidx = 0, long nextresettime = 0L, int buycount = 0)
		{
			return default(Offset<CycleLimitedShopGoods>);
		}

		public static void StartCycleLimitedShopGoods(FlatBufferBuilder builder)
		{
		}

		public static void AddShopgoodsidx(FlatBufferBuilder builder, int shopgoodsidx)
		{
		}

		public static void AddNextresettime(FlatBufferBuilder builder, long nextresettime)
		{
		}

		public static void AddBuycount(FlatBufferBuilder builder, int buycount)
		{
		}

		public static Offset<CycleLimitedShopGoods> EndCycleLimitedShopGoods(FlatBufferBuilder builder)
		{
			return default(Offset<CycleLimitedShopGoods>);
		}

		public CycleLimitedShopGoodsT UnPack()
		{
			return null;
		}

		public void UnPackTo(CycleLimitedShopGoodsT _o)
		{
		}

		public static Offset<CycleLimitedShopGoods> Pack(FlatBufferBuilder builder, CycleLimitedShopGoodsT _o)
		{
			return default(Offset<CycleLimitedShopGoods>);
		}
	}
}
