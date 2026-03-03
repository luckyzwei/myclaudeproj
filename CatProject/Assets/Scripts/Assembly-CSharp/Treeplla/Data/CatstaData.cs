using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CatstaData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Order => 0;

		public int Type => 0;

		public int Idx => 0;

		public bool Like => false;

		public bool Reward => false;

		public static void ValidateVersion()
		{
		}

		public static CatstaData GetRootAsCatstaData(ByteBuffer _bb)
		{
			return default(CatstaData);
		}

		public static CatstaData GetRootAsCatstaData(ByteBuffer _bb, CatstaData obj)
		{
			return default(CatstaData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public CatstaData __assign(int _i, ByteBuffer _bb)
		{
			return default(CatstaData);
		}

		public bool MutateOrder(int order)
		{
			return false;
		}

		public bool MutateType(int type)
		{
			return false;
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateLike(bool like)
		{
			return false;
		}

		public bool MutateReward(bool reward)
		{
			return false;
		}

		public static Offset<CatstaData> CreateCatstaData(FlatBufferBuilder builder, int order = 0, int type = 0, int idx = 0, bool like = false, bool reward = false)
		{
			return default(Offset<CatstaData>);
		}

		public static void StartCatstaData(FlatBufferBuilder builder)
		{
		}

		public static void AddOrder(FlatBufferBuilder builder, int order)
		{
		}

		public static void AddType(FlatBufferBuilder builder, int type)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddLike(FlatBufferBuilder builder, bool like)
		{
		}

		public static void AddReward(FlatBufferBuilder builder, bool reward)
		{
		}

		public static Offset<CatstaData> EndCatstaData(FlatBufferBuilder builder)
		{
			return default(Offset<CatstaData>);
		}

		public CatstaDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(CatstaDataT _o)
		{
		}

		public static Offset<CatstaData> Pack(FlatBufferBuilder builder, CatstaDataT _o)
		{
			return default(Offset<CatstaData>);
		}
	}
}
