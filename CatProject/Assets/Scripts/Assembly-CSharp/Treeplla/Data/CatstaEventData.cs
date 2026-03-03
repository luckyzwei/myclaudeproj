using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CatstaEventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Value => 0;

		public bool Like => false;

		public bool Reward => false;

		public static void ValidateVersion()
		{
		}

		public static CatstaEventData GetRootAsCatstaEventData(ByteBuffer _bb)
		{
			return default(CatstaEventData);
		}

		public static CatstaEventData GetRootAsCatstaEventData(ByteBuffer _bb, CatstaEventData obj)
		{
			return default(CatstaEventData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public CatstaEventData __assign(int _i, ByteBuffer _bb)
		{
			return default(CatstaEventData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateValue(int value)
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

		public static Offset<CatstaEventData> CreateCatstaEventData(FlatBufferBuilder builder, int idx = 0, int value = 0, bool like = false, bool reward = false)
		{
			return default(Offset<CatstaEventData>);
		}

		public static void StartCatstaEventData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddValue(FlatBufferBuilder builder, int value)
		{
		}

		public static void AddLike(FlatBufferBuilder builder, bool like)
		{
		}

		public static void AddReward(FlatBufferBuilder builder, bool reward)
		{
		}

		public static Offset<CatstaEventData> EndCatstaEventData(FlatBufferBuilder builder)
		{
			return default(Offset<CatstaEventData>);
		}

		public CatstaEventDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(CatstaEventDataT _o)
		{
		}

		public static Offset<CatstaEventData> Pack(FlatBufferBuilder builder, CatstaEventDataT _o)
		{
			return default(Offset<CatstaEventData>);
		}
	}
}
