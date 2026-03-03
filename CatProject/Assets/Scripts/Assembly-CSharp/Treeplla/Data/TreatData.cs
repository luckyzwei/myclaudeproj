using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct TreatData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public long Adusetime => 0L;

		public long Buffendtime => 0L;

		public int Count => 0;

		public static void ValidateVersion()
		{
		}

		public static TreatData GetRootAsTreatData(ByteBuffer _bb)
		{
			return default(TreatData);
		}

		public static TreatData GetRootAsTreatData(ByteBuffer _bb, TreatData obj)
		{
			return default(TreatData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public TreatData __assign(int _i, ByteBuffer _bb)
		{
			return default(TreatData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateAdusetime(long adusetime)
		{
			return false;
		}

		public bool MutateBuffendtime(long buffendtime)
		{
			return false;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public static Offset<TreatData> CreateTreatData(FlatBufferBuilder builder, int idx = 0, long adusetime = 0L, long buffendtime = 0L, int count = 0)
		{
			return default(Offset<TreatData>);
		}

		public static void StartTreatData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddAdusetime(FlatBufferBuilder builder, long adusetime)
		{
		}

		public static void AddBuffendtime(FlatBufferBuilder builder, long buffendtime)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static Offset<TreatData> EndTreatData(FlatBufferBuilder builder)
		{
			return default(Offset<TreatData>);
		}

		public TreatDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(TreatDataT _o)
		{
		}

		public static Offset<TreatData> Pack(FlatBufferBuilder builder, TreatDataT _o)
		{
			return default(Offset<TreatData>);
		}
	}
}
