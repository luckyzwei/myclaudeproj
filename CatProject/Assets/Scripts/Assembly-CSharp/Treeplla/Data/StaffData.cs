using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct StaffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Type => 0;

		public int Count => 0;

		public float Speed => 0f;

		public static void ValidateVersion()
		{
		}

		public static StaffData GetRootAsStaffData(ByteBuffer _bb)
		{
			return default(StaffData);
		}

		public static StaffData GetRootAsStaffData(ByteBuffer _bb, StaffData obj)
		{
			return default(StaffData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public StaffData __assign(int _i, ByteBuffer _bb)
		{
			return default(StaffData);
		}

		public bool MutateType(int type)
		{
			return false;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public bool MutateSpeed(float speed)
		{
			return false;
		}

		public static Offset<StaffData> CreateStaffData(FlatBufferBuilder builder, int type = 0, int count = 0, float speed = 1f)
		{
			return default(Offset<StaffData>);
		}

		public static void StartStaffData(FlatBufferBuilder builder)
		{
		}

		public static void AddType(FlatBufferBuilder builder, int type)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
		}

		public static Offset<StaffData> EndStaffData(FlatBufferBuilder builder)
		{
			return default(Offset<StaffData>);
		}

		public StaffDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(StaffDataT _o)
		{
		}

		public static Offset<StaffData> Pack(FlatBufferBuilder builder, StaffDataT _o)
		{
			return default(Offset<StaffData>);
		}
	}
}
