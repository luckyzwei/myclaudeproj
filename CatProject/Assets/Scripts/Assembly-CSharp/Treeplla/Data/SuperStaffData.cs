using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SuperStaffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Level => 0;

		public static void ValidateVersion()
		{
		}

		public static SuperStaffData GetRootAsSuperStaffData(ByteBuffer _bb)
		{
			return default(SuperStaffData);
		}

		public static SuperStaffData GetRootAsSuperStaffData(ByteBuffer _bb, SuperStaffData obj)
		{
			return default(SuperStaffData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SuperStaffData __assign(int _i, ByteBuffer _bb)
		{
			return default(SuperStaffData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public static Offset<SuperStaffData> CreateSuperStaffData(FlatBufferBuilder builder, int idx = 0, int level = 0)
		{
			return default(Offset<SuperStaffData>);
		}

		public static void StartSuperStaffData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static Offset<SuperStaffData> EndSuperStaffData(FlatBufferBuilder builder)
		{
			return default(Offset<SuperStaffData>);
		}

		public SuperStaffDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SuperStaffDataT _o)
		{
		}

		public static Offset<SuperStaffData> Pack(FlatBufferBuilder builder, SuperStaffDataT _o)
		{
			return default(Offset<SuperStaffData>);
		}
	}
}
