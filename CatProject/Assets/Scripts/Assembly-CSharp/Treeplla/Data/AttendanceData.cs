using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AttendanceData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Eventtype => 0;

		public int Dayindx => 0;

		public bool Isattended => false;

		public static void ValidateVersion()
		{
		}

		public static AttendanceData GetRootAsAttendanceData(ByteBuffer _bb)
		{
			return default(AttendanceData);
		}

		public static AttendanceData GetRootAsAttendanceData(ByteBuffer _bb, AttendanceData obj)
		{
			return default(AttendanceData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AttendanceData __assign(int _i, ByteBuffer _bb)
		{
			return default(AttendanceData);
		}

		public bool MutateEventtype(int eventtype)
		{
			return false;
		}

		public bool MutateDayindx(int dayindx)
		{
			return false;
		}

		public bool MutateIsattended(bool isattended)
		{
			return false;
		}

		public static Offset<AttendanceData> CreateAttendanceData(FlatBufferBuilder builder, int eventtype = 0, int dayindx = 0, bool isattended = false)
		{
			return default(Offset<AttendanceData>);
		}

		public static void StartAttendanceData(FlatBufferBuilder builder)
		{
		}

		public static void AddEventtype(FlatBufferBuilder builder, int eventtype)
		{
		}

		public static void AddDayindx(FlatBufferBuilder builder, int dayindx)
		{
		}

		public static void AddIsattended(FlatBufferBuilder builder, bool isattended)
		{
		}

		public static Offset<AttendanceData> EndAttendanceData(FlatBufferBuilder builder)
		{
			return default(Offset<AttendanceData>);
		}

		public AttendanceDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(AttendanceDataT _o)
		{
		}

		public static Offset<AttendanceData> Pack(FlatBufferBuilder builder, AttendanceDataT _o)
		{
			return default(Offset<AttendanceData>);
		}
	}
}
