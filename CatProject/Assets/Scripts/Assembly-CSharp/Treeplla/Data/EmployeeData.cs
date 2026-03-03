using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EmployeeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Seat => 0;

		public int Idx => 0;

		public int Viewidx => 0;

		public static void ValidateVersion()
		{
		}

		public static EmployeeData GetRootAsEmployeeData(ByteBuffer _bb)
		{
			return default(EmployeeData);
		}

		public static EmployeeData GetRootAsEmployeeData(ByteBuffer _bb, EmployeeData obj)
		{
			return default(EmployeeData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public EmployeeData __assign(int _i, ByteBuffer _bb)
		{
			return default(EmployeeData);
		}

		public bool MutateSeat(int seat)
		{
			return false;
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateViewidx(int viewidx)
		{
			return false;
		}

		public static Offset<EmployeeData> CreateEmployeeData(FlatBufferBuilder builder, int seat = 0, int idx = 0, int viewidx = 0)
		{
			return default(Offset<EmployeeData>);
		}

		public static void StartEmployeeData(FlatBufferBuilder builder)
		{
		}

		public static void AddSeat(FlatBufferBuilder builder, int seat)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddViewidx(FlatBufferBuilder builder, int viewidx)
		{
		}

		public static Offset<EmployeeData> EndEmployeeData(FlatBufferBuilder builder)
		{
			return default(Offset<EmployeeData>);
		}

		public EmployeeDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(EmployeeDataT _o)
		{
		}

		public static Offset<EmployeeData> Pack(FlatBufferBuilder builder, EmployeeDataT _o)
		{
			return default(Offset<EmployeeData>);
		}
	}
}
