using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FactoryAdsItem : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public long Resettime => 0L;

		public int Count => 0;

		public static void ValidateVersion()
		{
		}

		public static FactoryAdsItem GetRootAsFactoryAdsItem(ByteBuffer _bb)
		{
			return default(FactoryAdsItem);
		}

		public static FactoryAdsItem GetRootAsFactoryAdsItem(ByteBuffer _bb, FactoryAdsItem obj)
		{
			return default(FactoryAdsItem);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public FactoryAdsItem __assign(int _i, ByteBuffer _bb)
		{
			return default(FactoryAdsItem);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateResettime(long resettime)
		{
			return false;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public static Offset<FactoryAdsItem> CreateFactoryAdsItem(FlatBufferBuilder builder, int idx = 0, long resettime = 0L, int count = 0)
		{
			return default(Offset<FactoryAdsItem>);
		}

		public static void StartFactoryAdsItem(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddResettime(FlatBufferBuilder builder, long resettime)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static Offset<FactoryAdsItem> EndFactoryAdsItem(FlatBufferBuilder builder)
		{
			return default(Offset<FactoryAdsItem>);
		}

		public FactoryAdsItemT UnPack()
		{
			return null;
		}

		public void UnPackTo(FactoryAdsItemT _o)
		{
		}

		public static Offset<FactoryAdsItem> Pack(FlatBufferBuilder builder, FactoryAdsItemT _o)
		{
			return default(Offset<FactoryAdsItem>);
		}
	}
}
