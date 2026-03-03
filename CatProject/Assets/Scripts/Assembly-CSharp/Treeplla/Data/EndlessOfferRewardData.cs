using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EndlessOfferRewardData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Endlessidx => 0;

		public int Orderidx => 0;

		public bool Isbuy => false;

		public static void ValidateVersion()
		{
		}

		public static EndlessOfferRewardData GetRootAsEndlessOfferRewardData(ByteBuffer _bb)
		{
			return default(EndlessOfferRewardData);
		}

		public static EndlessOfferRewardData GetRootAsEndlessOfferRewardData(ByteBuffer _bb, EndlessOfferRewardData obj)
		{
			return default(EndlessOfferRewardData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public EndlessOfferRewardData __assign(int _i, ByteBuffer _bb)
		{
			return default(EndlessOfferRewardData);
		}

		public bool MutateEndlessidx(int endlessidx)
		{
			return false;
		}

		public bool MutateOrderidx(int orderidx)
		{
			return false;
		}

		public bool MutateIsbuy(bool isbuy)
		{
			return false;
		}

		public static Offset<EndlessOfferRewardData> CreateEndlessOfferRewardData(FlatBufferBuilder builder, int endlessidx = 0, int orderidx = 0, bool isbuy = false)
		{
			return default(Offset<EndlessOfferRewardData>);
		}

		public static void StartEndlessOfferRewardData(FlatBufferBuilder builder)
		{
		}

		public static void AddEndlessidx(FlatBufferBuilder builder, int endlessidx)
		{
		}

		public static void AddOrderidx(FlatBufferBuilder builder, int orderidx)
		{
		}

		public static void AddIsbuy(FlatBufferBuilder builder, bool isbuy)
		{
		}

		public static Offset<EndlessOfferRewardData> EndEndlessOfferRewardData(FlatBufferBuilder builder)
		{
			return default(Offset<EndlessOfferRewardData>);
		}

		public EndlessOfferRewardDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(EndlessOfferRewardDataT _o)
		{
		}

		public static Offset<EndlessOfferRewardData> Pack(FlatBufferBuilder builder, EndlessOfferRewardDataT _o)
		{
			return default(Offset<EndlessOfferRewardData>);
		}
	}
}
