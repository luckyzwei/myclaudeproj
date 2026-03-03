using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EndlessOfferData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Endlessidx => 0;

		public int Curorderidx => 0;

		public long Endtime => 0L;

		public long Lastautoshowtime => 0L;

		public int Buycount => 0;

		public static void ValidateVersion()
		{
		}

		public static EndlessOfferData GetRootAsEndlessOfferData(ByteBuffer _bb)
		{
			return default(EndlessOfferData);
		}

		public static EndlessOfferData GetRootAsEndlessOfferData(ByteBuffer _bb, EndlessOfferData obj)
		{
			return default(EndlessOfferData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public EndlessOfferData __assign(int _i, ByteBuffer _bb)
		{
			return default(EndlessOfferData);
		}

		public bool MutateEndlessidx(int endlessidx)
		{
			return false;
		}

		public bool MutateCurorderidx(int curorderidx)
		{
			return false;
		}

		public bool MutateEndtime(long endtime)
		{
			return false;
		}

		public bool MutateLastautoshowtime(long lastautoshowtime)
		{
			return false;
		}

		public bool MutateBuycount(int buycount)
		{
			return false;
		}

		public static Offset<EndlessOfferData> CreateEndlessOfferData(FlatBufferBuilder builder, int endlessidx = 0, int curorderidx = 0, long endtime = 0L, long lastautoshowtime = 0L, int buycount = 0)
		{
			return default(Offset<EndlessOfferData>);
		}

		public static void StartEndlessOfferData(FlatBufferBuilder builder)
		{
		}

		public static void AddEndlessidx(FlatBufferBuilder builder, int endlessidx)
		{
		}

		public static void AddCurorderidx(FlatBufferBuilder builder, int curorderidx)
		{
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
		}

		public static void AddLastautoshowtime(FlatBufferBuilder builder, long lastautoshowtime)
		{
		}

		public static void AddBuycount(FlatBufferBuilder builder, int buycount)
		{
		}

		public static Offset<EndlessOfferData> EndEndlessOfferData(FlatBufferBuilder builder)
		{
			return default(Offset<EndlessOfferData>);
		}

		public EndlessOfferDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(EndlessOfferDataT _o)
		{
		}

		public static Offset<EndlessOfferData> Pack(FlatBufferBuilder builder, EndlessOfferDataT _o)
		{
			return default(Offset<EndlessOfferData>);
		}
	}
}
