using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ManagerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Level => 0;

		public int Count => 0;

		public int Reinforcelevel => 0;

		public int Skilllevel => 0;

		public long Reinforceresetlasttime => 0L;

		public static void ValidateVersion()
		{
		}

		public static ManagerData GetRootAsManagerData(ByteBuffer _bb)
		{
			return default(ManagerData);
		}

		public static ManagerData GetRootAsManagerData(ByteBuffer _bb, ManagerData obj)
		{
			return default(ManagerData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public ManagerData __assign(int _i, ByteBuffer _bb)
		{
			return default(ManagerData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public bool MutateReinforcelevel(int reinforcelevel)
		{
			return false;
		}

		public bool MutateSkilllevel(int skilllevel)
		{
			return false;
		}

		public bool MutateReinforceresetlasttime(long reinforceresetlasttime)
		{
			return false;
		}

		public static Offset<ManagerData> CreateManagerData(FlatBufferBuilder builder, int idx = 0, int level = 0, int count = 0, int reinforcelevel = 0, int skilllevel = 0, long reinforceresetlasttime = 0L)
		{
			return default(Offset<ManagerData>);
		}

		public static void StartManagerData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static void AddReinforcelevel(FlatBufferBuilder builder, int reinforcelevel)
		{
		}

		public static void AddSkilllevel(FlatBufferBuilder builder, int skilllevel)
		{
		}

		public static void AddReinforceresetlasttime(FlatBufferBuilder builder, long reinforceresetlasttime)
		{
		}

		public static Offset<ManagerData> EndManagerData(FlatBufferBuilder builder)
		{
			return default(Offset<ManagerData>);
		}

		public ManagerDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(ManagerDataT _o)
		{
		}

		public static Offset<ManagerData> Pack(FlatBufferBuilder builder, ManagerDataT _o)
		{
			return default(Offset<ManagerData>);
		}
	}
}
