using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BoostTokenData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Tokeidx => 0;

		public long Endtime => 0L;

		public static void ValidateVersion()
		{
		}

		public static BoostTokenData GetRootAsBoostTokenData(ByteBuffer _bb)
		{
			return default(BoostTokenData);
		}

		public static BoostTokenData GetRootAsBoostTokenData(ByteBuffer _bb, BoostTokenData obj)
		{
			return default(BoostTokenData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BoostTokenData __assign(int _i, ByteBuffer _bb)
		{
			return default(BoostTokenData);
		}

		public bool MutateTokeidx(int tokeidx)
		{
			return false;
		}

		public bool MutateEndtime(long endtime)
		{
			return false;
		}

		public static Offset<BoostTokenData> CreateBoostTokenData(FlatBufferBuilder builder, int tokeidx = 0, long endtime = 0L)
		{
			return default(Offset<BoostTokenData>);
		}

		public static void StartBoostTokenData(FlatBufferBuilder builder)
		{
		}

		public static void AddTokeidx(FlatBufferBuilder builder, int tokeidx)
		{
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
		}

		public static Offset<BoostTokenData> EndBoostTokenData(FlatBufferBuilder builder)
		{
			return default(Offset<BoostTokenData>);
		}

		public BoostTokenDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BoostTokenDataT _o)
		{
		}

		public static Offset<BoostTokenData> Pack(FlatBufferBuilder builder, BoostTokenDataT _o)
		{
			return default(Offset<BoostTokenData>);
		}
	}
}
